using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace form_sinhvien
{

    public partial class Form1 : Form
    {
        List<sinhvien> danhsachsv = new List<sinhvien>();

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
            // Lấy thông tin từ TextBox và thêm vào danh sách
            sinhvien sv = new sinhvien
            {
                masv = masv,
                hoten = tenSV,
                lop = lop,

            };
            danhsachsv.Add(sv);

            // Cập nhật lại DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhsachsv;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Khi người dùng click vào một ô trong DataGridView
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                textmasv.Text = row.Cells[0].Value.ToString();
                texttensv.Text = row.Cells[1].Value.ToString();
                textlop.Text = row.Cells[2].Value.ToString();                                               // ... và các TextBox khác
            }
        }
        private void buttonsua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            row.Cells[0].Value = textmasv.Text;
            row.Cells[1].Value = texttensv.Text;
            row.Cells[2].Value = textlop.Text;
        }

        

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    danhsachsv.RemoveAt(index);

                    // Cập nhật lại DataGridView
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = danhsachsv;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!");
            }
        }
    }
}
public class sinhvien
{
   
    public string masv { get; set; }
    public string hoten { get; set; }
    public string lop { get; set; }
    
}
