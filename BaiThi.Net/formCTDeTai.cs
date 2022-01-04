using BaiThi.Net.BLL;
using BaiThi.Net.VireModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThi.Net
{
    public partial class formCTDeTai : Form
    {
        DeTaiVM detaivm;
        public formCTDeTai(DeTaiVM detaivm = null)
        {
            InitializeComponent();
            this.detaivm = detaivm;

            cmbgiaovien.DataSource = GiaoVienBLL.GetList();
            cmbgiaovien.DisplayMember = "TenGV";
            cmbgiaovien.ValueMember = "MaGV";

            cmbkhoa.DataSource = KhoaBLL.GetList();
            cmbkhoa.DisplayMember = "TenKhoa";
            cmbkhoa.ValueMember = "MaKhoa";

            if(detaivm == null)
            {
                this.Text = "Thêm đề tài";
                lbtitle.Text = "Thêm đề tài";
            }
            else
            {
                this.Text = "Cập nhật đề tài";
                lbtitle.Text = "Cập nhật đề tài";
                txtmadetai.Text = detaivm.MaDeTai;
                txttendetai.Text = detaivm.TenDeTai;
                cmbgiaovien.SelectedValue = detaivm.MaGV;
                cmbkhoa.SelectedValue = detaivm.MaKhoa;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var madetai = txtmadetai.Text;
            if(String.IsNullOrEmpty(madetai))
            {
                errorProvider1.SetError(txtmadetai, "Mã đề tài không được để trống");return;
            }

            var tendetai = txttendetai.Text;
            if (String.IsNullOrEmpty(tendetai))
            {
                errorProvider1.SetError(txttendetai, "Tên đề tài không được để trống"); return;
            }

            var giaovien = cmbgiaovien.SelectedItem as GiaoVien;
            var khoa = cmbkhoa.SelectedItem as Khoa;
            var kq = KetQua.ThanhCong;
            
            if(detaivm == null)
            {
                kq = DeTaiBLL.insertdetai(new DeTaiVM
                {
                    MaDeTai = madetai,
                    TenDeTai = tendetai,
                    MaGV = giaovien.MaGV,
                    MaKhoa = khoa.MaKhoa
                });
                if (kq == KetQua.ThanhCong)
                    DialogResult = DialogResult.OK;
                if (kq == KetQua.Trungmadt)
                    MessageBox.Show("Mã đề tài đã tồn tại");
            }
            else
            {
                detaivm.MaDeTai = madetai;
                detaivm.TenDeTai = tendetai;
                detaivm.MaGV = giaovien.MaGV;
                detaivm.MaKhoa = khoa.MaKhoa;
                detaivm.NgayTao = detaivm.NgayTao;
                kq = DeTaiBLL.updatedetai(detaivm);
                if (kq == KetQua.ThanhCong)
                    DialogResult = DialogResult.OK;
                if (kq == KetQua.Trungmadt)
                    MessageBox.Show("Mã đề tài đã tồn tại");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            new FormQLDeTai();
            this.Close();
        }
    }
}
