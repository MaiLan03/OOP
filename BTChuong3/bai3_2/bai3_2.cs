// See https://aka.ms/new-console-template for more information

// *Bài 2: Xây dựng lớp Meo gồm:
// Thuộc tính: Ten, Giong, Gioitinh, Tuoi
// Phương thức:
// • Hàm Khởi tạo, Hàm hủy
// • Hàm Nhập, Xuất, Đếm
// a) Xuất ra danh sách thông tin mèo đã nhập ra màn hình
// b) Đếm số lượng mèo có trong danh sách

// using System;

// class Meo
// {
//     // Thuộc tính
//     public string Ten { get; set; }
//     public string Giong { get; set; }
//     public string GioiTinh { get; set; }
//     public int Tuoi { get; set; }

//     // Biến đếm số lượng mèo
//     private static int soLuongMeo = 0;

//     // Hàm khởi tạo
//     public Meo(string ten, string giong, string gioiTinh, int tuoi)
//     {
//         Ten = ten;
//         Giong = giong;
//         GioiTinh = gioiTinh;
//         Tuoi = tuoi;

//         // Tăng biến đếm số lượng mèo
//         soLuongMeo++;
//     }

//     // Hàm xuất thông tin mèo
//     public void XuatThongTin()
//     {
//         Console.WriteLine($"Tên: {Ten}, Giống: {Giong}, Giới tính: {GioiTinh}, Tuổi: {Tuoi}");
//     }

//     // Hàm đếm số lượng mèo
//     public static int DemSoLuongMeo()
//     {
//         return soLuongMeo;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Tạo một đối tượng mèo
//         Meo meo1 = new Meo("Tom", "Short Hair", "Đực", 3);

//         // Xuất thông tin của mèo
//         meo1.XuatThongTin();

//         // Tạo thêm một đối tượng mèo
//         Meo meo2 = new Meo("", "", "", 0);  // Khởi tạo với giá trị mặc định

//         // Nhập thông tin cho mèo thứ hai
//         Console.WriteLine("Nhập thông tin cho mèo thứ hai:");
//         Console.Write("Nhập tên: ");
//         meo2.Ten = Console.ReadLine();
//         Console.Write("Nhập giống: ");
//         meo2.Giong = Console.ReadLine();
//         Console.Write("Nhập giới tính: ");
//         meo2.GioiTinh = Console.ReadLine();
//         Console.Write("Nhập tuổi: ");
//         meo2.Tuoi = int.Parse(Console.ReadLine());

//         // Xuất danh sách thông tin mèo
//         meo1.XuatThongTin();
//         meo2.XuatThongTin();

//         // Đếm số lượng mèo
//         Console.WriteLine($"Số lượng mèo trong danh sách: {Meo.DemSoLuongMeo()}");
//     }
// }

//----------

using System;
class Meo
{
   public string Ten;
   public string Giong;
   public string Gioitinh;
   public int Tuoi;
   public static int Dem;
   public Meo()
   {
      Ten = "";
      Giong="";
      Gioitinh="";
      Tuoi=0;
      Dem=0;
   } 
   public void Nhap()
   {
      Console.Write("Ten: ");
      Ten=Console.ReadLine();
      Console.Write("Giong: ");
      Giong=Console.ReadLine();
      Console.Write("Gioi tinh: ");
      Gioitinh=Console.ReadLine();
      Console.Write("Tuoi: ");
      Tuoi=int.Parse(Console.ReadLine());
      Dem=Dem+1;
   }
   public void Xuat()
   {
      Console.WriteLine($"Ten meo: {Ten}, Giong: {Giong}, Gioi tinh: {Gioitinh}, Tuoi: {Tuoi}");
      Console.WriteLine($"So luong meo:"+Meo.Dem);
   }
}
class Program
{
   static void Main(string[] args)
   {
      Meo m = new Meo();
      m.Nhap();
      m.Xuat();
      m.Nhap();
      m.Xuat();
      m.Nhap();
      m.Xuat();
   }
}
