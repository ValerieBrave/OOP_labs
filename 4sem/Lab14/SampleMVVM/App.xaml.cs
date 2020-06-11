using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using SampleMVVM.Models;
using SampleMVVM.ViewModels;
using SampleMVVM.Views;
using SampleMVVM.Models.DB;

namespace SampleMVVM
{
  
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            Model model = new Model();

            List<Consultation> consultations = model.Consultation.ToList();

            MainView view = new MainView(); // создали View
            MainViewModel viewModel = new ViewModels.MainViewModel(); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }
    }
}
