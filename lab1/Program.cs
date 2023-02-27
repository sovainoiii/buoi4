using lab1;

internal class Program
{
    //Bai lam cua Pham Duc Minh
    static void Main(string[] args)
    {
        var DSSV = new List<Student>();
        int n;
        string y;
        do
        {
            Console.WriteLine("1. Nhap 1 sinh vien");
            Console.WriteLine("2. Nhap danh sach sinh vien");
            Console.WriteLine("3. Xuat danh sach:");
            Console.Write("Nhap lua chon cua ban: ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Nhap1SV(DSSV);
                    break;
                case 2:
                    NhapDS(DSSV);
                    break;
                case 3:
                    XuatDS(DSSV);
                    break;
            }
            Console.Write("Ban co muon tiep tuc khong? (y/n): ");
            y = Console.ReadLine();
        } while (y is "Y" or "y");
    }
    //Xuat DS Sinh vien
    static void XuatDS(List<Student> DSSV)
    {
        Console.WriteLine("\n ====XUAT DS SINH VIEN====");
        foreach (Student sv in DSSV)
            sv.Show();
    }
    static void NhapDS(List<Student> DSSV)
    {
        Console.WriteLine("\n ====NHAP DS SINH VIEN====");
        Console.Write("Nhap so luong SV: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) //Lap n lan nhap thong tin sv
        {
            Student st = new Student();
            Console.Write($"Nhap MaSV {i + 1}: ");
            st.setSID(int.Parse(Console.ReadLine()));
            Console.Write("Ho ten SV: " );
            st.setTenSV(Console.ReadLine());
            Console.Write("Nhap khoa: ");
            st.setKhoa(Console.ReadLine());
            Console.Write("Nhap Diem TB: ");
            st.setDiemTB(float.Parse(Console.ReadLine()));
            DSSV.Add(st);
        }
    }
    static void Nhap1SV(List<Student> DSSV)
    {
        Console.WriteLine("\n ====NHAP DS SINH VIEN====");
        Console.Write($"Nhap MaSV: ");
        int ID = int.Parse(Console.ReadLine());
        Console.Write("Ho ten SV: ");
        string tenSV = Console.ReadLine();
        Console.Write("Nhap khoa: ");
        string khoa = Console.ReadLine();
        Console.Write("Nhap Diem TB: ");
        float diemTB = float.Parse(Console.ReadLine());
        Student st = new Student(ID, tenSV, khoa, diemTB);
        DSSV.Add(st);
    }
}