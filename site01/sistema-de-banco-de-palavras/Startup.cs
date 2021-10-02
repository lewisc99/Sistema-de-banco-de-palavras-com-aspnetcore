using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Site01.Database;

namespace sistemadebancodepalavras
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<DatabaseContext>(options =>
            {
                //providers - bibliotecas ajuda na conexão com banco de dados.
                //options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=site01;");
                options.UseSqlServer("Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=Site01;Data Source=DESKTOP-PCE1A1P\\SQLEXPRESS;");
                //  options.UseSqlServer("Server=DESKTOP-PCE1A1P\\SQLEXPRESS;Database=site01;integrated Security=True;");
            });

            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession(); //linha que está usando a sessão.


            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            // app.Run(async (context) =>
            // {
            //  await context.Response.WriteAsync("Hello World!");
            // });
        }
    }
}
