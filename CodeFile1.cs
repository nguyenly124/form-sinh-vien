class sinhvien
{
    public string hoten { get; set; }
    public string masv { get; set; }
    public string lop { get; set; }
    public double diemtb { get; set; }
    public void nhapthongtin()
    {
        Console.Write("Nhap ho ten:");
        hoten = Console.ReadLine();
        Console.Write("Nhap masv:");
        masv = Console.ReadLine();
        Console.Write("Nhap lop:");
        masv = Console.ReadLine();
        Console.Write("Nhap diem trung binh:");
        diemtb = double.Parse(Console.ReadLine());

    }
    public void hienthithongtin()
    {
        Console.WriteLine("ho ten: " + hoten);
        Console.WriteLine("ma sinh vien " + masv);
        Console.WriteLine("lop " + lop);
        Console.WriteLine("diem trung binh:" + diemtb);
    }

}
class danhsachsinhvien
{
    List<sinhvien> danhsach = new List<sinhvien>();
    public void them_sv()
    {
        sinhvien sv = new sinhvien();
        sv.nhapthongtin();
        danhsach.Add(sv);
    }
    public void hien_thids()
    {

        foreach (sinhvien sv in danhsach)
        {
            sv.hienthithongtin();
        }
    }
    public void timsv(string ma)
    {
        int d = 0;
        foreach (sinhvien sv in danhsach)
        {
            if (sv.masv == ma)
            {
                d = 1;
                sv.hienthithongtin();
            }
        }
        if (d == 0) Console.WriteLine("Khong co sinh vien can tim ");
    }
    public void tinhdtb_max()
    {
        sinhvien svmax = danhsach[1];
        foreach (sinhvien sv in danhsach)
        {
            if (svmax.diemtb < sv.diemtb) svmax = sv;
        }
        svmax.hienthithongtin();
    }
}
