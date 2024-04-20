﻿// See https://aka.ms/new-console-template for more information
/* chương 3:
viết chương trình quản lý học phí sinh viên:
yêu cầu :
Class sinhvien(MaSV,SoTC,Giamtru(%),hocphi)
biết rằng : học phí = SoTC *450000 - giamtru (%)*soTC*450000
sưr dụng phương thức truy cập, truy vấn hoặc get, set
xuat ra : Sinh viên có mã số ...,học...tín chỉ, Giảm trừ ... phải đóng học phí...
*/

// class Sinhvien
// {
//     private string MASV;
//     int SoTC;
//     double Giamtru;
//     double Hocphi;
//     public string masinhvien
//     {
//         get {return MASV;}
//         set {MASV = value;}
//     }
//     public int sotinchi
//     {
//         get { return SoTC;}
//         set {SoTC= value;}
//     }
//     public double Duociamtru
//     {
//         get{ return Giamtru;}
//         set {Giamtru=value;}
//     }
//     public double Donghocphi
//     {
//         get {return Hocphi=(SoTC *450000 - (Giamtru*SoTC*450000));}
//     }

// static void Main()
// {
//     Sinhvien sv = new Sinhvien();
//     sv.masinhvien = Console.ReadLine();
//     sv.sotinchi = int.Parse(Console.ReadLine());
//     sv.Duociamtru = int.Parse(Console.ReadLine());
    
//     Console.WriteLine("Sinh viên có mã số {0},học {1} tín chỉ, Giảm trừ {2} phải đóng học phí {3}",sv.MASV,sv.SoTC,sv.Giamtru,sv.Hocphi);
// }
// }

// class Hocsinh
// {
//     private string ten;
//     public string TEN
//     {
//     get {return ten;}
//     set {ten = value;}
//     }
//     public static int Count = 0;
//     public Hocsinh()
//     {
//     Console.Write("Nhap ho ten hoc sinh: ");
//     ten = Console.ReadLine();
//     Count++;
//     }
// }
// class SodoHocsinh
// {
// static void Main()
//     {
//     Console.WriteLine("So luong hoc sinh ban dau:"+Hocsinh.Count);
//     Hocsinh hs1 = new Hocsinh();
//     Console.WriteLine("So luong hoc sinh ban dau:"+Hocsinh.Count);
//     Hocsinh hs2 = new Hocsinh();
//     Console.WriteLine("So luong hoc sinh ban dau:"+Hocsinh.Count);
//     }
// }

/* viết 1 chương trình quản lý chi tiêu:
Yêu cầu xây dựng Lớp Chi tiêu : Income,OutCome,Balance,Cost.Viết phương thức khởi tạo dùng tham chiếu this,get,set...
Tính mức chi tiêu (Cost) và số dư (Balance) hiện có.
Biết rằng mức chi tiêu được tính bằng : Cost=(Outcome /Income)*100%, số dư được tính bằng : Balance =Income - OutCome. Trường hợp Balance < 10$ hoặc mức chi tiêu > 90% thì đưa ra cảnh báo chi tiêu "sắp hết"
*/
class Chitieu
{
    double Income,Outcome,Balance,Cost;
    public Chitieu (double Income,double Outcome)
    {
        this.Income = Income;
        this.Outcome  = Outcome;
    }
    public double balance
    { 
    get {return Income - Outcome;}
    }
    public double cost
    {
    get {return Outcome/Income*100;}
    }
    public void Xuat()
    {
        Console.WriteLine("Cost:{0}",Cost);
        Console.WriteLine("Balance:{0}",Balance);
        if ((Cost>=90) || (Balance<=10))
        {
            Console.WriteLine("Sap het tien");
        }
        else
        {
            Console.WriteLine("Con nhieu");
        }
    }
} 
class Program
{
    public static void Main(string[] args)
    {
        // double Income = double.Parse(Console.ReadLine());
        // double Outcome = double.Parse(Console.ReadLine());
        Chitieu ct = new Chitieu(300,100);
        ct.Xuat();
    }
}