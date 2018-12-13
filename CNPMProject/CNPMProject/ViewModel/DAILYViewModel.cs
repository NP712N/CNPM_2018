using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace CNPMProject.ViewModel
{
    public class DAILYViewModel
    {
        public MyICommand DeleteCommand { get; set; }
        public List<DAILY> DAILYS { get; set; }
        public DAILYViewModel()
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
            DAILYS.Remove(SelectedDAILYS);
            using (var db = new QUANLYCACDAILYEntities())
            {;
                db.Entry(db.DAILies.Where(x => x.MaDaiLy == SelectedDAILYS.MaDaiLy)).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
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
