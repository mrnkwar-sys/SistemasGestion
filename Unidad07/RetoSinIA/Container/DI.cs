using System;
using System.Collections.Generic;
using System.Text;
using Application.UseCases;
using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Container
{
    public static class DI
    {
        //Conecta las interfaces de Domain con sus implementaciones enData y Application
        //Método de configuración que se llamará desde Program.cs para registrar los servicios en el contenedor de inyección de dependencias
        public static IServiceCollection AddContainer(this IServiceCollection services, IConfiguration configuration)
        {
            //Cada vez que una clase pida IRepositoryReserva, se le proporcionará una instancia de RepositoryReserva
            services.AddScoped<IRepositoryReserva, RepositoryReserva>();
            //Cada vez que una clase pida IUseCaseReservar, se le proporcionará una instancia de UseCaseReserva
            services.AddScoped<IUseCaseReservar, UseCaseReserva>();
            return services;
        }
    }
}
