using bai4;

List<Khoahoc> khoahoc = new List<Khoahoc>();
List<Nhanvien> nhanvien = new List<Nhanvien>();
List<Quanly> quanly = new List<Quanly>();

Console.WriteLine("----------NHA HOA HOC-------------");
Console.Write("Nhap so nha khoa hoc: ");
int nkh = int.Parse(Console.ReadLine());
for(int i = 0; i < nkh; i++)
{
    Console.WriteLine($"Nhap thong tin nha khoa hoc so {i+1}");
    Khoahoc kh = new Khoahoc();
    Console.Write("Nhap ten: ");
    kh.Hoten = Console.ReadLine();
    Console.Write("Nhap nam sinh: ");
    kh.Namsinh = int.Parse(Console.ReadLine());
    Console.Write("Nhap bang cap: ");
    kh.Bangcap = Console.ReadLine();
    Console.Write("Nhap chuc vu: ");
    kh.Chucvu = Console.ReadLine();
    Console.Write("Nhap bai bao: ");
    kh.Baibao = int.Parse(Console.ReadLine());
    Console.Write("Nhap ngay cong: ");
    kh.Bangcap = Console.ReadLine();
    Console.Write("Nhap bac luong: ");
    kh.Bacluong = float.Parse(Console.ReadLine());
    khoahoc.Add(kh);
}
Console.WriteLine("----------QUAN LY-------------");
Console.Write("Nhap so quan ly: ");
int ql = int.Parse(Console.ReadLine());
for (int i = 0; i < ql; i++)
{
    Console.WriteLine($"Nhap thong tin quan ly so {i + 1}");
    Quanly qly = new Quanly();
    Console.Write("Nhap ten: ");
    qly.Hoten = Console.ReadLine();
    Console.Write("Nhap nam sinh: ");
    qly.Namsinh = int.Parse(Console.ReadLine());
    Console.Write("Nhap bang cap: ");
    qly.Bangcap = Console.ReadLine();
    Console.Write("Nhap chuc vu: ");
    qly.Chucvu = Console.ReadLine();
    Console.Write("Nhap ngay cong: ");
    qly.Bangcap = Console.ReadLine();
    Console.Write("Nhap bac luong: ");
    qly.Bacluong = float.Parse(Console.ReadLine());
    quanly.Add(qly);
}
Console.WriteLine("----------NHAN VIEN PHONG THI NGHIEM-------------");
Console.Write("Nhap so nhan vien phong thi nghiem: ");
int nv = int.Parse(Console.ReadLine());
for (int i = 0; i < nv; i++)
{
    Console.WriteLine($"Nhap thong tin quan ly so {i + 1}");
    Nhanvien nvien = new Nhanvien();
    Console.Write("Nhap ten: ");
    nvien.Hoten = Console.ReadLine();
    Console.Write("Nhap nam sinh: ");
    nvien.Namsinh = int.Parse(Console.ReadLine());
    Console.Write("Nhap bang cap: ");
    nvien.Bangcap = Console.ReadLine();
    Console.Write("Nhap luong thang: ");
    nvien.Luongthang = double.Parse(Console.ReadLine());
    nhanvien.Add(nvien);
}

Console.WriteLine("----------TONG LUONG---------");
double luongNKH = 0; 
double luongQL = 0; 
double luongNV = 0;
for (int i = 0;  i < khoahoc.Count; i++)
{
    luongNKH += khoahoc[i].Luong();
}
foreach (Quanly i in quanly)
{
    luongQL += i.Luong();
}
foreach (Nhanvien i in nhanvien)
{
    luongNV += i.Luong();
}
Console.WriteLine($"Tong luong cua nha khoa hoc: {luongNKH}");
Console.WriteLine($"Tong luong cua quan ly: {luongQL}");
Console.WriteLine($"Tong luong cua nhan vien phong thi nghiem: {luongNV}");