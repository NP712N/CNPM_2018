//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPMProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class PHIEUTHU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTHU()
        {
            this.NODAILies = new HashSet<NODAILY>();
        }

        private string maPhieuThu;
        public string MaPhieuThu
        {
            get { return maPhieuThu; }
            set
            {
                if (maPhieuThu != value)
                {
                    maPhieuThu = value;
                }
            }
        }

        private string maHoaDon;
        public string MaHoaDon
        {
            get { return maHoaDon; }
            set
            {
                if (maHoaDon != value)
                {
                    maHoaDon = value;
                }
            }
        }

        private Nullable<DateTime> ngayLapPhieu;
        public Nullable<System.DateTime> NgayLapPhieu
        {
            get { return ngayLapPhieu; }
            set
            {
                if (ngayLapPhieu != value)
                {
                    ngayLapPhieu = value;
                }
            } }

        private Nullable<double> soTienDaThu;
        public Nullable<double> SoTienDaThu
        {
            get { return soTienDaThu; }
            set
            {
                if (soTienDaThu != value)
                {
                    soTienDaThu = value;
                }
            } }

        public virtual HOADON HOADON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NODAILY> NODAILies { get; set; }
    }
}
