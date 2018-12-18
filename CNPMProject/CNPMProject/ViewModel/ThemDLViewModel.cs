using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPMProject.ViewModel
{
    public class ThemDLViewModel:INotifyPropertyChanged
    {
        MyICommand AddCommand { get; set; }
        public List<DINHMUC> DINHMUCS { get; set; }
        public List<DAILY> DAILYS { get; set; }
        public DAILY _DAILY { get; set; }


        public ThemDLViewModel()
        {
            DINHMUCS = new List<DINHMUC>();
            using (var db = new QUANLYCACDAILYEntities())
            {
                DINHMUCS = db.DINHMUCs.ToList();
            }
            AddCommand = new MyICommand(OnAdd, CanAdd);

        }

        private void OnAdd()
        {
            
        }

        private bool CanAdd()
        {
            return _DAILY != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
