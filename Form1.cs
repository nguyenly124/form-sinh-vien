using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace form_sinhvien
{
    public partial class Form1 : Form
    {
        List<sinhvien> danhSachSinhVien = new List<sinhvien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            string masv = textmasv.Text;
            string tenSV = texttensv.Text;
            string lop = textlop.Text;
            double diem = double.Parse(textdiem.Text);
            // Lấy thông tin từ TextBox và thêm vào danh sách
            sinhvien sv = new sinhvien
            {
                masv = masv,
                hoten = tenSV,
                lop = lop,
                diemtb = diem,
            };
            danhSachSinhVien.Add(sv);

            // Cập nhật lại DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSinhVien;
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            
            // Lấy chỉ số dòng được chọn
            int rowIndex = dataGridView1.CurrentRow.Index;

            // Lấy thông tin sinh viên từ danh sách
            sinhvien sv = danhSachSinhVien[rowIndex];

            // Hiển thị thông tin lên TextBox
            textmasv.Text = sv.masv;
            texttensv.Text = sv.hoten;
            textlop.Text = sv.lop;
            textdiem.Text = sv.diemtb.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }
  
    }
}
