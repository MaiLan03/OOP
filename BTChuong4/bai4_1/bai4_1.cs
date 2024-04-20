// Bài 1: Xây dựng lớp Phanso (Phân số) gồm:
// Thuộc tính: Tuso, Mauso (Tử số, Mẫu số)
// Phương thức:
// • Hàm Khởi tạo không Tham số, Hàm hủy
// • Hàm Nhập, xuất
// • Hàm Cong(), Tru(), Nhan(),Chia()
// Tính Tổng, Hiệu, Tích, Thương 2 phân số A và B rồi in ra kết
// quả trên màn hình.

// using System;
// class Phanso
// {
//     public int Tuso1;
//     public int Mauso1;
//     public int Tuso2;
//     public int Mauso2;
//     public Phanso()
//     {
//         Tuso1 = 0;
//         Mauso1 = 0;
//         Tuso2 = 0;
//         Mauso2 = 0;
//     }
//     public void Nhap()
//     {
//         Tuso1 = int.Parse(Console.ReadLine());
//         Mauso1 = int.Parse(Console.ReadLine());
//         Tuso2 = int.Parse(Console.ReadLine());
//         Mauso2 = int.Parse(Console.ReadLine());
//     }
//     float c,t,n,ch;
//     public float Cong()
//     {
//         c=(Tuso1+Tuso2)/(Mauso1+Mauso2);
//         return c;
//     }
//     public float Tru()
//     {
//         return (Tuso1*Mauso2-Tuso2*Mauso1)/(Mauso1*Mauso2);
//     }
//     public float Nhan()
//     {
//         return Tuso1*Tuso2/(Mauso1*Mauso2);
//     }
//     public float Chia()
//     {
//         return Tuso1*Mauso2/(Mauso1*Tuso2);
//     }
//     public void Xuat()
//     {
//        Console.WriteLine("2 phan so : {0}/{1} , {2}/{3}",Tuso1,Mauso1,Tuso2,Mauso2 );
//        Console.WriteLine(c); 
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Phanso ps = new Phanso();
//         ps.Nhap();
//         ps.Cong();
//         ps.Tru();
//         ps.Nhan();
//         ps.Chia();
//         ps.Xuat();
//     }
// }

public class Phanso 
{
    private int Tuso;
    private int Mauso;
    
    public Phanso() 
    {
        Tuso = 0;
        Mauso = 1;
    }
    
    public Phanso(int tuso, int mauso) 
    {
        Tuso = tuso;
        Mauso = mauso;
    }
    
    public void Nhap() 
    {
        int.TryParse(Console.ReadLine(),out Tuso);
        int.TryParse(Console.ReadLine(),out Mauso);
    }
    
    public void Xuat() 
    {
        Console.WriteLine($"{Tuso}/{Mauso}");   
    }    
    public Phanso Cong(Phanso ps2) 
    {
        int ts = Tuso * ps2.Mauso + ps2.Tuso * Mauso;
        int ms = Mauso * ps2.Mauso;
        return new Phanso(ts, ms);
    }
    
    public Phanso Tru(Phanso ps2) 
    {
        int ts = Tuso * ps2.Mauso - ps2.Tuso * Mauso;
        int ms = Mauso * ps2.Mauso;
        return new Phanso(ts, ms);
    }
    
    public Phanso Nhan(Phanso ps2) 
    {
        int ts = Tuso * ps2.Tuso;
        int ms = Mauso * ps2.Mauso;
        return new Phanso(ts, ms);
    }
    
    public Phanso Chia(Phanso ps2) 
    {
        int ts = Tuso * ps2.Mauso;
        int ms = Mauso * ps2.Tuso;
        return new Phanso(ts, ms);
    }
    public static void Main(String[] args) 
    {
        Phanso A = new Phanso(1, 2);
        Phanso B = new Phanso(3, 4);
        
        Phanso Tong = A.Cong(B);
        Phanso Hieu = A.Tru(B);
        Phanso Tich = A.Nhan(B);
        Phanso Thuong = A.Chia(B);    
    }
}
