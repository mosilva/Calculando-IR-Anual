using System.Text.RegularExpressions;

namespace CalculandoIR.Domain.Validation
{
    internal class regex : Regex
    {
        private string v;
        private object ignorecase;

        public regex(string v, object ignorecase)
        {
            this.v = v;
            this.ignorecase = ignorecase;
        }
    }
}