// See https://aka.ms/new-console-template for more information

// Bài 4: Xây dựng lớp Triangle gồm:
// Thuộc tính: a, b, c (kiểu int) là 3 cạnh của một tam giác
// Phương thức:
// • Hàm Khởi tạo, Hàm hủy
// • Hàm Nhập, Xuất – Để nhập và xuất thông tin
// • Hàm Tính để tính chu vi và diện tích hình tam giác
// Tạo một Menu để thực hiện lặp lại các chức năng cho đến khi thoát:
// Bấm 1: Nhập các cạnh a,b,c của tam giác
// Bấm 2: Tính chu vi và diện tích hình tam giác
// Bấm 3: Xuất ra các giá trị a,b,c.
// Trường hợp các cạnh tạo được một tam giác thì Xuất ra giá trị Chu vi và Diện tích của tam giác. 
// Trường hợp không tạo được tam giác thì xuất ra màn hình “Không hợp lệ”
// Bấm 0: Thoát khỏi chương trình


using System;
public class Triangle
{
    public int a, b, c;
    public Triangle()
    {
        a=0;
        b=0;
        c=0;
    }
    public void Nhap()
    {
        Console.Write("a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("c: ");
        c = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine(a +","+b+","+c);
    }
    public bool KiemTraTamGiac()
    {
        return (a + b > c && a + c > b && b + c > a);
    }
    public double TinhChuVi()
    {
        return a + b + c;
    }
    public double TinhDienTich()
    {
        double p = TinhChuVi() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public static void Main(string[] args)
    {
        Triangle tr = new Triangle();
        int x;
        do
        {
            Console.WriteLine("menu");
            Console.WriteLine("bam 1. nhap cac canh cua tam giac");
            Console.WriteLine("bam 2. tinh chu vi va dien tich của tam giac");
            Console.WriteLine("bam 3. xuat ra cac gia tri a, b, c");
            Console.WriteLine("bam 0. Thoat khoi chuong trinh");
            Console.Write("chon : ");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    tr.Nhap();
                    break;
                case 2:
                    // if (tr.a + tr.b > tr.c && tr.a + tr.c > tr.b && tr.b + tr.c > tr.a)
                    if (tr.KiemTraTamGiac())
                    {
                        Console.WriteLine("chu vi: " + tr.TinhChuVi());
                        Console.WriteLine("dien tich: " + tr.TinhDienTich());
                    }
                    else
                    {
                        Console.WriteLine("khong hop le");
                    }
                    break;
                case 3:
                    tr.Xuat();
                    break;
                case 0:
                    Console.WriteLine("Thoat khoi chuong trinh");
                    break;
                default:
                    Console.WriteLine("khong hop le");
                    break;
            }
            Console.WriteLine();
        } 
           while (x != 0);
    }
}
