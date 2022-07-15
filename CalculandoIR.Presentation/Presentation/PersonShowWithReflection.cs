using CalculandoIR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Presentation
{
    public static class PersonShowWithReflection
    {
        public static void Registration(object obj)
        {
            Console.WriteLine("\n");
            var tipo = obj.GetType();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Registration of a " + tipo.Name);
            builder.AppendLine("\b");

            foreach (var prop in tipo.GetProperties())
            {
                builder.AppendLine(prop.Name + ": " + prop.GetValue(obj));
            }

            PrintRegistration(builder.ToString());

        }

        public static void PrintRegistration(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
