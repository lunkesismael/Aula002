using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp001.Startup))]
namespace WebApp001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

      /*  public void ConfigureServices(IServiceCollection services)
        {
          

            services.AddDbContext<AgroAnaliseAppContext>(options =>
                      options.UseSqlServer(Configuration.GetConnectionString("AgroAnaliseAppContext"),
                      builder => builder.MigrationsAssembly("AgroAnaliseApp")));


        }*/

    }
}
