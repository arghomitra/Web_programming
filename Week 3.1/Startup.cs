using Week_3._1.Data;

namespace Week_3._1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped(typeof(IAnonymousEurosonDataContext), typeof(AnonymousEurosongDataList));
            //or 
            services.AddTransient(typeof(IAnonymousEurosonDataContext), typeof(AnonymousEurosongDataList));
            //or 
            services.AddSingleton(typeof(IAnonymousEurosonDataContext), typeof(AnonymousEurosongDataList));

        }
    }
}
