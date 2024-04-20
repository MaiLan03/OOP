//BAI 2: CĂN HỘ
/*Bài 2. Khu căn hộ Vinhome có 2 loại căn hộ: 
    Basic (Căn hộ cơ bản) 
    Condo (Căn hộ cao cấp). 
Biết rằng, mỗi căn hộ cần quản lý đều có các thông tin cơ bản sau: 
    ID, Area (diện tích), Floor (Tầng), Price (Giá).    
Đối với căn hộ cao cấp thì có thêm thông tin về View (Hướng (Biển, Thành phố, Hồ bơi, …))
Việc tính giá căn hộ như sau: 
    Đối với căn hộ cơ bản: Giá = Giá sàn cơ bản * diện tích			
    Đối với căn hộ cao cấp: Giá = Giá sàn cao cấp * diện tích * Hệ số Hướng 
    Trong đó Hệ số hướng như sau:			
        Biển: 1.4; Hồ bơi: 1.1; Thành phố:1.2; Khác: 1.0
Viết chương trình quản lý căn hộ và tính giá cho từng căn hộ đó. 
Cho biết căn hộ nào có giá cao nhất.
*/
class vinhome
{
    public string id;
    public int  floor;
    public double price,gs,area;
    public vinhome (string id, double area, int floor, double gs){}
    public virtual void nhap()
    {
        Console.Write("ID: ");
        id = Console.ReadLine();
        Console.Write("Dien tich: ");
        area = double.Parse(Console.ReadLine());
        Console.Write("Tang: ");
        floor = int.Parse(Console.ReadLine());
        Console.Write("Gia san: ");
        gs = double.Parse(Console.ReadLine());
    }
    public virtual double tinh()
    {
        price = gs*area;
        return price;
    }
    public virtual void xuat()
    {
        Console.WriteLine("Can ho {0}, dien tich {1} thuoc tang {2} co gia {3}",id,area,floor,price);
    }
}
class basic : vinhome
{
    public basic (string id, double area, int floor, double gs) : base (id,area,floor,gs){}
    
    public override void nhap()
    {
        base.nhap();
    }
    public override double tinh()
    {
        base.tinh();
        return price;
    }
    public override void xuat()
    {
        base.xuat();
    }
}
class condo : vinhome
{
    public string view;
    public double hsh;
    public condo (string view,double hsh, string id,double area, int floor, double gs) : base (id,area,floor,gs){}
    public override void nhap()
    {
        base.nhap();
        Console.Write("Huong can ho: ");
        view = Console.ReadLine();
    }
    public override double tinh()
    {
        base.tinh();
        if (view=="bien"){hsh=1.4;}
        else if (view=="ho boi"){hsh=1.1;}
        else if (view=="tp"){hsh=1.2;}
        else {hsh=1.0;}
        price = price*hsh;
        return price;
    }
    public override void xuat()
    {
        Console.WriteLine("Can ho {0}, dien tich {1} thuoc tang {2}, huong {3} co gia {4}",id,area,floor,view,price);
    }
}
class program
{
    static void Main()
    {
        int sch = 0;
        vinhome [] canho = new vinhome[10];
        while (true)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("MENU: ");
            Console.WriteLine("1. Basic ");
            Console.WriteLine("2. Condo");
            Console.WriteLine("0. Ket thuc");
            Console.Write("Ban chon: ");
            int chon=int.Parse(Console.ReadLine());

            if (chon==1)
            {
                canho[sch] = new basic("1",2,3,4);
                canho[sch].nhap();
                canho[sch].tinh();
                sch+=1;
            }
            else if (chon==2)
            {
                canho[sch] = new condo("1",2,"3",4,5,6);
                canho[sch].nhap();
                canho[sch].tinh();
                sch+=1;
            }
            else if (chon==0)
            {   Console.WriteLine("KET THUC");
                break;}
        }
        double max = canho[0].price;
        for (int i=0;i<sch;i++)
        {
            if (max<canho[i].price)
            {   max=canho[i].price;
            }

        }
        for (int i=0;i<sch;i++)
        {
            canho[i].xuat();
        }
        for (int j=0;j<sch;j++)
        {
            if (max==canho[j].price)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Can ho co gia cao nhat la: ");
                canho[j].xuat();
            }
        } 
    }
}



/*BT2: CĂN HỘ VINHOME
Khu căn hộ Vinhome có 2 loại căn hộ: Basic (Căn hộ cơ bản) và Condo (Căn hộ cao cấp). 
Biết rằng, mỗi căn hộ cần quản lý đều có các thông tin cơ bản sau: 
ID, Area (diện tích), Floor (Tầng), Price (Giá). 
Đối với căn hộ cao cấp thì có thêm thông tin về View (Hướng (Biển, Thành phố, Hồ bơi, …))
Việc tính giá căn hộ như sau: 
Đối với căn hộ cơ bản: 			Đối với căn hộ cao cấp:
Giá = Giá sàn cơ bản * diện tích 	Giá = Giá sàn cao cấp * diện tích * Hệ số Hướng 
Trong đó Hệ số hướng như sau:			
Biển: 1.4; Hồ bơi: 1.1; Thành phố:1.2; Khác: 1.0
Viết chương trình quản lý căn hộ và tính giá cho từng căn hộ đó. Cho biết căn hộ nào có giá cao nhất.*/


