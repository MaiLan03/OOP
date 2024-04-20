using System;
using System.IO;

class SUCKHOE
{
    public string CCCD;
    public string TenBN;
    public string GioiTinh;
    public string Benh;
    public string MucDo;   
}

class QuanLySucKhoe
{
    private string MaBN;
    private string TenBN;
    private string GioiTinh;
    private string Benh;
    private string MucDo;
    public string [,] SK = new string [50,6];
    public void NhapDS()
    {
        String input = File.ReadAllText(@"SucKhoe.txt" );
        int i = 0, j = 0;
        foreach (var row in input.Split('\n'))
        {
            j = 0;
            foreach (var col in row.Trim().Split(';'))
            {
                SK[i, j] = col.Trim();
                j++;
            }
            i++;
        }    
    }
    public void Them()
    {
        int i;
        for (i = 0; i < 20; i++)
        {
            if (SK[i, 0] ==null)
            {
                Console.WriteLine("Them moi");
                Console.WriteLine ("MABN: ");
                SK[i,0] = Console.ReadLine();        
                Console.WriteLine ("TenBN: ");
                SK[i,1] = Console.ReadLine();
                Console.WriteLine ("GioiTinh: ");
                SK[i,2] = Console.ReadLine();
                Console.WriteLine ("Benh: ");
                SK[i,3] = Console.ReadLine();
                Console.WriteLine ("Mucdo: ");
                SK[i,4] = Console.ReadLine();
                break;
            }
        }
    }

    public void CachLy()
    {
        int i;
        for (i = 0; i < 50; i++) 
        {
            if ((SK[i, 3] == "Lao") || (SK[i,3] == "Covid"))
            {
                Console.WriteLine("MaBN: " + SK[i,0] + ",TenBN:"+ SK[i,1] +"MaBN: "+ SK[i,2]+ SK[i,3] + SK[i,4]);
            }
        }        
    }

    public void SapXep()
    {

    }


}
class Programs
{
    static void Main(string[] args)
    {
        QuanLySucKhoe SK = new QuanLySucKhoe();
        SK.NhapDS();
        while (true)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Them moi danh sach.");
            Console.WriteLine("2. Cach ly");
            Console.WriteLine("3. Sap Xep.");
            Console.WriteLine("0. Exit.");
            Console.Write("Nhap tuy chon: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                Console.WriteLine("--Them moi--");
                SK.Them();
                Console.WriteLine("--Them thanh cong--");
            }
            else if (chon == 2)
            {
                Console.WriteLine("--Danh Sach Cach Ly--");
                SK.CachLy();
            }
            else if (chon == 3)
            {
                Console.WriteLine("DS Sap Xep:");
                SK.SapXep();
            }
            else if (chon == 0)
            {
                Console.WriteLine("Exit");
                break;

            }
            else 
            {
                Console.WriteLine("khong co tuy chon:");
            }
        }
    }
}

 


