using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Student : People
    {
        private int SID;
        //private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student() //Constructor mac dinh
        {
            SID = 1;
            name = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        public Student(Student stu) //Constructor sao chep
        {
            SID = stu.SID;
            name = stu.name;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        //Constructor tham so
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            name = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        // Bai lam cua Pham Duc Minh
        public int getSID()
        {
            return SID;
        }
        public void setSID(int SID)
        {
            this.SID = SID;
        }
        public string getTenSV()
        {
            return name;
        }
        public void setTenSV(string TenSV)
        {
            this.name = TenSV;
        }
        public string getKhoa()
        {
            return Khoa;
        }
        public void setKhoa(string Khoa)
        {
            this.Khoa = Khoa;
        }
        public string getDiemTB()
        {
            return Khoa;
        }
        public void setDiemTB(float DiemTB)
        {
            this.DiemTB = DiemTB;
        }
        ////Cac Property cho tung thuoc tinh cua lop
        //public int StudentID //Property dai dien cho thuoc tinh SID
        //{
        //    get { return SID; } //Lay du lieu
        //    set { SID = value; } //Gan du lieu
        //}
        //public String Name
        //{
        //    get { return TenSV; }
        //    set { TenSV = value; }
        //}
        //public String Faculty
        //{
        //    get { return Khoa; }
        //    set { Khoa = value; }
        //}
        //public float Mark
        //{
        //    get { return DiemTB; }
        //    set { DiemTB = value; }
        //}
        //Phuong thuc hien thi du lieu
        public void Show()
        {
            Console.WriteLine($"MSSV: {SID}");
            Console.WriteLine($"Ten SV: {name}");
            Console.WriteLine($"Khoa: {Khoa}");
            Console.WriteLine($"Diem TB: {DiemTB}");
        }
    }
}
