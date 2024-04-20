// Bài 3: Xây dựng lớp Tamgiac (Tam giác) gồm:
// Thuộc tính: Cạnh a, Cạnh b, Cạnh c
// Phương thức:
// • Hàm Khởi tạo không Tham số, Hàm hủy
// • Hàm Nhập, xuất
// • Hàm Kiemtra()
// Xuất ra màn hình kiểu của tam giác (Tam giác thường, tam giác vuông, tam giác cân, tam giác vuông cân, tam giác đều)

using System;
class Tamgiac
{
    public int a;
    public int b;
    public int c;
    public Tamgiac()
    {
        a=0;
        b=0;
        c=0;
    }
    public void Nhap()
    {
        a=int.Parse(Console.ReadLine());
        b=int.Parse(Console.ReadLine());
        c=int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine(tamgiac);
    }
    public string tamgiac;
    public void KiemTra()
    {
        
        if (a+b>c && a+c>b && b+c>a)
        {
            if ((a==b) || (a==c) || (b==c)) 
            {
                if ((a*a+b*b==c) || (a*a+c*c==b*b) || (b*b+c*c==a*a))
                {
                    tamgiac= "Tam giac vuong can";
                }
                else if ((a==b) && (a==c) && (b==c))
                {
                    tamgiac ="Tam giac deu";
                }
                else
                {
                    tamgiac ="Tam giac can";
                }
            }
            else if ((a*a+b*b==c) || (a*a+c*c==b*b) || (b*b+c*c==a*a))
            {
                tamgiac= "Tam giac vuong";
            }
            else 
            {
                tamgiac= "Tam giac thuong";
            }
        }
        else 
        {
            tamgiac= "Khong phai tam giac";
        } 
    }
}
class Program
{
    static void Main(string[] avgs)
    {
        Tamgiac TG = new Tamgiac();
        TG.Nhap();
        TG.KiemTra();
        TG.Xuat();
    } 
}
