﻿using AxonAPI.Application.Exceptions;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;

namespace AxonAPI.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddTransient<ExceptionMiddleware>();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");
        }
    }
}
