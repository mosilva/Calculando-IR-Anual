using CalculandoIR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Domain.Entities
{
    public class LegalPerson : IPerson
    {
        public string name { get ; set ; }
        public double annualValue { get; set; }
        public double incomeTaxPay { get; set; }
        public string cnpj { get ; set ; }

        public LegalPerson(string name, double annualValue, double incomeTaxPay)
        {
            this.name = name;
            this.annualValue = annualValue;
            this.incomeTaxPay = incomeTaxPay;
        }

        public LegalPerson(string name, double annualValue, double incomeTaxPay, string cnpj)
        {
            this.name = name;
            this.annualValue = annualValue;
            this.incomeTaxPay = incomeTaxPay;
            this.cnpj = cnpj;
        }


    }
}
