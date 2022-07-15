using CalculandoIR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Services.Interfaces
{
    public interface IPersonService
    {
        void AddPerson(IPerson person);
    }
}
