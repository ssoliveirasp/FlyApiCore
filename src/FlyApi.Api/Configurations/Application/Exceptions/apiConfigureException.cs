using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyApi.Api.Configurations.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics.CodeAnalysis;

namespace FlyApi.Api.Configuration
{
    public static class apiConfigureException
    {
        public static void addFlyException(this IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                apiConfigureException.addExceptionDev(application, env, provider);
            }
            else
            {
                apiConfigureException.addExceptionProd(application, env, provider);
            }
        }

        private static void addExceptionDev(IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            application.UseDeveloperExceptionPage();
        }

        private static void addExceptionProd(IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
        }
    }
}