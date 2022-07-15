using CalculandoIR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Domain.Entities
{
    public static class PersonList
    {
        public static List<IPerson> listAll { get; private set; } = new();

    }
}
