// See https://aka.ms/new-console-template for more information
/*
Bài 1. Viết chương trình nhập vào họ tên Sinh viên, Lớp sinh hoạt, Điểm môn Quản trị
học, Hệ thống thông tin quản lý, Cơ sở lập trình, Triết học (theo thang điểm 10). In ra 
họ tên sinh viên bằng chữ IN HOA, lớp, và kết quả xếp loại của sinh viên theo tiêu 
chuẩn sau:
- Xuất sắc: Nếu GPA >=3.6
- Giỏi: Nếu 3.2<GPA <3.6
- Khá: Nếu 2.5 < GPA <3.2
- Trung bình: Nếu 2<GPA <2.5
- Yếu: Nếu Điểm < 2
*/
using System;
string hoten="", lop,xeploai="";
float qth,htttql,cslt,triet,gpa=0,a=0,b=0,c=0,d=0;
Console.Write("Ho va ten: ");
hoten = Console.ReadLine();
Console.Write("Lop : ");
lop = Console.ReadLine();
Console.Write("Diem_QTH: ");
qth = float.Parse(Console.ReadLine());
Console.Write("Diem_HTTTQL: ");
htttql = float.Parse(Console.ReadLine());
Console.Write("Diem_CSLT: ");
cslt = float.Parse(Console.ReadLine());
Console.Write("Diem_Triet: ");
triet = float.Parse(Console.ReadLine());
hoten=hoten.ToUpper();
if (0<=qth && qth<=3.9)
{
    a=0;
}
if (4<=qth && qth<=5.4)
{
    a=1;
}
if (5.5<=qth && qth<=6.9)
{
    a=2;
}
if (7<=qth && qth<=8.4)
{
    a=3;
}
if (8.5<=qth && qth<=10)
{
    a=4;
}
if (0<=htttql && htttql<=3.9)
{
    b=0;
}
if (4<=htttql && htttql<=5.4)
{
    b=1;
}
if (5.5<=htttql && htttql<=6.9)
{
    b=2;
}
if (7<=htttql && htttql<=8.4)
{
    b=3;
}
if (8.5<=htttql && htttql<=10)
{
    b=4;
}
if (0<=cslt && cslt<=3.9)
{
    c=0;
}
if (4<=cslt && cslt<=5.4)
{
    c=1;
}
if (5.5<=cslt && cslt<=6.9)
{
    c=2;
}
if (7<=cslt && cslt<=8.4)
{
    c=3;
}
if (8.5<=cslt && cslt<=10)
{
    c=4;
}
if (0<=triet && triet<=3.9)
{
    d=0;
}
if (4<=triet && triet<=5.4)
{
    d=1;
}
if (5.5<=triet && triet<=6.9)
{
    d=2;
}
if (7<=triet && triet<=8.4)
{
    d=3;
}
if (8.5<=triet && triet<=10)
{
    d=4;
}
gpa=(a+b+c+d)/4;
if (gpa < 2)
{
    xeploai="Yeu";
}
if (2 <gpa && gpa < 2.5)
{
    xeploai="Trung Binh";
}
if (2.5 < gpa && gpa < 3.2)
{
    xeploai="Kha";
}
if (3.2 < gpa && gpa < 3.6)
{
    xeploai="Gioi";
}
if (gpa>=3.6 )
{
    xeploai="Xuat sac";
}
Console.Write("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai {3}",hoten,lop,gpa,xeploai);