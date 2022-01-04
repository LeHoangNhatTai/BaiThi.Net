namespace BaiThi.Net
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeTai")]
    public partial class DeTai
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string MaDeTai { get; set; }

        [StringLength(255)]
        public string TenDeTai { get; set; }

        [StringLength(50)]
        public string MaGV { get; set; }

        [StringLength(50)]
        public string MaKhoa { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
