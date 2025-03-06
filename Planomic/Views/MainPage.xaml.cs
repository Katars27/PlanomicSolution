using Microsoft.Maui.Controls;
using Planomic.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Planomic.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnProjectsClicked(object sender, EventArgs e)
        {
            var databaseService = App.ServiceProvider.GetService<Planomic.Services.DatabaseService>();
            await Navigation.PushAsync(new ProjectsPage(databaseService));
        }
    }
}
