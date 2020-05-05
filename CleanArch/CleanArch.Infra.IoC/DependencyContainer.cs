using CleanArch.Applicaation.Interfaces;
using CleanArch.Applicaation.Services;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemory MediatR BUS
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Interface
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>>();

            //Applicaion Layer
            services.AddScoped<ICourseService, CourseService>();

            //Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<MyDBContext>();
        }
    }
}
