// Bài 4: Xây dựng một ứng dụng quản lý điểm học phần OOP
// của sinh viên có chứa nội dung như sau:
// Lớp thông tin sinh viên (Info) bao gồm: ID, Hoten, Group lần lượt là Mã Sinh viên, Họ Tên Sinh viên, Lớp sinh hoạt, Lớp điểm thành phần (DiemTP) bao gồm TP1, TP2, TP3
// Các phương thức yêu cầu trong bài:
// • Nhập mã sinh viên, Họ và tên sinh viên và Lớp SH
// • Xuất số lượng sinh viên có trong lớp học phần OOP
// • Nhập điểm TP1, TP2, TP3 cho mỗi sinh viên
// • Tính điểm TB = TP1*0.1+TP2*0.3+TP3*0.6
// • Xuất ra thông tin của sinh viên và điểm trung bình môn OOP 
// using System;
// using System.Collections.Generic;
// class Info
// { 
//     public string ID { get; set; }
//     public string Hoten { get; set; }
//     public string Group { get; set; }
//     public int count;
//     public Info()
//     {

//     }

//     public void NhapThongTin()
//     {
//         Console.Write("Nhập mã sinh viên: ");
//         this.ID = Console.ReadLine();
//         Console.Write("Nhập họ và tên sinh viên: ");
//         this.Hoten = Console.ReadLine();
//         Console.Write("Nhập lớp sinh hoạt: ");
//         this.Group = Console.ReadLine();
//         count++;
//     }

//     public void XuatSoLuongSinhVien()
//     {
//         Console.WriteLine("Số lượng sinh viên trong lớp học phần OOP là: ",count);
//     }

//     public void NhapDiemTP()
//     {
//         Console.Write("Nhập điểm TP1: ");
//         double TP1 = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Nhập điểm TP2: ");
//         double TP2 = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Nhập điểm TP3: ");
//         double TP3 = Convert.ToDouble(Console.ReadLine());
//         DiemTP.Add(TP1);
//         DiemTP.Add(TP2);
//         DiemTP.Add(TP3);
//     }

//     public double TinhDiemTB()
//     {
//         return DiemTP[0] * 0.1 + DiemTP[1] * 0.3 + DiemTP[2] * 0.6;
//     }

//     public void XuatThongTin()
//     {

//         Console.WriteLine("Mã sinh viên: " + ID);
//         Console.WriteLine("Họ và tên sinh viên: " + Hoten);
//         Console.WriteLine("Lớp sinh hoạt: " + Group);
//         Console.WriteLine("Điểm trung bình môn OOP: " + TinhDiemTB());
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Info sv = new Info();
//         sv.NhapThongTin();
//         sv.NhapThongTin();
//         sv.NhapThongTin();
//         sv.XuatSoLuongSinhVien();

//         sv.NhapDiemTP();
//         sv.XuatThongTin();
//     }
// }



// using System;

// class Info
// {
//     public string ID { get; set; }
//     public string Hoten { get; set; }
//     public string Group { get; set; }
//     public int demsv;
//     public Info(string id, string hoten, string group)
//     {
//         ID = id;
//         Hoten = hoten;
//         Group = group;
//         demsv++;
//     }

//     public override string ToString()
//     {
//         return $"ID: {ID}, Hoten: {Hoten}, Group: {Group}";
//     }
// }

// class DiemTP
// {
//     public double TP1 { get; set; }
//     public double TP2 { get; set; }
//     public double TP3 { get; set; }

//     public DiemTP(double tp1, double tp2, double tp3)
//     {
//         TP1 = tp1;
//         TP2 = tp2;
//         TP3 = tp3;
//     }

//     public double DiemTB()
//     {
//         return TP1 * 0.1 + TP2 * 0.3 + TP3 * 0.6;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine($"Nhập thông tin cho sinh viên thứ :");
//         Console.WriteLine("Nhập mã sinh viên: ");
//         string id = Console.ReadLine();
//         Console.WriteLine("Nhập họ và tên sinh viên: ");
//         string hoten = Console.ReadLine();
//         Console.WriteLine("Nhập lớp sinh hoạt: ");
//         string group = Console.ReadLine();

//         // Info ifo = new Info(id, hoten, group);
//         // ifo.Add(ifo);

//         Console.WriteLine("Nhập điểm thành phần cho sinh viên");
//         Console.WriteLine("Nhập điểm TP1: ");
//         double tp1 = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Nhập điểm TP2: ");
//         double tp2 = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Nhập điểm TP3: ");
//         double tp3 = Convert.ToDouble(Console.ReadLine());
//         DiemTP diemTP = new DiemTP(tp1, tp2, tp3);
//         Console.WriteLine("Thông tin sinh viên: " + ifo.ToString());
//         Console.WriteLine("Số sinh viên: " + ifo.demsv);
//         Console.WriteLine("Điểm trung bình môn OOP: " + diemTP.DiemTB());
        
//     }
// }


using System;
using System.Collections.Generic;

class Info
{
    public string ID { get; set; }
    public string Hoten { get; set; }
    public string Group { get; set; }
    public static int count;
    public List<double> DiemTP { get; set; }

    public Info()
    {
        DiemTP = new List<double>();
    }

    public void NhapThongTin()
    {
        Console.Write("MaSv: ");
        ID = Console.ReadLine();
        Console.Write("Ho Ten SV: ");
        Hoten = Console.ReadLine();
        Console.Write("Lop: ");
        Group = Console.ReadLine();
        count++;
    }

    public void XuatSoLuongSinhVien(int count)
    {
        Console.WriteLine($"So luong Sv: {count}");
    }

    public void NhapDiemTP()
    {
        Console.Write("TP1: ");
        double TP1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("TP2: ");
        double TP2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("TP3: ");
        double TP3 = Convert.ToDouble(Console.ReadLine());
        DiemTP.Add(TP1);
        DiemTP.Add(TP2);
        DiemTP.Add(TP3);
    }

    public double TinhDiemTB()
    {
        return DiemTP[0] * 0.1 + DiemTP[1] * 0.3 + DiemTP[2] * 0.6;
    }

    public void XuatThongTin()
    {
        Console.WriteLine("Ma sinh vien: " + ID);
        Console.WriteLine("Ho và ten sinh vien: " + Hoten);
        Console.WriteLine("Lop sinh hoat: " + Group);
        Console.WriteLine("Điem trung binh mon OOP: " + TinhDiemTB());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Info sv = new Info();
        sv.NhapThongTin();
        sv.NhapThongTin();
        sv.NhapThongTin();
        sv.XuatSoLuongSinhVien(Info.count);


        sv.NhapDiemTP();
        sv.XuatThongTin();
    }
}
