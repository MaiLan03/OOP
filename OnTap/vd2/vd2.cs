/*Xây dựng lớp Thangleo gồm các thuộc tính: MaThang, LoaiThang, Chieucao, Soluong, GiaBan 
                            lần lượt là Mã Thang, Loại Thang, Chiều cao, Số lượng, Giá Bán
Từ đó xây dựng một chương trình quản lý sản phẩm Thang leo bao gồm: Lớp DanhsachThang (Danh sách Thang) với các phương thức:
§ Nhập danh sách Thang (Có thể nhập thủ cộng hoặc Import file)
§ Thêm mới sản phẩm Thang
§ Xuất danh sách sản phẩm Thang leo
§ Tìm thông tin các sản phẩm Thang qua chiều cao của thang (từ a (m) đến b (m)). 
    Hiển thị đầy đủ thông tin của Thang thông qua chiều cao
§ Sắp xếp danh sách Thang leo theo Giá bán (từ thấp đến cao)
§ Kiểm tra số lượng sản phẩm bằng cách nhập vào Mã thang và số lượng cần mua. 
    Nếu số lượng cần mua nhỏ hơn hoặc bằng số lượng tồn kho thì xuất ra “OK”, 
    ngược lại thì xuất ra “CHỈ CÒN <số lượng tồn kho> THANG. KHÔNG ĐỦ HÀNG”.
§ So sánh giá của các sản phẩm thang cùng loại và cùng chiều cao. Xuất ra màn hình thông tin của thang có giá bán thấp nhất và cao nhất trong cùng phân khúc tìm kiếm đó.
Yêu cầu bài tập:
Tạo Menu để thực hiện các chức năng chính của chương trình quản lý:
Bấm 1: Thêm mới danh sách
Bấm 2: Xuất danh sách
Bấm 3: Tìm sản phẩm theo chiều cao khoảng
Bấm 4: Sắp xếp theo giá bán từ thấp đến cao 
Bấm 5: Kiểm tra
Bấm 6: So sánh
Bấm 7: Sửa sản phẩm theo mã
Bấm 8: Xóa sản phẩm theo mã
Bấm 9: Tìm sản phẩm theo loại
Bấm 0: Exit
*/
/*
String input = File.ReadAllText( @"<path>" );
int i = 0, j = 0;
int[,] res = new int[100, 100];
foreach (var row in input.Split('\n'))
{
   j = 0;
   foreach (var col in row.Trim().Split(', '))
   {
       res[i, j] = int.Parse(col.Trim());
       j++;
   }
   i++;
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class ThangLeo 
{

    public string [,] dsThang = new string [50,6];
    public void NhapdsT()
    {
        String input = File.ReadAllText(@"ThangLeo.txt" );
        int i = 0, j = 0;
        foreach (var row in input.Split('\n'))
        {
            j = 0;
            foreach (var col in row.Trim().Split(", "))
            {
                dsThang[i, j] = col.Trim();
                j++;
            }
            i++;
        }    
    }   
    public void Them()
    {
        int i;
        for (i=0;i<50;i++)
        {
            if (dsThang[i, 0] ==null)
            {
                Console.WriteLine("Them moi san pham");
                Console.Write("Ma thang:");
                dsThang[i,0] = Console.ReadLine();
                Console.WriteLine("Loai thang");
                dsThang[i,1] = Console.ReadLine();
                Console.Write("Chieu cao");
                dsThang[i,2] = Console.ReadLine();
                Console.Write("So luong");
                dsThang[i,3] = Console.ReadLine();
                Console.Write("Gia ban");
                dsThang[i,4] = Console.ReadLine();
                break;
            }
        }
    }
    public void Xuat()
    {
        int i, j;
        for (i = 0; i < 50; i++)
        {
            for (j = 0; j < 6; j++)
            {
                Console.Write(dsThang[i, j] + "   ");
            }
            Console.WriteLine();
            if (dsThang[i+1,0]==null)
            {
                break;
            }   
        }
    }
    public void TimTheoKhoangChieuCao()
    {
        Console.WriteLine("Nhap khoang chieu cao:");
        Console.Write("Tu: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Den: ");
        double b = double.Parse(Console.ReadLine());
        int i,j;
        double tmp;
        double[] A = new double[50];
        for (i = 0; i < dsThang.GetLength(0); i++)
        {
            double height;

            if (double.TryParse(dsThang[i, 2].Substring(0, 1), out height))
            {
                if (height >= a && height <= b)
                {
                    Console.WriteLine("Ma Thang " + dsThang[i, 0] + " ,Loai Thang " + dsThang[i, 1] + " ,Chieu cao " + dsThang[i, 2] + " ,So luong " + dsThang[i, 3] + " ,Gia ban " + dsThang[i, 4] );
                }
            }
            else
            {
                Console.WriteLine($"Invalid height format for product {dsThang[i, 0]}");
            }
        }

    }
    public void SapXepTangTheoGia()
    {   
        int i,j;
        double tmp;
        double[] B = new double[50];
        for (i = 0; i < 50; i++)
        {
            B[i] = 0;
        }   
        for (i = 0; i < 50; i++)
        {
            B[i] = Convert.ToDouble(dsThang[i, 4]);
            i++;
        }
        for (i = 0; i <50;i++)
        {
            for(j = i+1; j <50; j++)
            {
                if (B[i] < B[j])
                {
                    tmp = B[j];
                    B[j] = B[i];
                    B[i] = tmp;
                }
            }
        }
        for (i = 0; i < 50; i++)
        {
            for (j = i + 1; j < 50; j++)
            {
                if ((B[j] == B[i])&(B[j] != 0))
                {
                    B[j] = 0;
                }
            }
        }
        foreach (double q in B)
        {
            if (q==0)
            {
                continue;
            }    
            for (i = 0; i < 50; i++)
            {
                if (Convert.ToDouble(dsThang[i, 4]) == q)
                {
                    Console.WriteLine("Ma Thang " + dsThang[i, 0] + " ,Loai Thang " + dsThang[i, 1] + " ,Chieu cao " + dsThang[i, 2] + " ,So luong " + dsThang[i, 3] + " ,Gia ban " + dsThang[i, 4] );
                }
            }
        }        

    }
    public void KiemTra()
    {

    }
    public void SoSanh()
    {

    }
    public void SuaTheoMa()
    {

    }
    public void XoaTheoMa()
    {

    }
    public void TimTheoLoai()
    {

    }


    
    // public void Tim()
    // {
    //     int i = 0;
    //     int j = 0;
    //     double a,b,tmp;
    //     // double[] C= new double[50];
    //     Console.WriteLine("tim san pham theo khoang gia:");
    //     Console.Write("Tu: ");
    //     a = double.Parse(Console.ReadLine());
    //     Console.Write("Den: ");
    //     b = double.Parse(Console.ReadLine());
    //     foreach (var j in )
    //     {
    //         if ((a <= Convert.ToDouble(dsThang[i, 4])) & (Convert.ToDouble(dsThang[i, 4]) <= b))
    //         {

    //         }
    //     }
        
    // }

}

class program
{
    static void Main(string[] args )
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        ThangLeo DST = new ThangLeo();
        DST.NhapdsT();
        while (true)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("Bam 1: Them moi danh sach");
            Console.WriteLine("Bam 2: Xuat danh sach");
            Console.WriteLine("Bam 3: Tim san pham theo khoang chieu cao");
            Console.WriteLine("Bam 4: Sap xep theo gia ban tu thap den cao");
            Console.WriteLine("Bam 5: Kiem tra");
            Console.WriteLine("Bam 6: So sanh");
            Console.WriteLine("Bam 7: Sua san pham theo ma");
            Console.WriteLine("Bam 8: Xoa san pham theo ma");
            Console.WriteLine("Bam 9: Tim san pham theo loai");
            Console.WriteLine("Bam 0. Exit.");

            Console.Write("Nhap tuy chon: ");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Them moi danh sach");
                    DST.Them();
                    Console.WriteLine("Them thanh cong");
                    break;
                case 2:
                    Console.WriteLine("Xuat danh sach");
                    DST.Xuat();
                    break;
                case 3:
                    Console.WriteLine("Tim san pham theo khoang chieu cao");
                    DST.TimTheoKhoangChieuCao();
                    break;
                case 4:
                    Console.WriteLine("Sap xep sản pham theo gia tu thap den cao");
                    DST.SapXepTangTheoGia();
                    break;
                case 5:
                    Console.WriteLine("Kiem Tra");
                    DST.KiemTra();
                    break;
                case 6:
                    Console.WriteLine("So sanh");
                    DST.SoSanh();
                    break;
                case 7:
                    Console.WriteLine("Sua sna pham theo ma");
                    DST.SuaTheoMa();
                    break;
                case 8:
                    Console.WriteLine("Xoa san pham theo ma");
                    DST.XoaTheoMa();
                    break;
                case 9:
                    Console.WriteLine("Tim san pham theo loai");
                    DST.TimTheoLoai();
                    break;   
                case 0:
                    Console.WriteLine("Exit");
                    Console.WriteLine("Thoat thanh cong!!");
                    return;
                    
                default:
                    Console.WriteLine("Khong co tuy chon, Moi nhap lai!!");
                    break;
            }
        }
    }   
}