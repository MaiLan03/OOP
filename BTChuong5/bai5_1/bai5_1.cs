using System;

class Circle
{
    public double Radius { get; set; }

    public double Diameter
    {
        get { return 2 * Radius; }
    }

    public double Area
    {
        get { return Math.PI * Radius * Radius; }
    }

    public void XuatCircle()
    {
        Console.WriteLine($"Bán kính: {Radius}");
        Console.WriteLine($"Đường kính: {Diameter}");
        Console.WriteLine($"Diện tích: {Area}");
    }
}

class Sphere : Circle
{
    public new double Area
    {
        get { return 4 * Math.PI * Radius * Radius; }
    }

    public double Volume
    {
        get { return (4.0 / 3.0) * Math.PI * Radius * Radius * Radius; }
    }

    public void XuatSphere()
    {
        Console.WriteLine($"Bán kính: {Radius}");
        Console.WriteLine($"Diện tích bề mặt: {Area}");
        Console.WriteLine($"Thể tích: {Volume}");
    }
}

class Cylinder : Circle
{
    public double Height { get; set; }

    public double LateralArea
    {
        get { return 2 * Math.PI * Radius * Height; }
    }

    public double TotalArea
    {
        get { return 2 * Math.PI * Radius * (Radius + Height); }
    }

    public double Volume
    {
        get { return Math.PI * Radius * Radius * Height; }
    }

    public void XuatCylinder()
    {
        Console.WriteLine($"Bán kính đáy: {Radius}");
        Console.WriteLine($"Chiều cao: {Height}");
        Console.WriteLine($"Diện tích xung quanh: {LateralArea}");
        Console.WriteLine($"Diện tích toàn phần: {TotalArea}");
        Console.WriteLine($"Thể tích: {Volume}");
    }
}



class program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Radius = 6;
        circle.XuatCircle();

        Sphere sphere = new Sphere();
        sphere.Radius = 4;
        sphere.XuatSphere();

        Cylinder cylinder = new Cylinder();
        cylinder.Radius = 3;
        cylinder.Height = 8;
        cylinder.XuatCylinder();
    }
}




class HinhTron
{
    public double BanKinh { get; set; }
    public double DuongKinh = BanKinh * 2;
    public double DienTich = Math.PI * BanKinh * BanKinh;
}
class HinhCau : HinhTron
{
    public new double DienTich { get; set; }
    public double TheTich = (4/3) * 3.14 * BanKinh * BanKinh * BanKinh;
}
class HinhTru : HinhTron
{
    public double ChuViMatDay = 2 * 3.14 * BanKinh;
    public double DienTichMatDay = 3.14 * BanKinh * BanKinh;
    public double DienTichXungQuanh { get; set; }
    public double DienTichToanPhan = DienTichXungQuanh + DienTichMatDay;
    public double TheTich { get; set; }

    public HinhTru(double banKinh, double chieuCao)
    {
        BanKinh = banKinh;
        DienTichXungQuanh = 2 * Math.PI * banKinh * chieuCao;
        TheTich = DienTichMatDay * chieuCao;
    }
}

 