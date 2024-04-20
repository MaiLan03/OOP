/*Bài 1:
Xây dựng lớp Bất động sản gồm các thuộc tính: MaBDS, TenBDS, Huong, Diachi, Dientich,
GiaBan lần lượt là Mã Bất động sản, Tên bất động sản (Đất, Nhà ở, Căn hộ, …), Hướng (Đông, 
Tây, Nam, Bắc, Đông Nam, Đông Bắc, Tây Nam, Tây Bắc), Địa chỉ, Diện tích, Giá Bán. 
Từ đó xây dựng một chương trình quản lý Bất động sản bao gồm: Lớp DanhsachBDS (Danh 
sách Bất động sản) với các phương thức:
Nhập danh sách bất động sản (Có thể nhập thủ cộng hoặc Import file (.txt/ .xlsx)
Thêm mới bất động sản
Sửa thông tin bất động sản (thông qua mã BDS)
Xóa bất động sản (thông qua mã BDS)
Xuất danh sách bất động sản
Tìm thông tin bất động sản theo Tên bất động sản. Hiển thị đầy đủ thông tin BĐS theo tên
Tìm tên và địa chỉ các Bất động sản theo Hướng. Hiển thị đầy đủ thông tin BĐS theo 
Hướng
Tìm tên và địa chỉ các Bất động sản theo khoảng giá bán (từ giá a đến giá b) và sắp xếp 
theo giá tăng dần. Hiển thị đầy đủ thông tin BDS theo giá
Yêu cầu bài tập:
Tạo Menu để thực hiện các chức năng chính của chương trình quản lý:
Bấm 1: Thêm mới danh sách
Bấm 2: Sửa thông tin
Bấm 3: Xóa thông tin
Bấm 4: Xuất danh sách 
Bấm 5: Tìm theo Tên
Bấm 6: Tìm theo Hướng
Bấm 7: Tìm theo Giá
Bấm 0: Exit
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class DanhsachBDS
{
    public string [,] danhsach = new string [50,6];
    public void Nhapds()
    {
        String input = File.ReadAllText(@"BDS.txt" );
        int i = 0, j = 0;
        foreach (var row in input.Split('\n'))
        {
            j = 0;
            foreach (var col in row.Trim().Split(';'))
            {
                danhsach[i, j] = col.Trim();
                j++;
            }
            i++;
        }    
    }
//--Xuất--//
    public void Xuat()
    {
        int i, j;
        for (i = 0; i < 50; i++)
        {
            for (j = 0; j < 6; j++)
            {
                Console.Write(danhsach[i, j] + "   ");
            }
            Console.WriteLine();
            if (danhsach[i+1,0]==null)
            {
                break;
            }   
        }
    }

//--Them--//
 
    public void Them()
    {
        int i;
        for (i = 0; i < 50; i++)
        {
            if (danhsach[i, 0] ==null)
            {
                Console.WriteLine("Nhap ma BDS muon them: ");
                danhsach[i, 0] = Console.ReadLine();
                Console.Write("Ten BDS: ");
                danhsach[i, 1] = Console.ReadLine();
                Console.Write("Huong: ");
                danhsach[i, 2] = Console.ReadLine();
                Console.Write("Dia chi: ");
                danhsach[i, 3] = Console.ReadLine();
                Console.Write("Dien tich: ");
                danhsach[i, 4] = Console.ReadLine();
                Console.Write("Gia ban: ");
                danhsach[i, 5] = Console.ReadLine();
                break;                 
            }         
        }   
    }

    public void TimtheoGia()
    {
        int i = 0;
        int j = 0;
        double a,b,tmp;
        double[] B= new double[50];
        Console.WriteLine("BDS ban muon tim nam trong khoang gia:");
        Console.Write("Tu: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Den: ");
        b = double.Parse(Console.ReadLine()); 
        for (i = 0; i < 50; i++)
        {
            B[i] = 0;
        }   
        for (i = 0; i < 50; i++)
        {
            if ((a <= Convert.ToDouble(danhsach[i, 5])) & (Convert.ToDouble(danhsach[i, 5]) <= b)) 
            {
                B[j] = Convert.ToDouble(danhsach[i, 5]);
                j++;
            }
        }    
        for (i = 0; i < 50; i++)
        {
            for (j = i + 1; j < 50; j++)
            {
                if (B[j] < B[i])
                {
                    tmp = B[i];
                    B[i] = B[j];
                    B[j] = tmp;
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
                if (Convert.ToDouble(danhsach[i, 5]) == q)
                {
                    Console.WriteLine("Ma BDS " + danhsach[i, 0] + " ,Ten BDS " + danhsach[i, 1] + " ,Huong BDS " + danhsach[i, 2] + " ,Dia chi " + danhsach[i, 3] + " ,Dien tich " + danhsach[i, 4] + " ,Gia ban BDS " + danhsach[i, 5]);
                }
            }
        } 
    }
    public void TimtheoGiaGiamDan()
    {
        int i = 0;
        int j = 0;
        double a,b,tmp;
        double[] C= new double[50];
        Console.WriteLine("BDS ban muon tim nam trong khoang gia:");
        Console.Write("Tu: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Den: ");
        b = double.Parse(Console.ReadLine()); 
        for (i = 0; i < 50; i++)
        {
            C[i] = 0;
        }   
        for (i = 0; i < 50; i++)
        {
            if ((a <= Convert.ToDouble(danhsach[i, 5])) & (Convert.ToDouble(danhsach[i, 5]) <= b)) 
            {
                C[j] = Convert.ToDouble(danhsach[i, 5]);
                j++;
            }
        }    
        for (i = 0; i < 50; i++) // sắp xếp giảm dần
        {
            for (j = i + 1; j < 50; j++)
            {
                if (C[j] > C[i])
                {
                    tmp = C[i];
                    C[i] = C[j];
                    C[j] = tmp;
                }
            }
        }
        for (i = 0; i < 50; i++)
        {
            for (j = i + 1; j < 50; j++)
            {
                if ((C[j] == C[i])&(C[j] != 0))
                {
                    C[j] = 0;
                }
            }
        }
        foreach (double q in C)
        {
            if (q==0)
            {
                continue;
            }    
            for (i = 0; i < 50; i++)
            {
                if (Convert.ToDouble(danhsach[i, 5]) == q)
                {
                    Console.WriteLine("Ma BDS " + danhsach[i, 0] + " ,Ten BDS " + danhsach[i, 1] + " ,Huong BDS " + danhsach[i, 2] + " ,Dia chi " + danhsach[i, 3] + " ,Dien tich " + danhsach[i, 4] + " ,Gia ban BDS " + danhsach[i, 5]);
                }
            }
        } 
    }
}

//--PROGRAM--//

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        DanhsachBDS DSBDS = new DanhsachBDS();
        DSBDS.Nhapds();
        while (true)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Them moi danh sach.");
            Console.WriteLine("2. Sua thong tin.");
            Console.WriteLine("3. Xoa thong tin.");
            Console.WriteLine("4. Xuat danh sach.");
            Console.WriteLine("5. Tim theo ten.");
            Console.WriteLine("6. Tim theo huong.");
            Console.WriteLine("7. Tim theo gia.");
            Console.WriteLine("0. Exit.");
            Console.Write("Nhap tuy chon: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                Console.WriteLine("--Them moi danh sach--");
                DSBDS.Them();
                Console.WriteLine("--Them BDS thanh cong--");
            }
            else if (chon == 4)
            {
                Console.WriteLine("--Xuat danh sach BDS--");
                DSBDS.Xuat();
            }
                            
            else if (chon == 0)
            {
                Console.WriteLine("--Da thoat khoi chuong trinh--");
                break;
            }
            else if (chon == 7)
            {
                Console.WriteLine("--Tim BDS theo gia--");
                DSBDS.TimtheoGia();
                break;
            }
            else if (chon == 8)
            {
                Console.WriteLine("--Tim BDS theo gia--");
                DSBDS.TimtheoGiaGiamDan();
                break;
            }
            else if (chon == 0)
            {
                Console.WriteLine("--Thoat khoi chuong trinh--");
                return;
            }
            else 
            {
                Console.WriteLine("--Khong co chuc nang nay--");
                Console.WriteLine("-----Moi nhap lai!-----");
                break;
            }
        }
    }
//--Tìm theo giá--//
}

