using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculandoIR.Domain.Validation
{
    public static class PersonValidation
    {
        public static bool ValidateName(string obj)
        {
            return !string.IsNullOrWhiteSpace(obj);
        }

        public static bool ValidateValue(string obj)
        {
            if (decimal.TryParse(obj, out decimal value) && value >= 0)
            {
                return true;
            }

            return false;
        }
        public static bool ValidateCpf(string obj)
        {
            Regex patern = new Regex(@"^(\d{3}.\d{3}.\d{3}-\d{2})|(\d{11})|(\d{10})$");
            return patern.IsMatch(obj);
        }

        public static bool ValidateCnpj(string obj)
        {
            Regex patern = new Regex(@"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}|\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$");
            return patern.IsMatch(obj);
        }



    }
}
