using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Khoahoc : Vienkhoahoc
    {
        public int Ngaycong { get; set; }
        public double Bacluong { get; set; }
        public int Baibao { get; set; }
        public string Chucvu { get; set; }
        public Khoahoc() : base() {}
        public Khoahoc(string Hoten, int Namsinh, string Bangcap, string chucvu, int baibao, int ngaycong, double bacluong) : base(Hoten, Namsinh, Bangcap) 
        {
            Ngaycong = ngaycong;
            Bacluong = bacluong;
            Baibao = baibao;
            Chucvu = chucvu;
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Chuc vu: {Chucvu}");
            Console.WriteLine($"So bai bao da cong bo: {Baibao}");
            Console.WriteLine($"So ngay cong trong thang: {Ngaycong}");
            Console.WriteLine($"Bac luong: {Bacluong}");
        }
        public override double Luong()
        {
            double luong = Ngaycong * Bacluong;
            return luong;
        }
    }
}