// class Canho
// {
//     protected string id;
//     protected double area;
//     protected double floor;
//     protected double price;
//     public string[,] A=new string[50,10];
//     public Canho(string ID, double Area, double Floor, double Price)
//     {
//         id=ID;
//         area=Area;
//         floor=Floor;
//         price=Price;
//     }
//     public virtual void Xuat()
//     {
//         Console.WriteLine("");
//     }
//     public virtual void Nhap() {}
// }
// class Coban:Canho
// {
//     public int dem=0;
//     public double gia=0;
//     public Coban(String id, double area, double Floor, double price):base(id,area,Floor,price){}
//     public override void Nhap()
//     {
//         Console.Write("Nhap so can ho co ban:");
//         int x = Convert.ToInt32(Console.ReadLine());
//         for (int i=0;i<x;i++)
//         {
//             Console.Write("Nhap ID can ho:");
//             id=Convert.ToString(Console.ReadLine());
//             A[i,0]=id;
//             Console.Write("Dien tich cua can ho:");
//             area=Convert.ToDouble(Console.ReadLine());
//             A[i,1]=Convert.ToString(area);
//             Console.Write("Tang:");
//             floor=Convert.ToDouble(Console.ReadLine());
//             A[i,2]=Convert.ToString(floor);
//             Console.Write("Gia can ho co ban:");
//             price=Convert.ToDouble(Console.ReadLine());
//             A[i,3]=Convert.ToString(price);
//             Console.Write("Da nhap thanh cong!!!");
//             dem++;
//         }
//     }
//     public void Tinhtien()
//     {
//         for (int i=0; i<50; i++)
//         {
//         gia+=price*(Convert.ToDouble(A[i,1]));
//     }
//     }
//     public override void Xuat()
//     {
//         for(int i=0; i<50; i++)
//         {
//             if (A[i,0]==null)
//             {
//                 break;
//             }
//             for(int j=0; j<3; j++)
//             {
//                 Console.Write(A[i,0]);
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine(gia);
//     }
// }
// class Caocap:Canho
// {
//     protected string view;
//     public string Bien;
//     public string Hoboi;
//     public string Thanhpho;
//     public string Khac;
//     public double gi;
//     public double gia1;
//     public int dem1=0;
//     public int x;
//     public Caocap(string id, double area, double Floor, double price, string View):base(id,area,Floor,price)
//     {
//         view=View;
//     }
//     public override void Nhap()
//     {
//         Console.Write("Nhap so can ho cao cap:");
//         int x = Convert.ToInt32(Console.ReadLine());
//         for (int i=0;i<x;i++)
//         {
//             Console.Write("Nhap ID can ho:");
//             id=(Console.ReadLine());
//             A[i,0]=id;
//             Console.Write("Dien tich cua can ho:");
//             area=Convert.ToDouble(Console.ReadLine());
//             A[i,1]=Convert.ToString(area);
//             Console.Write("Tang:");
//             floor=Convert.ToDouble(Console.ReadLine());
//             A[i,2]=Convert.ToString(floor);
//             Console.Write("Gia cua can ho cao cap:");
//             price=Convert.ToDouble(Console.ReadLine());
//             A[i,3]=Convert.ToString(price);
//             Console.Write("Huong:");
//             view=Console.ReadLine();
//             A[i,4]=view;
//             {
//             if (view=="Bien")
//             {
//                 gi=1.4;
//             }
//             else if (view=="Hoboi")
//             {
//                 gi=1.1;
//             }
//             else if (view=="Thanhpho")
//             {
//                 gi=1.2;
//             }
//             else if (view=="Khac")
//             { gi =1.0; }
//             A[i,4]=Convert.ToString(price);
//             Console.Write("Nhap thanh cong!!!");
//             dem1++;
//             }
//     }
//     }
//     public void Tinhgiacanho()
//     {
//         for (int i=0; i<50; i++)
//         {
//             gia1+=gi*price*Convert.ToDouble(A[i,1]);
//         }
//     }
//     public void Giacaonhat()
//     {
//         double max=0;
//            for (int i = 0; i < 50; i++)
//             {
//                 if (Convert.ToDouble(A[i,3])>max) 
//                     max=Convert.ToDouble(A[i,3]);
//             }
//             Console.WriteLine("\n Can ho cao nhat la:{0}", max);
//     }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Coban a= new Coban("ab",1,1,1);
//         a.Nhap();
//         a.Tinhtien();
//         a.Xuat();
//         Caocap b = new Caocap("ab",1,1,1,"ab");
//         b.Nhap();
//         b.Tinhgiacanho();
//         b.Giacaonhat();
//         Console.WriteLine("Doanh thu can ho co ban:"+a.gia);
//         Console.WriteLine("Doanh thu can ho cao cap:"+b.gia1);
//         Console.WriteLine("Tong doanh thu cua can ho co ban va cao cap: "+(a.gia+b.gia1));
//     }
// }
// }