// See https://aka.ms/new-console-template for more information

// Bài 3: Xây dựng lớp Organization gồm:
// Thuộc tính: Name, Country, City, Address, Telephone là Tên
// Doanh nghiệp, Quốc gia, Thành phố, Địa chỉ, Số điện thoại
// Phương thức:
// • Hàm Khởi tạo, Hàm hủy
// • Hàm Nhập, Xuất – Để nhập và xuất thông tin
// Nhập và xác nhận các thông tin đầu vào trong đó yêu cầu:
// • Thông tin đầu vào các thuộc tính không được để trống
// • Thông tin về Số điện thoại phải đảm bảo đủ 10 chữ số và không được để trống
// Xuất ra màn hình thông tin của Doanh nghiệp nếu tất các thông tin nhập vào là hợp lệ.
// Trường hợp thông tin không hợp lệ thì thông báo “Nhập thông tin lỗi” và Dừng chương trình.

using System;
class Organization
{
   public string Name;
   public string Country;
   public string City;
   public string Address;
   public string Telephone;
   public Organization()
   {
      Name = "";
      Country = "";
      City = "";
      Address = "";
      Telephone = "";
   }
   public void Nhap()
   {
      Name=Console.ReadLine();
      Country=Console.ReadLine();
      City=Console.ReadLine();
      Address=Console.ReadLine();
      Telephone=Console.ReadLine();
   }
   public void Xuat()
   {
      Console.WriteLine("Ten: " + Name);
      Console.WriteLine("Quoc gia: " + Country);
      Console.WriteLine("Thanh pho: " + City);
      Console.WriteLine("Đia chi: " + Address);
      Console.WriteLine("So đien thoai: " + Telephone);
   }
   public static bool So(string Telephone)
    {
    foreach (char x in Telephone)
    {
        if (!Char.IsDigit(x))
            return false;
    }
    return true;
    }
   public bool KiemTra()
   {
      if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Country) ||
            string.IsNullOrEmpty(City) || string.IsNullOrEmpty(Address) ||
            string.IsNullOrEmpty(Telephone) || Telephone.Length != 10 || So(Telephone)==false)
        {
            return false;
        }
        return true; 
   }
}
class Program
{
    static void Main(string[] args)
    {
        Organization doanhNghiep = new Organization();

        doanhNghiep.Nhap();

        if (doanhNghiep.KiemTra())
        {
            doanhNghiep.Xuat();
        }
        else
        {
            Console.WriteLine("Nhap thong tin loi");
        }
    }
}
