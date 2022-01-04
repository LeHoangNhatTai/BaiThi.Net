using BaiThi.Net.VireModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi.Net.BLL
{
    internal class DeTaiBLL
    {
        public static List<DeTaiVM> GetListVM()
        {
            QLDeTaiModel model = new QLDeTaiModel();
            var ds = model.DeTais.Select(e => new DeTaiVM
            {
                ID= e.ID,
                MaDeTai = e.MaDeTai,
                TenDeTai = e.TenDeTai,
                MaGV = e.MaGV,
                TenGiaoVien = e.GiaoVien.TenGV,
                MaKhoa = e.MaKhoa,
                TenKhoa = e.Khoa.TenKhoa,
                NgayTao = e.NgayTao,
                NgayCapNhat = e.NgayCapNhat,
            }).ToList();
            return ds;
        }

        public static List<DeTaiVM> SearchListVM(string key)
        {
            QLDeTaiModel model = new QLDeTaiModel();
            var ds = model.DeTais.Select(e => new DeTaiVM
            {
                ID = e.ID,
                MaDeTai = e.MaDeTai,
                TenDeTai = e.TenDeTai,
                MaGV = e.MaGV,
                TenGiaoVien = e.GiaoVien.TenGV,
                MaKhoa = e.MaKhoa,
                TenKhoa = e.Khoa.TenKhoa,
                NgayTao = e.NgayTao,
                NgayCapNhat = e.NgayCapNhat,
            }).Where(e=>e.MaDeTai.Contains(key) || e.TenDeTai.Contains(key)).ToList();
            return ds;
        }

        public static List<DeTaiVM> SearchbyGV(string key)
        {
            QLDeTaiModel model = new QLDeTaiModel();
            var ds = model.DeTais.Select(e => new DeTaiVM
            {
                ID = e.ID,
                MaDeTai = e.MaDeTai,
                TenDeTai = e.TenDeTai,
                MaGV = e.MaGV,
                TenGiaoVien = e.GiaoVien.TenGV,
                MaKhoa = e.MaKhoa,
                TenKhoa = e.Khoa.TenKhoa,
                NgayTao = e.NgayTao,
                NgayCapNhat = e.NgayCapNhat,
            }).Where(e => e.TenGiaoVien.Contains(key) || e.TenKhoa.Contains(key)).ToList();
            return ds;
        }

        public static KetQua insertdetai(DeTaiVM detaivm)
        {
            QLDeTaiModel model = new QLDeTaiModel();
            var dt = model.DeTais.Where(e => e.ID == detaivm.ID).FirstOrDefault();
            if (dt != null)
                return KetQua.Trungmadt;
            else
            {
                dt = new DeTai
                {
                    MaDeTai = detaivm.MaDeTai,
                    TenDeTai = detaivm.TenDeTai,
                    MaGV = detaivm.MaGV,
                    MaKhoa = detaivm.MaKhoa,
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now
                };
                model.DeTais.Add(dt);
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }

        public static KetQua updatedetai(DeTaiVM detaivm)
        {
            QLDeTaiModel model = new QLDeTaiModel();
            var dt = model.DeTais.Where(e => e.ID == detaivm.ID && e.MaDeTai == detaivm.MaDeTai).FirstOrDefault();
            if (dt != null)
                return KetQua.Trungmadt;
            else
            {
                dt = model.DeTais.Where(e => e.ID == detaivm.ID).FirstOrDefault();
                dt.MaDeTai = detaivm.MaDeTai;
                dt.TenDeTai = detaivm.TenDeTai;
                dt.MaGV = detaivm.MaGV;
                dt.MaKhoa = detaivm.MaKhoa;
                dt.NgayTao = detaivm.NgayTao;
                dt.NgayCapNhat = DateTime.Now;
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }

        public static void deletedetai(long iddt)
        {
            QLDeTaiModel model = new QLDeTaiModel();
            var dt = model.DeTais.Where(e => e.ID == iddt).FirstOrDefault();
            if (dt != null)
                model.DeTais.Remove(dt);
            else
                throw new Exception("Đề tài này không tồn tại");
            model.SaveChanges();
        }
    }
    public enum KetQua
    {
        Trungmadt,
        ThanhCong
    }
}
