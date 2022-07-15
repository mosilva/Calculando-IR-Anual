using CalculandoIR.ProgramFlow;
using CalculandoIR.ProgramFlow.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Services
{
    public static class Configure
    {
        public static ServiceCollection ConfigureService(ServiceCollection services)
        {
            ServiceCollection service = new();
            service.AddScoped<IMainFlow, MainFlow>()
                .AddScoped<IPersonFlow, PersonFlow>();

            return service;
        }

    }
}
