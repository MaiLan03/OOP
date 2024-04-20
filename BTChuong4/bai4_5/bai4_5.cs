// Bài 5: Xây dựng lớp Doanhnghiep gồm các thuộc tính: TenDN,MST, Diachi lần lượt là Tên Doanh nghiệp, Mã số thuế, Địa chỉ của doanh nghiệp đó.
// Từ đó xây dựng lớp DanhsachDN (Danh sách doanh nghiệp) với các phương thức:
// Nhập danh sách doanh nghiệp
// Xuất danh sách doanh nghiệp
// Tìm mã số thuế theo tên doanh nghiệp (chỉ mục )
// Tìm tên doanh nghiệp và địa chỉ doanh nghiệp theo mã số thuế (chỉ mục )

class Doanhnghiep
{
    public string TenDN { get; set; }
    public string MST { get; set; }
    public string Diachi { get; set; }
} 
class DanhsachDN
{
    List<Doanhnghiep> danhSachDN;

    public DanhsachDN()
    {
        danhSachDN = new List<Doanhnghiep>();
    }

    public void NhapDanhSach()
    {
        Console.Write("So luong doanh nghiep: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Doanhnghiep dn = new Doanhnghiep();
            Console.Write("Ten doanh nghiep: ");
            dn.TenDN = Console.ReadLine();
            Console.Write("Ma so thue: ");
            dn.MST = Console.ReadLine();
            Console.Write("Diachi: ");
            dn.Diachi = Console.ReadLine();
            danhSachDN.Add(dn);
        }
    }
    public  void XuatDanhSach()
    {
        foreach (Doanhnghiep dn in danhSachDN)
        {
            Console.WriteLine("ten doanh nghiep " + dn.TenDN);
            Console.WriteLine("ma so thue " + dn.MST);
            Console.WriteLine("dia chi " + dn.Diachi);
            Console.WriteLine();
        }
    }
    public string TimMaSoThueTheoTen(string tenDN)
    {
        foreach (Doanhnghiep dn in danhSachDN)
        {
            if (dn.TenDN == tenDN)
            {
                return dn.MST;
            }
        }
        return "Khong tim thay";
    }

    public void TimTenVaDiaChiTheoMaSoThue(string mst)
    {
        foreach (Doanhnghiep dn in danhSachDN)
        {
            if (dn.MST == mst)
            {
                Console.WriteLine("ten doanh nghiep " + dn.TenDN);
                Console.WriteLine("dia chi " + dn.Diachi);
                return;
            }
        }
        Console.WriteLine("khong tim thay");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DanhsachDN danhSach = new DanhsachDN();
        danhSach.NhapDanhSach();
        while (true)
        {
            Console.WriteLine("--------MENU-------");
            Console.WriteLine("1. Xuat danh sach.                           ");
            Console.WriteLine("2. Tìm theo ten                                ");
            Console.WriteLine("3. Tìm theo mst                                ");
            Console.WriteLine("0. Exit.                                         ");
            Console.WriteLine("-----");
            Console.Write("Nhap tuy chon: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                {
                    Console.WriteLine("xuat danh sach:");
                    danhSach.XuatDanhSach();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("nhap ten doanh nghiep can tìm mst");
                    string tenDN = Console.ReadLine();
                    string maSoThue = danhSach.TimMaSoThueTheoTen(tenDN);
                    Console.WriteLine("ma so thue cua " + tenDN + " la: " + maSoThue);
                    break;
                }
                case 3:
                {
                    Console.WriteLine("nhap ma so thue can tìm ten và dia chi la ");
                    string mst = Console.ReadLine();
                    danhSach.TimTenVaDiaChiTheoMaSoThue(mst);
                    break;
                }
                case 0:
                {
                    Console.WriteLine("-----Exit -----");
                    break;
                }
                default:
                {
                    Console.WriteLine("-----Cau lenh khong co trong menu!!!!-----");
                    Console.WriteLine("-----Moi nhap lai!!!-----");
                    break;
                }
            }
        }
    }
} 
