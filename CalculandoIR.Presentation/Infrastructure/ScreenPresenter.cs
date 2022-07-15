using CalculandoIR.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Infrastructure
{
    public static class ScreenPresenter
    {
        public static string Show(string screen, string errorMessage = "", bool isSecret = false, bool toUpper = false)
        {
            var response = string.Empty;
            Console.Clear();
            Console.WriteLine(screen);

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                var defaultBackgroundColor = Console.BackgroundColor;
                var defaultForegroundColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(errorMessage);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            response = Console.ReadLine().Trim();

            if (toUpper)
                response = response.ToUpper();

            return response;
        }

        public static int GetContinue(
            string screen,
            int initialMenu,
            int endMenu)
        {
            {
                int response;
                var messages = string.Empty;

                while (!int.TryParse(Show(screen, messages), out response) ||
                    !(response >= initialMenu && response <= endMenu))
                    messages = "Opção Inválida";

                return response;
            }

        }

        public static void PressContinue()
        {
            Console.WriteLine("\n---------- Press to continue ----------");
        }

        public static int GetOption(
            string screen,
            int initialMenu,
            int endMenu)
        {
            int response;
            var messages = string.Empty;

            while (!int.TryParse(Show(screen, messages), out response) ||
                !(response >= initialMenu && response <= endMenu))
                messages = "Opção Inválida";

            return response;
        }

        public static string GetInput(
            string screen,
            Predicate<string> predicate,
            string customMessage = null)
        {
            string response;
            var messages = string.Empty;

            while (!predicate.Invoke(response = Show(screen, messages)))
                messages = customMessage;

            return response;
        }
        public static double GetValue(
        string screen,
        Predicate<string> predicate,
        string customMessage = null)
        {
            double responseDouble;
            string response;
            var messages = string.Empty;

            do
            {
                response = Show(screen, messages);
                messages = customMessage ?? "Valor inválido.";
            } while (!(double.TryParse(response, out responseDouble)) || (!predicate.Invoke(response)));

            return responseDouble;
        }

        public static string GetCpf(
        string screen,
        Predicate<string> predicate,
        string customMessage = null)
        {
            string response;
            var messages = string.Empty;

            do
            {
                response = Show(screen, messages);
                messages = customMessage ?? "CPF inválido.";
            } while (!(PersonValidation.ValidateCpf(response)));

            return response;
        }

        public static string GetCnpj(
        string screen,
        Predicate<string> predicate,
        string customMessage = null)
        {
            string response;
            var messages = string.Empty;

            do
            {
                response = Show(screen, messages);
                messages = customMessage ?? "CNPJ inválido.";
            } while (!(PersonValidation.ValidateCnpj(response)));

            return response;
        }

        public static void ReturnValueTaxPay(double annualValue, double incomeTaxPay)
        {
            Console.WriteLine("\nO valor informado foi de {0:C2}!\nO Imposto de Renda (IR) a ser pago é de {1:C2}.\n", annualValue, incomeTaxPay);
        }
    }
}
