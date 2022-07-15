using CalculandoIR.Domain.Validation;
using CalculandoIR.Infrastructure;
using CalculandoIR.Presentation;
using CalculandoIR.ProgramFlow.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.ProgramFlow
{
    public class MainFlow : IMainFlow
    {
        private readonly IPersonFlow _personFlow;
        public MainFlow(IPersonFlow personFlow)
        {
            _personFlow = personFlow;
        }
        public void BeginAppNavigate()
        {
            var defaultBackgroundColor = Console.BackgroundColor;
            var defaultForegroundColor = Console.BackgroundColor;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            _personFlow.InizializePersonList();

            bool control = true;

            while (control)
            {
                Console.Clear();
                control = true;
                var selectedMenu = ScreenPresenter.GetOption(
                     GeneralsMenu.GeneralMenu, 1, 4);

                switch (selectedMenu)
                {
                    case 1:
                        _personFlow.RegisterPerson();
                        ScreenPresenter.PressContinue();
                        Console.ReadKey();
                        break;
                    case 2:
                        _personFlow.ShowAllPersons();
                        ScreenPresenter.PressContinue();
                        Console.ReadKey();
                        break;
                    case 3:
                        _personFlow.ShowValueTaxPay();
                        ScreenPresenter.PressContinue();
                        Console.ReadKey();
                        break;
                    case 4:
                        control = false;
                        break;

                        

                        if (control)
                        {
                            var selectedMenuContinue = ScreenPresenter.GetContinue(
                                GeneralsMenu.ContinuePrograma, 1, 2);
                            switch (selectedMenu)
                            {
                                case 1:
                                    control = true;
                                    break;
                                case 2:
                                    control = false;
                                    break;
                            }

                        }



                }
            }

        }
    }
}

