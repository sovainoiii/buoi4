using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Nhanvien : Vienkhoahoc
    {
        public double Luongthang { get; set; }
        public Nhanvien(): base() { }

        public Nhanvien(string Hoten, int Namsinh, string Bangcap, double luongthang) : base(Hoten, Namsinh, Bangcap)
        {
            Luongthang = luongthang;
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Luong trong thang: {Luongthang}");
        }

        public override double Luong()
        {
            return Luongthang;
        }
    }
}