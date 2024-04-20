/*Bài 1. Công viên Asia Park bán vé vui chơi với giá vé trọn gói là 
        250.000đ/ người lớn, 
        130.000đ/ trẻ em trên 1m,
        và miễn phí cho trẻ em dưới 1m. 
    Khách đến chơi gồm có người lớn và trẻ em.
Viết chương trình quản lý thông tin mua vé, gồm các thông tin: 
Đối với khách hàng là người lớn: Tên khách hàng, CMND, Giá vé.
Đối với khách hàng là trẻ em: Tên khách hàng, chiều cao, Giá vé.
Sau khi mua vé thì khách hàng sẽ được đeo thẻ như sau: 
    Người lớn sẽ mang thẻ đỏ, trẻ em sẽ được mang thẻ xanh.
Tính doanh thu của công viên sau một lượt tham quan.*/

class KhachHang
{
    public string Ten {get; set; }
    public double Gia {get; set; }
    public KhachHang (string Ten, double Gia)
    {
        this.Ten = Ten;
        this.Gia = Gia;
    }
    public void nhap()
    {
        Console.Write("Ten khach hang: ");
        Ten = Console.ReadLine();
    }
    public virtual void deothe()
    {
        Console.Write("Khach hang {0} ",Ten);
    }
}
class NguoiLon : KhachHang
{
    public string CCCD;
    public double dt1=0;
    public double DT1()
    {
        dt1 = dt1 + Gia;
        return dt1;
    }
    public NguoiLon (string Ten, double Gia, string CCCD) : base (Ten,Gia)
    {
        this.CCCD = CCCD;
    }
    public new double Gia = 250000;
    public new void nhap()
    {
        base.nhap();
        Console.Write("ID: ");
        CCCD = Console.ReadLine();
    }
    public override void deothe()
    {
        base.deothe();
        Console.WriteLine("co ID {0} deo the do. Gia ve = {1}",CCCD,Gia);   
    }
}
class TreEm : KhachHang
{
    public double ChieuCao;
    public double dt2 = 0;
    public double DT2()
    {
        dt2=dt2+Gia;
        return dt2;
    }
    public new double Gia;
    public TreEm (string Ten, double Gia, double ChieuCao) : base (Ten,Gia)
    {
        this.ChieuCao = ChieuCao;
    }

    public new void nhap()
    {
        base.nhap();
        Console.Write("Chieu cao: ");
        ChieuCao = double.Parse(Console.ReadLine());
         if (ChieuCao>100)
        {
            Gia = 130000;
        }
        else {
            Gia = 0;
        }
        
    }
    public override void deothe()
    {
        base.deothe();
        Console.WriteLine("cao {0} cm deo the xanh. Gia ve = {1}",ChieuCao,Gia);   
    }
}
class program
{
    static void Main()
    {
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        double doanhthu = 0;
        do{
        NguoiLon nl1 = new NguoiLon("a",1,"b");
        nl1.nhap();
        nl1.deothe();
        TreEm tre1 = new TreEm("a",0,2);
        tre1.nhap();
        tre1.deothe();
        Console.Write("x = ");
        x = int.Parse(Console.ReadLine());
        doanhthu = doanhthu + nl1.DT1() + tre1.DT2();
        }while (x!=0);
        Console.WriteLine("Doanh thu: " + doanhthu);
    }
}