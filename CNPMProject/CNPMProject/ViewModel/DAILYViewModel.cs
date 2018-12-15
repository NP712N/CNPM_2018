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
        public MyICommand AddCommand { get; set; }
        public bool CanAddT { get; set; }
        public List<DAILY> DAILYS { get; set; }
        public DailyViewModel()
        {
            LoadDaiLy();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            AddCommand = new MyICommand(OnAdd, CanAdd);   
        }

        private bool CanAdd()
        {
            return CanAddT!=true;
        }

        private void OnAdd()
        {
            ThemDL themDL = new ThemDL();
            themDL.ShowDialog();
        }

        private DAILY _SelectedDAILYS;
        public DAILY SelectedDAILYS { get { return _SelectedDAILYS; }
            set {
                if (_SelectedDAILYS!= value)
                {
                    _SelectedDAILYS = value;
                    DeleteCommand.RaiseCanExecuteChanged();
                }
                
            }
        }

        private bool CanDelete()
        {
            return _SelectedDAILYS != null;
        }

        private void OnDelete()
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                db.DAILies.Remove(
                    db.DAILies.Find(
                 (from m in db.DAILies
                 where m.MaDaiLy == SelectedDAILYS.MaDaiLy
                 select m)
                 ));
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
