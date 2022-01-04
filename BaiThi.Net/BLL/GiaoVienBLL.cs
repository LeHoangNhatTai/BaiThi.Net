using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi.Net.BLL
{
    internal class GiaoVienBLL
    {
        public static List<GiaoVien> GetList()
        {
            QLDeTaiModel model = new QLDeTaiModel();
            return model.GiaoViens.ToList();
        }
    }
}
