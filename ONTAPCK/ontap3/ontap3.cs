//BAI HT2
/*Xét hóa đơn gồm nhiều mặt hàng với số lượng tương ứng. Có hai loại mặt hàng:

Hàng nội địa: Thành tiền = đơn giá + thuế VAT.
Hàng nhập khẩu: Thành tiền = 0.9 * đơn giá + thuế VAT.
Hãy viết chương trình cho phép:

Nhận vào thông tin chi tiết của một hóa đơn bán hàng. Thông tin gồm có: mã hóa đơn, người mua hàng,  tên mặt hàng và số lượng tương ứng, đơn giá. Đối với hàng nhập khẩu thêm thông tin về xuất xứ.
1. Tính tổng tiền tất cả hóa đơn, biết VAT = 5%.
2. Tìm hóa đơn hàng nhập khẩu dựa trên xuất xứ
3. Tính tổng tiền hóa đơn hàng nội địa. 
4. Tìm vị khách hàng mua nhiều hàng hóa nhất*/

class hdbh
{
    public string ma,ten,tenhang;
    public int sl;
    public double gia,tien,vat = 0.05;
    public virtual void nhap()
    {
        Console.Write("Ma hoa don: ");
        ma=Console.ReadLine();
        Console.Write("Nguoi mua hang: ");
        ten=Console.ReadLine();
        Console.Write("Ten mat hang: ");
        tenhang = Console.ReadLine();
        Console.Write("So luong: ");
        sl=int.Parse(Console.ReadLine());
        Console.Write("Gia: ");
        gia = double.Parse(Console.ReadLine());
    }
    public virtual void xuat()
    {Console.WriteLine("Ma hoa don: {0}, nguoi mua hang {1}, ten mat hang {2}, so luong {3}, gia = {4}, thanh tien {5}",ma,ten,tenhang,sl,gia,tien);}
    public virtual double tinh()
    {
        tien = sl*gia + sl*gia*vat;
        return tien;
    }
}
class noidia : hdbh
{
    public override void nhap()
    {
        Console.WriteLine("NHAP THONG TIN HOA DON HANG NOI DIA");
        base.nhap();
    }
    public override double tinh()
    {
        return base.tinh();
    }
    public override void xuat()
    {
        base.xuat();
    }
}
class nhapkhau : hdbh
{
    public string xuatxu;
    public override void nhap()
    {
        Console.WriteLine("NHAP THONG TIN HOA DON HANG NHAP KHAU");
        base.nhap();
        Console.Write("Xuat xu: ");
        xuatxu=Console.ReadLine();
    }
    public override double tinh()
    {
        return base.tinh()*0.9;
    }
    public override void xuat()
    {
        base.xuat();
    }
}
class program
{
    static void Main()
    {
        int so1 = 0, so2=0;
        double tong1=0,tong2=0;
        noidia [] nd = new noidia[10];
        nhapkhau [] nk = new nhapkhau[10];
        Console.Write("Tong so hoa don ban hang can nhap: ");
        int n = int.Parse(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("MENU");
            Console.WriteLine("1.Hoa don hang hoi dia");
            Console.WriteLine("2.Hoa don hang nhap khau");
            Console.WriteLine("------------------");
            Console.Write("Moi chon: ");
            int chon=int.Parse(Console.ReadLine());
            if (chon==1)
            {
                nd[so1] = new noidia();
                nd[so1].nhap();
                tong1 = tong1 + nd[so1].tinh();
                so1 += 1;
            }
            if (chon==2)
            {
                nk[so2] = new nhapkhau();
                nk[so2].nhap();
                tong2 += nk[so2].tinh();
                so2 += 1;
            }
        }
        Console.WriteLine("TONG TIEN ALL HD = {0}", tong1+tong2);
        //2. TIM HD HANG NK DUAJ TREN XUATXU
        Console.WriteLine("------------------");
        Console.WriteLine("TIM HOA DON HANG NHAP KHAU DUA TREN XUATXU");
        Console.Write("Nhap xuat xu: ");
        string a = Console.ReadLine();
        for (int i=0;i<so2;i++)
        {
            if (nk[i].xuatxu==a)
            {nk[i].xuat();}
        }
        //3. TONG HD HANG NOI DIA
        Console.WriteLine("------------------");
        Console.WriteLine("TONG TIEN HOA DON HANG NOI DIA = " + tong1);
        //4. KH MUA NHIEU HH NHAT
        Console.WriteLine("------------------");
        Console.WriteLine("VI KHACH MUA NHIEU HANG HOA NHAT: ");
        int max1 = nd[0].sl;
        int max2 = nk[0].sl;
        for (int i=0;i<so1;i++)
        {
            if (max1<nd[i].sl)
            {max1 = nd[i].sl;}
        }
        for (int i=0;i<so2;i++)
        {
            if (max2<nk[i].sl)
            {max2= nk[i].sl;}
        }
        if (max1>max2)
        {
            for (int i=0;i<so1;i++)
            {
                if (max1 == nd[i].sl)
                    {Console.WriteLine("Khach hang {0} mua {1} hang hoa",nd[i].ten,max1);}
            }
        }
        else if (max1<max2)
        {
            for (int i=0;i<so2;i++)
            {
                if (max2 == nk[i].sl)
                    {Console.WriteLine("Khach hang {0} mua {1} hang hoa",nk[i].ten,max2);}
            }
        }
        else if (max1==max2)
        {
            for (int i=0;i<so1;i++)
            {
                if (max1 == nd[i].sl)
                    {Console.WriteLine("Khach hang {0} mua {1} hang hoa",nd[i].ten,max1);}
            }
            for (int i=0;i<so2;i++)
            {
                if (max2 == nk[i].sl)
                    {Console.WriteLine("Khach hang {0} mua {1} hang hoa",nk[i].ten,max2);}
            }
        }
    }
}