class DICHVU
{
    public string ten,nhan,den;
    public int kc,dongia,giamgia;
    public double phidv;
    public virtual void nhap()
    {
        Console.Write("Nhap ten khach: ");
        ten=Console.ReadLine();
        Console.Write("Diem nhan: ");
        nhan=Console.ReadLine();
        Console.Write("Diem den: ");
        den=Console.ReadLine();
        Console.Write("Khoang cach: ");
        kc=int.Parse(Console.ReadLine());
        Console.Write("Don gia: ");
        dongia=int.Parse(Console.ReadLine());
        Console.Write("Giam gia: ");
        giamgia=int.Parse(Console.ReadLine());
    }
    public virtual void Phidichvu()
    {}
    public virtual void xuat()
    {}
}
class Xemay : DICHVU
{
    public override void nhap()
    {
        base.nhap();
    }
    public override void Phidichvu()
    {
        base.Phidichvu();
        phidv = kc*dongia - giamgia;
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine("XE MAY: Ten khach: {0}, diem nhan: {1}, diem den: {2}, khoang cach {3}km, don gia: {4}, giamgia {5}, phi dich vu: {6}",ten,nhan,den,kc,dongia,giamgia,phidv);
    }
}
class Oto : DICHVU
{
    double hsxe;
    public int loai;
    public override void nhap()
    {
        base.nhap();
        Console.Write("Loai xe: ");
        loai = int.Parse(Console.ReadLine());
        if (loai==4)
        {hsxe=1;}
        if (loai==7)
        {hsxe=1.5;}
    }
    public override void Phidichvu()
    {
        base.Phidichvu();
        phidv = (kc*dongia)*hsxe - giamgia;
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine("OTO: Ten khach: {0}, diem nhan: {1}, diem den: {2}, loai xe: {6} cho, khoang cach {3}km, don gia: {4}, giamgia {5}, phi dich vu: {6}",ten,nhan,den,kc,dongia,giamgia,phidv,loai);
    }  
}
class Giaohang : DICHVU
{
    public double giasp;
    public override void nhap()
    {
        base.nhap();
        Console.Write("Gia san pham: ");
        giasp = double.Parse(Console.ReadLine());
    }
    public override void Phidichvu()
    {
        base.Phidichvu();
        phidv = giasp + kc*dongia - giamgia;
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine("GIAO HANG: Ten khach: {0}, diem nhan: {1}, diem den: {2}, khoang cach {3}km, don gia: {4}, gia san pham: {6}, giamgia {5}, phi dich vu: {6}",ten,nhan,den,kc,dongia,giamgia,phidv,giasp);   
    }
}
class QUANLYDICHVU
{
    static void Main()
    {
        int x,y,z;
        //3.1 NHAP DS DICHVU
        Console.WriteLine("---NHAP DANH SACH DICH VU---");
        Console.Write("So xe may: ");
        x=int.Parse(Console.ReadLine());
        Console.Write("So Oto: ");
        y=int.Parse(Console.ReadLine());
        Console.Write("So do an: ");
        z=int.Parse(Console.ReadLine());
        Xemay [] xemay = new Xemay[x];
        Oto [] oto = new Oto[y];
        Giaohang [] doan = new Giaohang[z];
        Console.WriteLine("-----XE MAY-----");
        for (int i=0;i<x;i++)
        {
            Console.WriteLine("Xe may thu {0}",i+1);
            xemay[i] = new Xemay();
            xemay[i].nhap();
            xemay[i].Phidichvu();
            Console.WriteLine("-------------");
        }
        Console.WriteLine("-----OTO-----");
        for (int i=0;i<y;i++)
        {
            oto[i] = new Oto();
            oto[i].nhap();
            oto[i].Phidichvu();
            Console.WriteLine("-------------");
        }
        Console.WriteLine("-----GIAO HANG (DOAN)-----");
        for (int i=0;i<z;i++)
        {
            doan[i] = new Giaohang();
            doan[i].nhap();
            doan[i].Phidichvu();
            Console.WriteLine("-------------");
        }
        //3.2 TINH GIA DVU VA XUAT THONG TIN
        Console.WriteLine("\n-----DANH SACH DICH VU-----");
        foreach (Xemay a in xemay)
        {a.xuat();}
        foreach (Oto b in oto)
        {b.xuat();}
        foreach (Giaohang c in doan)
        {c.xuat();}
        //3.3 XUAT DICH VU KHACH HANG CO SU DUNG GIAM GIA
        Console.WriteLine("\n---CAC DICH VU KHACH HANG CO SU DUNG GIAM GIA---");
        for (int i=0;i<x;i++)
        {
            if (xemay[i].giamgia != 0)
            {xemay[i].xuat();}
        }
        for (int i=0;i<y;i++)
        {
            if (oto[i].giamgia != 0)
            {oto[i].xuat();}
        }
        for (int i=0;i<z;i++)
        {
            if (doan[i].giamgia != 0)
            {doan[i].xuat();}
        }
    }
}