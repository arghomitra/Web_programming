using Microsoft.Extensions.DependencyInjection;
using Week_3._1.Data;

namespace Week_3._1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddScoped<IAnonymousEurosonDataContext, IAnonymousEurosonDataContext>();


        }
    }
}
