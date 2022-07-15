using CalculandoIR.Presentation.Interfaces;
using CalculandoIR.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Presentation.Screen
{
    public class AddPersonScreen: IAddPersonScreen
    {
        private readonly IPersonService _personService;

        public AddPersonScreen(IPersonService personService)
        {
            _personService = personService;
        }

        public void AddPerson()
        {

        }

    }
}
