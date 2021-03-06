﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Ireckonu
{
    public class Startup
    {
        #region Config
        public void ConfigureServices(IServiceCollection services)
        {
            // Angular's default header name for sending the XSRF token.
            services.AddAntiforgery(options => options.HeaderName = "X-XSRF-TOKEN");
            services.AddMvc();
        }
        #endregion

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Debug);
            loggerFactory.AddDebug();
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
