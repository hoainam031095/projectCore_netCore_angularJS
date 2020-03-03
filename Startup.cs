using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CongThongTin.App_Data;
using Microsoft.EntityFrameworkCore;
using CongThongTin.Models;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace CongThongTin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            CongThongTin.Areas.Admin.Models.Code.SyncTbRoutes();

            //Kết nối
            var connectString = Configuration.GetConnectionString("congthongtinConect");
            services.AddDbContext<congthongtinContext>(item => item.UseSqlServer(connectString));

            // Câu lệnh này để sử dụng app.UseMvc thay vì app.UseEndpoints
            services.AddMvc(options => options.EnableEndpointRouting = false);

            //Sử dụng Session
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
            });

            services.AddSignalR().AddJsonProtocol();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();


            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "Admin",
            //        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});
            //được thay bằng
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "MyArea",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Use(async (context, next) =>
            {
                context.Response.OnStarting(() =>
                {
                    int responseStatusCode = context.Response.StatusCode;
                    if (responseStatusCode == (int)HttpStatusCode.Created)
                    {
                        IHeaderDictionary headers = context.Response.Headers;

                        if (!headers.ContainsKey("Arr-Disable-Session-Affinity"))
                        {
                            headers.Add("Arr-Disable-Session-Affinity", "True"); // Disables the Azure ARRAffinity cookie
                        }

                        if (headers.ContainsKey("Server"))
                        {
                            headers.Remove("Server"); // For security reasons
                        }

                        if (headers.ContainsKey("x-powered-by") || headers.ContainsKey("X-Powered-By"))
                        {
                            headers.Remove("x-powered-by");
                            headers.Remove("X-Powered-By");
                        }

                        if (!headers.ContainsKey("X-Frame-Options"))
                        {
                            headers.Add("X-Frame-Options", "DENY");
                        }
                    }
                    return Task.FromResult(0);
                });

                await next();
            });
        }
    }
}
