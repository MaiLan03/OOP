using System;

public class People
{
    public string ID { get; set; }
    public string Hoten { get; set; }
    public int Tuoi { get; set; }
    public string Diachi { get; set; }

    public People()
    {
        ID ="";
        Hoten = "";
        Tuoi = 0;
        Diachi = "";
    }

    public People(string id, string hoten, int tuoi, string diachi)
    {
        ID = id;
        Hoten = hoten;
        Tuoi = tuoi;
        Diachi = diachi;
    }

    public void Nhap()
    {
        Console.Write("Nhap ID: ");
        ID = Console.ReadLine();
        Console.Write("Nhap Ho ten: ");
        Hoten = Console.ReadLine();
        Console.Write("Nhap Tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap Dia chi: ");
        Diachi = Console.ReadLine();
    }

    public void Xuat()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Ho ten: {Hoten}");
        Console.WriteLine($"Tuoi: {Tuoi}");
        Console.WriteLine($"Dia chi: {Diachi}");
    }
}

public class Students : People
{
    public string Name { get; set; }
    public double TP1 { get; set; }
    public double TP2 { get; set; }
    public double TP3 { get; set; }

    public Students() : base()
    {
        
    }

    public Students(string id, string hoten, int tuoi, string diachi, string name, double tp1, double tp2, double tp3)
        : base(id, hoten, tuoi, diachi)
    {
        Name = name;
        TP1 = tp1;
        TP2 = tp2;
        TP3 = tp3;
    }

    public double GPA()
    {
        double DTB = (TP1 + TP2 + TP3) / 3;
        return DTB;
    }

    public void XuatSinhVien()
    {
        base.Xuat();
        Console.WriteLine($"name: {Name}");
        Console.WriteLine($"Diem TP1: {TP1}");
        Console.WriteLine($"Diem TP2: {TP2}");
        Console.WriteLine($"Diem TP3: {TP3}");
        Console.WriteLine($"Diem trung binh: {GPA()}");
    }
}


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
        static void Main()
        {
            Students student = new Students();
            student.Nhap(); 
            student.XuatSinhVien(); 
        }
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
