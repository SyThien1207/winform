using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class main2 : Form
    {
        public main2()
        {
            InitializeComponent();
        }
        private void mn_dx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Dangnhap a = new Dangnhap();
                a.Show();
                this.Hide();
            }
        }

        private void ql_ncc_Click(object sender, EventArgs e)
        {
            quanly.nhacungcap a = new quanly.nhacungcap();
            a.Show();
        }

       

        private void ql_nhanvien_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.ShowDialog();
        }
        
        private void main2_Load(object sender, EventArgs e)
        {

        }
        private void mn_hethong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Dangnhap a = new Dangnhap();
                a.Show();
                this.Hide();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
