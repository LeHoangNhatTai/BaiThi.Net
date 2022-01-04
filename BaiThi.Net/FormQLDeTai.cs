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
    public partial class FormQLDeTai : Form
    {
        public FormQLDeTai()
        {
            InitializeComponent();
            loadtable();
        }

        void loadtable(List<DeTaiVM> dtvm = null)
        {
            if(dtvm == null)
            {
                deTaiBindingSource.DataSource = DeTaiBLL.GetListVM();
                dgvqldetai.DataSource = deTaiBindingSource;
            }
            else
            {
                deTaiBindingSource.DataSource = dtvm;
                dgvqldetai.DataSource = deTaiBindingSource;
            }

            cmbgv.DataSource = GiaoVienBLL.GetList();
            cmbgv.DisplayMember = "TenGV";
            cmbgv.ValueMember = "MaGV";
            cmbgv.Text = "Chọn giáo viên";

            cmbkhoa.DataSource = KhoaBLL.GetList();
            cmbkhoa.DisplayMember = "TenKhoa";
            cmbkhoa.ValueMember = "MaKhoa";
            cmbkhoa.Text = "Chọn khoa";
        }

        public DeTaiVM selectdetai
        {
            get
            {
                return deTaiBindingSource.Current as DeTaiVM;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            formCTDeTai ctdt = new formCTDeTai();
            if (ctdt.ShowDialog() == DialogResult.OK)
                loadtable();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if(selectdetai != null)
            {
                formCTDeTai ctdt = new formCTDeTai(selectdetai);
                if (ctdt.ShowDialog() == DialogResult.OK)
                    loadtable();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(selectdetai != null)
            {
                if (MessageBox.Show(
                    "Bạn có chắc muốn xóa ?"
                    , "Chú ý"
                    , MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DeTaiBLL.deletedetai(selectdetai.ID);
                    MessageBox.Show("Xóa sinh viên thành công");
                    loadtable();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tim = txtsearch.Text;
            if (String.IsNullOrEmpty(tim))
            {
                tim = "";
            }
            loadtable(DeTaiBLL.SearchListVM(tim));
        }

        private void cmbgv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var gv = cmbgv.SelectedItem as GiaoVien;
            loadtable(DeTaiBLL.SearchbyGV(gv.TenGV));
            cmbgv.Text = gv.TenGV;
        }

        private void cmbkhoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var k = cmbkhoa.SelectedItem as Khoa;
            loadtable(DeTaiBLL.SearchbyGV(k.TenKhoa));
            cmbkhoa.Text = k.TenKhoa;
        }
    }
}
