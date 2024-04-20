// See https://aka.ms/new-console-template for more information

// Bài 1: Xây dựng lớp Sach gồm:
// Thuộc tính: Tensach, Tacgia, NamXB, Soluong
// Phương thức:
// • Hàm Khởi tạo, Hàm hủy
// • Hàm Nhập, Xuất
// Xuất ra thông tin các loại sách đã nhập ra màn hình

using System;
class Sach 
{
   public string Tensach;
   public string Tacgia;
   public int NamXB;
   public int Soluong;
   public Sach()
   {
      Tensach = "hsfgjds";
      Tacgia = "dsgbkds";
      NamXB = 2010;
      Soluong = 10;
   }
    public Sach(string ts,string tg, int nxb, int sl)
    {
        Tensach = ts;
        Tacgia = tg;
        NamXB = nxb;
        Soluong = sl;  
    }
   public void Xuat()
   {
      Console.WriteLine($"Ten sach: {Tensach}, Tac gia: {Tacgia}, Nam xuat ban: {NamXB}, So luong: {Soluong}");
   }
} 
class Program
{
   static void Main(string[] args)
   {
      Sach s1 = new Sach();
      s1.Xuat();
      Sach s2 = new Sach("adshv","qADGR",2011,200);
      s2.Xuat();
      
   }
 
}