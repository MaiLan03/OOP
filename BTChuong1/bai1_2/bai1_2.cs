// See https://aka.ms/new-console-template for more information
/*Bài 2. Xây dựng các hàm để thực hiện bài toán sau đây:
• Hàm Nhap() để:
- Nhập từ bàn phím hai số thực: a và b;
- Nhập từ bàn phím một toán tử (+, - , * , / );
• Hàm Thuchien() để thực hiện các phép toán tương ứng
• Hàm InKQ() để in lên màn hình kết quả của biểu thức tương ứng;
- Chương trình sẽ lặp lại việc tính trên cho đến khi bấm phím “T” hoặc “t” thì kết thúc.
*/

using System;
class Program
{
    static void Nhap(out double a, out double b, out char ch)
    {
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Toan tu: ");
        ch = char.Parse(Console.ReadLine());
    }

    static double ThucHien(double a, double b, char ch)
    {
        double ketQua = 0;

        switch (ch)
        {
            case '+':
                ketQua = a + b;
                break;
            case '-':
                ketQua = a - b;
                break;
            case '*':
                ketQua = a * b;
                break;
            case '/':
                ketQua = a / b;
                break;
            default:
                Console.WriteLine("phep tinh khong hop le!");
                break;
        }
        return ketQua;
    }
    static void InKQ(double a, double b, char ch, double ketQua)
    {
        Console.WriteLine($"{a} {ch} {b} = {ketQua}");
    }

    static void Main(string[] args)
    {
        char tiepTuc;
        do
        {
            double a, b;
            char ch;

            Nhap(out a, out b, out ch);

            double ketQua = ThucHien(a, b, ch);

            InKQ(a, b, ch, ketQua);

            Console.Write("Tiep tuc: ");
            tiepTuc = char.Parse(Console.ReadLine());
        } while (tiepTuc != 'T' && tiepTuc != 't');
    }
}
