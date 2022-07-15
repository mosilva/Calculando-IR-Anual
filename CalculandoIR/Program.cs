using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using CalculandoIR.Services.Interfaces;
using CalculandoIR.Services;
using CalculandoIR.Presentation.Interfaces;
using CalculandoIR.Presentation.Screen;
using CalculandoIR.ProgramFlow;
using CalculandoIR.ProgramFlow.Interface;

namespace CalculandoIR
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new();
            services = Configure.ConfigureService(services);
            var servicesProvider = services.BuildServiceProvider();
            var mainFlow = servicesProvider.GetService<IMainFlow>();

            mainFlow.BeginAppNavigate();
        }
    }
}
