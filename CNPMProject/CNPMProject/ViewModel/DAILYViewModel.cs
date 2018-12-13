using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace CNPMProject.ViewModel
{
    public class DailyViewModel
    {
        public MyICommand DeleteCommand { get; set; }
        public List<DAILY> DAILYS { get; set; }
        public DailyViewModel()
        {
            LoadDaiLy();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }

        private DAILY _SelectedDAILYS;
        public DAILY SelectedDAILYS { get { return _SelectedDAILYS; }
            set {
                _SelectedDAILYS = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        private bool CanDelete()
        {
            return SelectedDAILYS != null;
        }

        private void OnDelete()
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                db.Database.SqlQuery<DAILY>("DeleteDaiLyByID", SelectedDAILYS.MaDaiLy);
            }
        }

        
        public void LoadDaiLy()
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                DAILYS = db.DAILies.ToList();
            }
        }

    }
}
