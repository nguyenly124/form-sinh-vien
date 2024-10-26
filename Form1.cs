using System.Security.Cryptography.Xml;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace form_tra_cuu_diem
{
    
    public partial class Form1 : Form
    {

        List<sinhvien> sv = new List<sinhvien>
        {
        new sinhvien { masv = "SV001", hoten = "Nguyen Van A",lop="cnpm6" ,diem = 8 },
        new sinhvien {  masv = "SV002", hoten = "Nguyen Van B",lop="cnpm8" ,diem = 4 },
        };

        public Form1()
        {
            InitializeComponent();
        }
       
        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            string masv = txtmasv.Text;

            // Tìm sinh viên có mã trùng khớp
            sinhvien sinhVienTimThay = sv.FirstOrDefault(sv => sv.masv == masv);

            if (sinhVienTimThay != null)
            {
                lable_hienthi.Text = $"Thông tin sinh viên :  {sinhVienTimThay.hoten}        {sinhVienTimThay.lop}      {sinhVienTimThay.diem}";
            }
            else
            {
                lable_hienthi.Text = "Không tìm thấy sinh viên!";
            }
        }
    }
}
public class sinhvien
{
    public string hoten { get; set; }
    public string masv { get; set; }
    public string lop { get; set; }
    public double diem { get; set; }
}
