using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi.Net.BLL
{
    internal class KhoaBLL
    {
        public static List<Khoa> GetList()
        {
            QLDeTaiModel model = new QLDeTaiModel();
            return model.Khoas.ToList();
        }
    }
}
