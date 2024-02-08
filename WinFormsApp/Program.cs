using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.EFModels;
using WinFormsApp.Presenter;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddDbContext<WinFormsAppContext>();
            services.AddScoped<ISamplePresenter, SamplePresenter>(); 
            var serviceProvider = services.BuildServiceProvider();
            var form = new SampleForm(serviceProvider.GetRequiredService<ISamplePresenter>());
            Application.Run(form);
            //Application.Run(new SampleForm());
        }
    }
}