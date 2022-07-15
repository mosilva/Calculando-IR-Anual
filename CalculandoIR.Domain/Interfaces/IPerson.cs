using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Domain.Interfaces
{
    public interface IPerson
    {
        public string name { get; set; }
        public double annualValue { get; set; }
        public double incomeTaxPay { get; set; }
    }
}
