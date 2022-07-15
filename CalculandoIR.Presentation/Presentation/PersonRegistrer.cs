using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Presentation
{
    public static class PersonRegistrer
    {
        public const string PersonName = @"
Insira o nome da pessoa:";

        public const string PersonNameInvalid = @"
O nome não pode ser vazio.
";

        public const string NaturalPersonCpf = @"
Insira o CPF da pessoa física:";

        public const string NaturalPersonAlreadyRegistered = @"
CPF inválido.";

        public const string LegalPerson = @"
Insira o CNPJ da pessoa jurídica:";

        public const string LegalPersonAlreadyRegistered = @"
CNPJ inválido";

        public const string PersonValue = @"
Insira o valor para cálculo do Imposto Renda (IR) a ser pago:";

        public const string PersonValueInvalid = @"
O valor informado não é válido
";

    }
}
