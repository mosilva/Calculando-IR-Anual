using CalculandoIR.Domain.Entities;
using CalculandoIR.Domain.Validation;
using CalculandoIR.Infrastructure;
using CalculandoIR.Presentation;
using CalculandoIR.ProgramFlow.Interface;
using CalculandoIR.Services;
using CalculandoIR.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CalculandoIR.ProgramFlow
{
    public class PersonFlow : IPersonFlow
    {
        public void InizializePersonList()
        {
            ServiceCollection services = new();
            services.AddScoped<ITaxCalculator, TaxCalculator>();
            var serviceProvider = services.BuildServiceProvider();
            var taxCalculator = serviceProvider.GetService<ITaxCalculator>();

            double incomeTaxPay = taxCalculator.TaxCalculation(100000);
            NaturalPerson naturalPerson = new NaturalPerson("Carlos Henrique Barbosa", 100000, incomeTaxPay, "111.222.333-44");

            incomeTaxPay = taxCalculator.TaxCalculation(5000000);
            LegalPerson legalPerson = new LegalPerson("Companhia LTDA.", 5000000, incomeTaxPay, "121.182-47/0001-20");

            PersonList.listAll.Add(legalPerson);
            PersonList.listAll.Add(naturalPerson);
        }

        public void ShowAllPersons()
        {
            Console.Clear();

            Console.WriteLine("\n============= Show All Registrations =============");

            foreach (var obj in PersonList.listAll)
            {
                PersonShowWithReflection.Registration(obj);
            }
        }

        public void RegisterPerson()
        {
            string name = ScreenPresenter.GetInput(PersonRegistrer.PersonName,
                PersonValidation.ValidateName,
                PersonRegistrer.PersonNameInvalid);

            double annualValue = ScreenPresenter.GetValue(PersonRegistrer.PersonValue,
                PersonValidation.ValidateValue, PersonRegistrer.PersonValueInvalid);

            ServiceCollection services = new();
            services.AddScoped<ITaxCalculator, TaxCalculator>();
            var serviceProvider = services.BuildServiceProvider();
            var taxCalculator = serviceProvider.GetService<ITaxCalculator>();
            double incomeTaxPay = taxCalculator.TaxCalculation(annualValue);

            GetOptionNaturalOrLegalPerson(name, annualValue, incomeTaxPay);
        }

        public void GetOptionNaturalOrLegalPerson(string name, double annualValue, double incomeTaxPay)
        {
            var selectedMenuPerson = ScreenPresenter.GetOption(
                GeneralsMenu.PersonMenuNaturalOrLegal, 1, 2);

            switch (selectedMenuPerson)
            {
                case 1:
                    RegisterNaturalPerson(name, annualValue, incomeTaxPay);
                    break;
                case 2:
                    RegisterLegalPerson(name, annualValue, incomeTaxPay);
                    break;
            }

        }

        public void RegisterNaturalPerson(string name, double annualValue, double incomeTaxPay)
        {
            NaturalPerson naturalPerson = new NaturalPerson(name, annualValue, incomeTaxPay);

            naturalPerson.cpf = ScreenPresenter.GetCpf(PersonRegistrer.NaturalPersonCpf,
                PersonValidation.ValidateCpf, PersonRegistrer.NaturalPersonAlreadyRegistered);      

            PersonList.listAll.Add(naturalPerson);

            PersonShowWithReflection.Registration(naturalPerson);

        }

        public void RegisterLegalPerson(string name, double annualValue, double incomeTaxPay)
        {
            LegalPerson legalPerson = new LegalPerson(name, annualValue, incomeTaxPay);

            legalPerson.cnpj = ScreenPresenter.GetCnpj(PersonRegistrer.LegalPerson,
                PersonValidation.ValidateCnpj, PersonRegistrer.LegalPersonAlreadyRegistered);

            PersonShowWithReflection.Registration(legalPerson);

            PersonList.listAll.Add(legalPerson);
            

        }
        public void ShowValueTaxPay()
        {
            double annualValue = ScreenPresenter.GetValue(PersonRegistrer.PersonValue,
            PersonValidation.ValidateValue, PersonRegistrer.PersonValueInvalid);

            ServiceCollection services = new();
            services.AddScoped<ITaxCalculator, TaxCalculator>();
            var serviceProvider = services.BuildServiceProvider();
            var taxCalculator = serviceProvider.GetService<ITaxCalculator>();
            double incomeTaxPay = taxCalculator.TaxCalculation(annualValue);

            ScreenPresenter.ReturnValueTaxPay(annualValue, incomeTaxPay);

        }

    }
}
