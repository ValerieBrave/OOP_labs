using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleMVVM.Models;
using SampleMVVM.Commands;
using System.Windows.Input;

using SampleMVVM.Models.DB;
using System.Data.Entity;

namespace SampleMVVM.ViewModels
{
    class ConsultationsViewModel : ViewModelBase
    {
        public Model model;
        public Consultation consultation;

        public ConsultationsViewModel(Consultation c, Model m)
        {
            this.consultation = c;
            this.model = m;
        }

        public string FIO
        {
            get { return consultation.FIO; }
            set
            {
                consultation.FIO = value;
            }
        }

        public string Subject
        {
            get { return consultation.Subject; }
            set
            {
                consultation.Subject = value;
            }
        }

        public DateTime Date
        {
            get { return (DateTime)consultation.Date; }
            set
            {
                consultation.Date = value;
            }
        }
        public string DateShort
        {
            get { return ((DateTime)consultation.Date).ToShortDateString(); }
        }

        public DateTime StartTime
        {
            get { return (DateTime)consultation.Startime; }
            set
            {
                consultation.Startime = value;
            }
        }

        public DateTime EndTime
        {
            get { return (DateTime)consultation.Endtime; }
            set
            {
                consultation.Endtime = value;
            }
        }

        public byte IsRecorded
        {
            get { return (byte)consultation.IsRecorded; }
            set
            {
                consultation.IsRecorded = value;
                OnPropertyChanged("IsRecordedToSting");
            }
        }
        public string IsRecordedToSting
        {
            get
            { 
                if(this.IsRecorded == 0)
                {
                    return "---";
                }
                else
                {
                    return "Вы записаны";
                }
            }
        }

        

        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem, CanGetItem);
                }
                return getItemCommand;
            }
        }

        private void GetItem()
        {
            IsRecorded = 1;
            model.Entry(this.consultation).State = EntityState.Modified;
            //model.Consultation.Add(this.consultation);
            model.SaveChanges();
        }

        private bool CanGetItem()
        {
            return IsRecorded == 0;
        }


        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);
                    model.Entry(this.consultation).State = EntityState.Modified;
                    model.SaveChanges();
                }
                return giveItemCommand;
            }
        }

        private void GiveItem()
        {
            IsRecorded = 0;
                    model.Entry(this.consultation).State = EntityState.Modified;
            //model.Consultation.Remove(this.consultation);
                    model.SaveChanges();
        }

        private bool CanGiveItem()
        {
            return IsRecorded == 1;
        }

    }
}
