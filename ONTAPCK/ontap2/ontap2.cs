//BAI HT
/*Xây dựng các loại đối tượng sách giáo khoa, tiểu thuyết, tạp chí. Viết chương trình cho phép quản lý một danh sách các loại đối tượng kể trên.
Mỗi loại trên đều có thông tin chung như sau: Tên, Nhà xuất bản, Năm xuất bản, Số trang, Giá bán.
Đối với SGK có thêm thông tin về khối lớp; đối với tiểu thuyết có thêm thông tin về thể loại (giả tưởng, hình sự, kinh dị,…);
đối với tạp chí có thêm thông tin về về dạng tạp chí theo định kỳ xuất bản (tuần san, nguyệt san, quý san,…)
1.Xuất ra tất cả thông tin
2.In ra thông tin sách có giá bán cao nhất
3.Tìm kiếm sách theo giá bán nằm trong khoảng từ a  đến b
4.Sắp xếp danh sách theo giá bán giảm dần*/

class sach
{
    public string ten,nxb;
    public int nam,st,gia;
    // public sach (string ten, string nxb, int nam, int st, int gia){}
    public virtual void nhap()
    {
        Console.Write("Ten: ");
        ten=Console.ReadLine();
        Console.Write("Nha xuat ban: ");
        nxb = Console.ReadLine();
        Console.Write("Nam xuat ban: ");
        nam = int.Parse(Console.ReadLine());
        Console.Write("So trang: ");
        st = int.Parse(Console.ReadLine());
        Console.Write("Gia ban: ");
        gia = int.Parse(Console.ReadLine());
    }
    public virtual void xuat()
    {
        
    }
}
class sgk : sach
{
    public int lop;
    // public sgk (int lop, string ten, string nxb, int nam, int st, int gia) : base (ten,nxb,nam,st,gia){}
    public override void nhap()
    {
        base.nhap();
        Console.Write("Lop: ");
        lop=int.Parse(Console.ReadLine());
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine("Sach giao khoa {0} lop {1}, nha xuat ban: {2}, nam xuat ban {3}, so trang {4}, gia = {5}",ten,lop,nxb,nam,st,gia);
    }
}
class tieuthuyet : sach
{
    public string theloai;
    // public tieuthuyet (string theloai,string ten,string nxb,int nam,int st,int gia) : base (ten,nxb,nam,st,gia){}
    public override void nhap()
    {
        base.nhap();
        Console.Write("The loai: ");
        theloai = Console.ReadLine();
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine("Tieu thuyet {0}, the loai {1}, nha xuat ban: {2}, nam xuat ban {3}, so trang {4}, gia = {5}",ten,theloai,nxb,nam,st,gia);
    }
}
class tapchi : sach
{
    public string dang;
    // public tapchi(string dang, string ten, string nxb, int nam, int st, int gia) : base (ten,nxb,nam,st,gia){}
    public override void nhap()
    {
        base.nhap();
        Console.Write("Dang tap chi: ");
        dang= Console.ReadLine();
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine("Tapchi {0}, ky xuat ban: {1}, nha xuat ban: {2}, nam xuat ban {3}, so trang {4}, gia = {5}",ten,dang,nxb,nam,st,gia);
    }
}
class program
{
    static void Main()
    {
        Console.Write("So sach can nhap: ");
        int n = int.Parse(Console.ReadLine());
        sach [] s = new sach[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("MENU");
            Console.WriteLine("1.Sach giao khoa");
            Console.WriteLine("2.Tieu thuyet");
            Console.WriteLine("3.Tap chi");
            Console.WriteLine("-----------------");
            Console.Write("Moi chon: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon==1)
            {
                s[i] = new sgk();//(1,"2","3",4,5,6);
                s[i].nhap();
            }
            else if (chon==2)
            {
                s[i] = new tieuthuyet(); //("1","2","3",4,5,6);
                s[i].nhap();
            }
            else if (chon==3)
            {
                s[i] = new tapchi();  //("1","2","3",4,5,6);
                s[i].nhap();
            }
            
        }
        //1.Xuat all thong tin
        Console.WriteLine("-----------------");
        Console.WriteLine("DANH SACH");
        for (int i=0;i<n;i++)
        {
            s[i].xuat();
        }
        Console.WriteLine("-----------------");
        //2. Xuat sach co gia cao nhat
        Console.WriteLine("Sach co gia ban cao nhat la: ");
        int max = s[0].gia;
        for (int i=0;i<n;i++)
        {
            if (s[i].gia > max)
            {
                max = s[i].gia;
            }
        }
        for (int i=0;i<n;i++)
        {
            if (s[i].gia == max)
            {s[i].xuat();}
        }
        Console.WriteLine("-----------------");
        //3. Tim kiem sach theo gia trong khoang a den b 
        Console.WriteLine("TIM KIEM SACH CO GIA TRONG KHOANG A & B");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            if (s[i].gia > a & s[i].gia < b)
            {s[i].xuat();}
        }
        Console.WriteLine("-----------------");
        //4. Sap xep theo gia giam dan
        Console.WriteLine("DS SACH THEO GIA BAN GIAM DAN");
        for (int i=0;i<n;i++)
        {
            for (int j=i+1;j<n;j++)
            {
                if (s[i].gia < s[j].gia)
                {
                    sach temp = s[i];
                    s[i] = s[j];
                    s[j] = temp;
                }
            }
            s[i].xuat();
        }
    }
}