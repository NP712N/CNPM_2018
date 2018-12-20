using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;
using System.Windows.Input;

namespace CNPMProject.ViewModel
{
    public class DailyViewModel : INotifyPropertyChanged
    {
        public MyICommand AddCommand { get; set; }
        public MyICommand EditCommand { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand SearchDAILYSCommand { get; set; }

        public bool CanAddT { get; set; }
        public bool CanSearchT { get; set; }
        public List<DAILY> DAILYS { get; set; }
        public List<DINHMUC> DINHMUCS { get; set; }
        public DailyViewModel()
        {
            LoadDaiLy();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            SearchDAILYSCommand = new MyICommand(OnSearch, CanSearch);
            AddCommand = new MyICommand(OnAdd, CanAdd);
            
        }
        private void OnAdd()
        {
            try
            {
                Daily dl = new Daily();

                using (var db = new QUANLYCACDAILYEntities())
                {
                    DAILY temp = new DAILY();
                    temp.MaDaiLy = dl.txt_madaily.ToString();
                    temp.MaDinhMuc = dl.cb_madinhmuc.SelectedItem.ToString();
                    temp.MaHopDong = dl.txt_mahopdong.ToString();
                    temp.NgayLap = DateTime.Parse(dl.dp_ngaylap.ToString());
                    temp.CMND = dl.txt_cmnd.ToString();
                    temp.HoTenChuDaiLy = dl.txt_hotenchudaily.ToString();
                    temp.NgaySinh = DateTime.Parse(dl.dp_ngaysinh.ToString());
                    temp.CapDaiLy = dl.txt_cap.ToString();
                    temp.TenDaiLy = dl.txt_tendaily.ToString();
                    temp.NoiDung = dl.txt_noidung.ToString();
                    db.DAILies.Add(temp);
                }
            }
            catch { }
        }

        private bool CanAdd()
        {
            return CanAddT != true;
        }

        private bool CanSearch()
        {
            return CanSearchT != true;
        }

        private void OnSearch()
        {

        }


        private DAILY _SelectedDAILYS;
        public DAILY SelectedDAILYS
        {
            get { return _SelectedDAILYS; }
            set
            {
                if (_SelectedDAILYS != value)
                {
                    _SelectedDAILYS = value;
                    DeleteCommand.RaiseCanExecuteChanged();
                    RaisePropertyChanged("SelectedDAILYS");
                }

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
            
            using (var db = new QUANLYCACDAILYEntities())
            {
                DINHMUCS = db.DINHMUCs.ToList();
            }
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
