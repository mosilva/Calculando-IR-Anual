using CalculandoIR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Domain.Entities
{
    public class NaturalPerson : IPerson
    {
        public string name { get; set; }
        public double annualValue { get; set; }
        public double incomeTaxPay { get; set; }
        public string cpf { get; set; }

        public NaturalPerson(string name, double annualValue, double incomeTaxPay)
        {
            this.name = name;
            this.annualValue = annualValue;
            this.incomeTaxPay = incomeTaxPay;
        }

        public NaturalPerson(string name, double annualValue, double incomeTaxPay, string cpf)
        {
            this.name = name;
            this.annualValue = annualValue;
            this.incomeTaxPay = incomeTaxPay;
            this.cpf = cpf; 
        }


    }
}
