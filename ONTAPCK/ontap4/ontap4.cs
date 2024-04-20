/*Xét chương trình cho phép quản lý sinh viên với ba hệ đào tạo khác nhau: hệ cử nhân tài năng, hệ chính quy và hệ chất lượng cao.

Học bổng của sinh viên chính quy được tính như sau:
Nếu điểm trung bình >= 8.0 thì học bổng = 1000000
Nếu điểm trung bình >= 9.0 thì học bổng = 1500000

Học bổng của sinh viên cử nhân tài năng được tính như sau:
Nếu điểm trung bình >= 8.0 thì học bổng = 1500000
Nếu điểm trung bình >= 9.0 thì học bổng = 2000000

Học bổng của sinh viên chất lượng cao được tính như sau:
Nếu điểm trung bình >= 8.0 thì học bổng = 2000000
Nếu điểm trung bình >= 9.0 thì học bổng = 2500000

Hãy viết chương trình cho phép nhận vào các sinh viên cần quản lý
1. In ra danh sách sinh viên có học bổng và số tiền học bổng 
2. tính tổng số tiền học bổng Trường sẽ phát cho sinh viên. 
3. In ra thông sinh viên có thành tích cao nhất
4. Tìm kiếm sinh viên có học bổng hay không. Nếu có in ra thông tin và số tiền học bổng*/


class qlsv
{
    public string ten;
    public double diem;
    public int hb;
    public virtual void nhap()
    {
        Console.WriteLine("NHAP THONG TIN SINH VIEN");
        Console.Write("Nhap ten sinh vien: ");
        ten = Console.ReadLine();
        Console.Write("Diem trung binh: ");
        diem = double.Parse(Console.ReadLine());
    }
    public virtual void tinh(){}
    public virtual void xuat()
    {  }
}
class chinhqui : qlsv
{
    public override void nhap()
    {
        base.nhap();
    }
    public override void tinh()
    {
        if (diem>=8 & diem<9)
        {hb=1000;}
        if (diem>=9)
        {hb=1500;}
        if (diem<8) {hb=0;}
    }
    public override void xuat()
    {
        if (hb!=0)
        {Console.WriteLine("He chinh qui: Sinh vien {0}, diem {1}, co hoc bong = {2}",ten,diem,hb);}
        else {Console.WriteLine("He chinh qui: Sinh vien {0}, diem {1} khong co hoc bong",ten,diem);}
    }
    
}
class cntn : qlsv
{
    public override void nhap()
    {
        base.nhap();
    }
    public override void tinh()
    {
        if (diem>=8 & diem<9)
        {hb=1500;}
        if (diem>=9)
        {hb=2000;}
        if (diem<8) {hb=0;}
    }
    public override void xuat()
    {
        if (hb!=0)
        {Console.WriteLine("He cu nhan tai nang: Sinh vien {0}, diem {1}, co hoc bong = {2}",ten,diem,hb);}
        else {Console.WriteLine("He cu nhan tai nang: Sinh vien {0}, diem {1} khong co hoc bong",ten,diem);}
    }
}
class clc : qlsv
{
    public override void nhap()
    {
        base.nhap();
    }
    public override void tinh()
    {
        if (diem>=8 & diem<9)
        {hb=2000;}
        if (diem>=9)
        {hb=2500;}
        if (diem<8) {hb=0;}
    }
    public override void xuat()
    {
        if (hb==0) {Console.WriteLine("He CLC: Sinh vien {0}, diem {1} khong co hoc bong",ten,diem);}
        else
        {Console.WriteLine("He CLC: Sinh vien {0}, diem {1}, co hoc bong = {2}",ten,diem,hb);}
    }
}
class program 
{
    static void Main()
    {
        int tong=0;
        Console.Write("So sinh vien can nhap: ");
        int n = int.Parse(Console.ReadLine());
        qlsv [] sv = new qlsv[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("MENU");
            Console.WriteLine("1.Sinh vien he chinh qui");
            Console.WriteLine("2.Sinh vien he cu nhan tai nang");
            Console.WriteLine("3.Sinh vien he CLC");
            Console.WriteLine("------------------");
            Console.Write("Moi chon: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon==1)
            {
                sv[i] = new chinhqui();
                sv[i].nhap();
                sv[i].tinh();
                tong += sv[i].hb;
            }
            if (chon==2)
            {
                sv[i] = new cntn();
                sv[i].nhap();
                sv[i].tinh();
                tong += sv[i].hb;
            }
            if (chon==3)
            {
                sv[i] = new clc();
                sv[i].nhap();
                sv[i].tinh();
                tong += sv[i].hb;
            }
        }
        Console.WriteLine("------------------");
        Console.WriteLine("DANH SACH SV CO HOC BONG");
        for (int i=0;i<n;i++)
        {
            if (sv[i].hb!=0)
            {sv[i].xuat();}
        }
        Console.WriteLine("------------------");
        Console.WriteLine("TONG SO TIEN HOC BONG = " + tong);
        Console.WriteLine("------------------");
        Console.WriteLine("SV CO THANH TICH CAO NHAT");
        double max = sv[0].diem;
        for (int i=0;i<n;i++)
        {
            if (max<sv[i].diem)
            {max=sv[i].diem;}
        }
        for (int i=0;i<n;i++)
        {
            if (max==sv[i].diem)
            {sv[i].xuat();}
        }
        Console.WriteLine("------------------");
        Console.WriteLine("TIM KIEM");
        Console.Write("Nhap ten sinh vien: ");
        string x = Console.ReadLine();
        for (int i=0;i<n;i++)
        {
            if (sv[i].ten==x)
            {sv[i].xuat();}
        }
    }
}