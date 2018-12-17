using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPMProject.ViewModel
{
   public class UuDaiViewModel
    {
        public List<UUDAI> UUDAIS { get; set; }
        public UuDaiViewModel()
        {
            LoadUuDai();
        }

        private void LoadUuDai()
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                UUDAIS = db.UUDAIs.ToList();
            }
        }
    }
}
