namespace OpenDSM.docs;


using System.Net;
// LFInteractive LLC. (c) 2021-2022 - All Rights Reserved
using Microsoft.AspNetCore.HttpOverrides;

public class Program
{

    #region Private Fields

    private static int port = 8082;

    #endregion Private Fields

    #region Private Methods

    private static void Main()
    {
        Host.CreateDefaultBuilder().ConfigureWebHostDefaults(builder =>
        {
            builder.UseContentRoot(Directory.GetCurrentDirectory());
            builder.UseKestrel(options =>
                {
                    options.ListenAnyIP(port);
                });
            builder.UseStartup<Startup>();
        }).Build().Run();
    }

    #endregion Private Methods

}

internal class Startup
{

    #region Public Methods

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpLogging();
        }
        else
        {
            app.UseStatusCodePagesWithReExecute("/Error/{0}");

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            app.UseHttpsRedirection();
        }
        app.UseCors(options => options.WithOrigins("*.opendsm.*"));
        app.UseMvc();
        app.UseRouting();
        app.UseStaticFiles();
        app.UseDefaultFiles();
    }

    public void ConfigureServices(IServiceCollection service)
    {
        service.Configure<ForwardedHeadersOptions>(options =>
        {
            options.KnownProxies.Add(IPAddress.Parse("10.0.0.100"));
        });
        service.AddMvc(action =>
        {
            action.EnableEndpointRouting = false;
        });
    }

    #endregion Public Methods

}