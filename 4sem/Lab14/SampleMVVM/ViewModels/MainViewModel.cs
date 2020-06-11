using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

using SampleMVVM.Commands;
using System.Collections.ObjectModel;
using SampleMVVM.Models;
using SampleMVVM.Models.DB;
using System.Windows.Data;

namespace SampleMVVM.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<AviaViewModel> AviaList { get; set; }


        public ObservableCollection<ConsultationsViewModel> ConsultationsList { get; set; }

        public MainViewModel(List<Avia> reis)
        {
            AviaList = new ObservableCollection<AviaViewModel>(reis.Select(b => new AviaViewModel(b)));
        }

        public MainViewModel()
        {
            Model model = new Model();
            ConsultationsList = new ObservableCollection<ConsultationsViewModel>();
            foreach (var c in model.Consultation.ToList())
            {
                ConsultationsList.Add(new ConsultationsViewModel(c, model));
            }
            //ConsultationsList = new ObservableCollection<ConsultationsViewModel>(model.Consultations.Select(b => new ConsultationsViewModel(b, model)));
        }

    }
}
