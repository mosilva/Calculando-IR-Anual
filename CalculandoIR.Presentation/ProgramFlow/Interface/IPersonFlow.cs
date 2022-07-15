using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.ProgramFlow.Interface
{
    public interface IPersonFlow
    {
        public void InizializePersonList();
        public void RegisterPerson();
        public void GetOptionNaturalOrLegalPerson(string name, double annualValue, double incomeTaxPay);
        public void RegisterNaturalPerson(string name, double annualValue, double incomeTaxPay);
        public void RegisterLegalPerson(string name, double annualValue, double incomeTaxPay);
        public void ShowValueTaxPay();
        public void ShowAllPersons();

    }
}
