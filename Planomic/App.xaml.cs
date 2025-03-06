using Microsoft.Extensions.DependencyInjection;

namespace Planomic
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            MainPage = new AppShell();
            ServiceProvider = serviceProvider;
        }
    }
}
