using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi.Net.VireModel
{
    public class DeTaiVM
    {
        public long ID {  get; set; }
        public string MaDeTai { get; set; }
        public string TenDeTai { get; set; }
        public string MaGV { get; set; }
        public string TenGiaoVien { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

    }
}
