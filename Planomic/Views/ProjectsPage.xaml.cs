using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using Planomic.Models;
using Planomic.Services;

namespace Planomic.Views
{
    public partial class ProjectsPage : ContentPage
    {
        private readonly DatabaseService _databaseService;
        public ObservableCollection<Project> Projects { get; set; } = new ObservableCollection<Project>();

        public ProjectsPage(DatabaseService databaseService)
        {
            InitializeComponent();
            _databaseService = databaseService;
            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var projects = await _databaseService.GetProjectsAsync();
            Projects.Clear();
            foreach (var project in projects)
            {
                Projects.Add(project);
            }
        }

        private async void OnAddProjectClicked(object sender, EventArgs e)
        {
            var newProject = new Project
            {
                Title = "Новый проект",
                Description = "Описание проекта",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(10)
            };

            await _databaseService.AddProjectAsync(newProject);
            Projects.Add(newProject);
        }
    }
}