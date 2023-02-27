using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Bai lam cua Pham Duc Minh
namespace bai4
{
    abstract class Vienkhoahoc
    {
        public string Hoten { get; set; }
        public string Bangcap { get; set; }
        public int Namsinh { get; set; }

        public Vienkhoahoc() { }

        public Vienkhoahoc(string Hoten, int Namsinh, string Bangcap)
        {
            this.Hoten = Hoten;
            this.Bangcap = Bangcap;
            this.Namsinh = Namsinh;
        }
        public void Xuat() 
        {
            Console.WriteLine($"Ho va ten: {Hoten}");
            Console.WriteLine($"Nam sinh: {Namsinh}");
            Console.WriteLine($"Bang cap: {Bangcap}");
        }
        public abstract double Luong();
    }
}
