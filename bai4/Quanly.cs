using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Quanly : Vienkhoahoc
    {
        public int Ngaycong { get; set; }
        public double Bacluong { get; set; }
        public string Chucvu { get; set; }
        public Quanly(): base() { }
        public Quanly(string Hoten, int Namsinh, string Bangcap, string chucvu, int ngaycong, double bacluong) : base(Hoten, Namsinh, Bangcap)
        {
            Ngaycong = ngaycong;
            Bacluong = bacluong;
            Chucvu = chucvu;
        }
        public void Xuat()
        { 
            base.Xuat();
            Console.WriteLine($"Chuc vu: {Chucvu}");
            Console.WriteLine($"So ngay cong: {Ngaycong}");
            Console.WriteLine($"Bac luong: {Bacluong}");
        }
        public override double Luong()
        {
            return (Ngaycong * Bacluong);
        }
    }
}
