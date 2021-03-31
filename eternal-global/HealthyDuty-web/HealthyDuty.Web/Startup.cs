using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HealthyDuty.Web.Business;
using HealthyDuty.Web.Business.Common;
using HealthyDuty.Web.Business.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace HealthyDuty.Web
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
            // business service ve interface DI container tanimlari
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IBloodGroupService, BloodGroupService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<IHospitalService, HospitalService>();
            services.AddTransient<INeedForBloodService, NeedForBloodService>();
            services.AddTransient<IPersonnelService, PersonnelService>();
            services.AddTransient<IProfileDetailService, ProfileDetailService>();
            services.AddTransient<IProfilePersonnelService, ProfilePersonnelService>();
            services.AddTransient<IProfileService, ProfileService>();
            services.AddTransient<ISexService, SexService>();
            services.AddTransient<IUserService, UserService>();

            services.AddSingleton<IConfiguration>(Configuration); //add Configuration to our services collection

            // session kullan�m� tan�m�
            // Adds a default in-memory implementation of IDistributedCache.
            services.AddDistributedMemoryCache(); //This way ASP.NET Core will use a Memory Cache to store session variables
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
            });


            //http isteginde bulunmak i�in kullan�l�r.
            //https://docs.microsoft.com/tr-tr/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.1
            services.AddHttpClient();


            //newtonsoft ekleme-ajax methodlar�nda verileri okuyam�yorduk
            //https://stackoverflow.com/questions/60535734/when-posting-to-an-asp-net-core-3-1-web-app-frombodymyclass-data-is-often-n
            services.AddRazorPages().AddNewtonsoftJson();

            //Session i�in IHttpContextAccessor aray�z�n�n kullan�ma a��lmas�
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();
            /*
             From ASP.NET Core 2.1 onwards the AddHttpContextAccessor helper extension method was added to correctly register the IHttpContextAccessor with the correct lifetime (singleton). So, in ASP.NET Core 2.1 and above, the code should be:
             services.AddHttpContextAccessor();
             */
            //https://edi.wang/post/2017/10/16/get-client-ip-aspnet-20

            // https://stackoverflow.com/questions/51394593/how-to-access-server-variables-in-asp-net-core-2-x
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders =
                    ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            });

            // localization kullan�m�
            // http://www.sinanbozkus.com/asp-net-core-ile-coklu-dil-destegi-olan-uygulamalar-gelistirmek/
            // https://docs.microsoft.com/tr-tr/aspnet/core/fundamentals/localization?view=aspnetcore-2.2
            //localization - Kay�t i�lemimizi ger�ekle�tiriyoruz, AddMvc() den �nce ekledi�inizden emin olunuz.
            services.AddLocalization(options =>
            {
                // Resource (kaynak) dosyalar�m�z� ana dizin alt�nda "Resources" klasor� i�erisinde tutaca��m�z� belirtiyoruz.
                options.ResourcesPath = "LangResources";
            });


            //resim yuklemek i�in
            services.AddSingleton<IFileProvider>(new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
            services.AddMvc();


            //https://stackoverflow.com/questions/58885384/the-json-value-could-not-be-converted-to-system-nullablesystem-int32
            services.AddControllers().AddNewtonsoftJson();


            //services.AddControllersWithViews();
            //services.AddControllersWithViews()
            //    .AddSessionStateTempDataProvider();
            var mvc = services.AddControllersWithViews()
                .AddSessionStateTempDataProvider();


            // runtime compilation of views:
            //  https://gunnarpeipman.com/aspnet-core-compile-modified-views/
            //  https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-compilation?view=aspnetcore-3.1

#if (DEBUG)
            mvc.AddRazorRuntimeCompilation();
#endif

            services.AddControllersWithViews();
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
            // session kullan�m�
            app.UseSession(); //make sure add this line before UseMvc()
            // SessionHelper'a HttpContextAccessor nesnesi ataniyor
            SessionHelper.Configure(app.ApplicationServices.GetRequiredService<IHttpContextAccessor>());


            //config helper'� configure etmek i�in

            ConfigHelper.Configure(Configuration);
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Personnel}/{action=Login}/{id?}");
            });
        }
    }
}
