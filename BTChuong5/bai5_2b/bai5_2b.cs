using System;

public class Lecture : People
{
    public int Kinhnghiem { get; set; }
    public string Hocvi { get; set; }
    public string Chucvu { get; set; }

    public Lecture() : base()
    {
        
    }

    public Lecture(string id, string hoten, int tuoi, string diachi, int kinhnghiem, string hocvi, string chucvu)
        : base(id, hoten, tuoi, diachi)
    {
        Kinhnghiem = kinhnghiem;
        Hocvi = hocvi;
        Chucvu = chucvu;
    }

    public void Sapxep(List<Lecture> lecturers)
    {
        lecturers = lecturers.OrderByDescending(l => l.Kinhnghiem).ToList();
    }

    public void XuatGiangVien()
    {
        base.Xuat();
        Console.WriteLine($"Kinh nghiem: {Kinhnghiem} nam");
        Console.WriteLine($"Hoc vi: {Hocvi}");
        Console.WriteLine($"Chuc vu: {Chucvu}");
    }
}

class Program
{
    static void Main()
    {
        List<Lecture> lecturers = new List<Lecture>();

        // Thêm dữ liệu giảng viên
        lecturers.Add(new Lecture("GV001", "Nguyen Van A", 40, "Ha Noi", 10, "ThS", "Truong Khoa"));
        lecturers.Add(new Lecture("GV002", "Tran Thi B", 35, "Ho Chi Minh", 5, "TS", "Truong BM"));

        Lecture lecture = new Lecture();
        lecture.Sapxep(lecturers);

        Console.WriteLine("Thong tin Giang vien sau khi sap xep:");
        foreach (Lecture gv in lecturers)
        {
            gv.XuatGiangVien();
            Console.WriteLine();
        }
    }
}
