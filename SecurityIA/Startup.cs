using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SecurityIA.Data;
using SecurityIA.Data.Entities;
using SecurityIA.Helpers;

namespace SecurityIA
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

            services.AddIdentity<User, IdentityRole>(x =>
            {
                //x.Tokens.AuthenticatorTokenProvider = TokenOptions.DefaultAuthenticatorProvider;
                //x.SignIn.RequireConfirmedEmail = true;
                x.User.RequireUniqueEmail = true;
                x.Password.RequireDigit = true;
                x.Password.RequiredUniqueChars = 0;
                x.Password.RequireLowercase = true;
                x.Password.RequireNonAlphanumeric = true;
                x.Password.RequireUppercase = true;
            });
            //   .AddDefaultTokenProviders()
            //   .AddEntityFrameworkStores<DataContext>();
            //services.AddAuthentication()
            //    .AddCookie()
            //    .AddJwtBearer(cfg =>
            //    {
            //        cfg.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidIssuer = Configuration["Tokens:Issuer"],
            //            ValidAudience = Configuration["Tokens:Audience"],
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Key"]))
            //        };
            //    });
            services.AddDbContext<DataContext>(x =>
            {
                x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IUserHelper, UserHelper>();
            services.AddScoped<ICombosHelper, CombosHelper>();
            
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
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
