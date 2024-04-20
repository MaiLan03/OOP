// Bài 2: Xây dựng lớp SoPhuc (Số phức) gồm:
// Thuộc tính: PhanThuc, PhanAo (Phần thực, Phần ảo)
// Phương thức:
// • Hàm Khởi tạo không Tham số, Hàm hủy
// • Hàm Nhập, xuất
// • Hàm Cong(), Tru(), Nhan(),Chia()
// Tính Tổng, Hiệu, Tích, Thương 2 số phức A và B rồi in ra kết quả trên màn hình.

using System;

public class SoPhuc
{
    private double phanThuc;
    private double phanAo;

    public SoPhuc()
    {
        phanThuc = 0;
        phanAo = 0;
        
    }

    public SoPhuc(double phanThuc, double phanAo)
    {
        this.phanThuc = phanThuc;
        this.phanAo = phanAo;
    }

    public void Nhap()
    {
        Console.Write("Nhập phần thực: ");
        phanThuc = double.Parse(Console.ReadLine());
        Console.Write("Nhập phần ảo: ");
        phanAo = double.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine("Số phức: {0} + {1}i", phanThuc, phanAo);
    }

    public SoPhuc Cong(SoPhuc soPhuc)
    {
        double tongPhanThuc = phanThuc + soPhuc.phanThuc;
        double tongPhanAo = phanAo + soPhuc.phanAo;
        return new SoPhuc(tongPhanThuc, tongPhanAo);
    }

    public SoPhuc Tru(SoPhuc soPhuc)
    {
        double hieuPhanThuc = phanThuc - soPhuc.phanThuc;
        double hieuPhanAo = phanAo - soPhuc.phanAo;
        return new SoPhuc(hieuPhanThuc, hieuPhanAo);
    }

    public SoPhuc Nhan(SoPhuc soPhuc)
    {
        double tichPhanThuc = phanThuc * soPhuc.phanThuc - phanAo * soPhuc.phanAo;
        double tichPhanAo = phanThuc * soPhuc.phanAo + phanAo * soPhuc.phanThuc;
        return new SoPhuc(tichPhanThuc, tichPhanAo);
    }

    public SoPhuc Chia(SoPhuc soPhuc)
    {
        double mauSo = Math.Pow(soPhuc.phanThuc, 2) + Math.Pow(soPhuc.phanAo, 2);
        double thuongPhanThuc = (phanThuc * soPhuc.phanThuc + phanAo * soPhuc.phanAo) / mauSo;
        double thuongPhanAo = (phanAo * soPhuc.phanThuc - phanThuc * soPhuc.phanAo) / mauSo;
        return new SoPhuc(thuongPhanThuc, thuongPhanAo);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SoPhuc A = new SoPhuc();
        SoPhuc B = new SoPhuc();

        Console.WriteLine("Nhập số phức A:");
        A.Nhap();

        Console.WriteLine("Nhập số phức B:");
        B.Nhap();

        SoPhuc tong = A.Cong(B);
        SoPhuc hieu = A.Tru(B);
        SoPhuc tich = A.Nhan(B);
        SoPhuc thuong = A.Chia(B);

        Console.WriteLine("Tổng: ");
        tong.Xuat();

        Console.WriteLine("Hiệu: ");
        hieu.Xuat();

        Console.WriteLine("Tích: ");
        tich.Xuat();

        Console.WriteLine("Thương: ");
        thuong.Xuat();
    }
}

