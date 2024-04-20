// See https://aka.ms/new-console-template for more information
/*
Bài 4: Bảng kết quả của một giải vô địch bóng đá
được cho bởi ma trận 𝐴𝐴[𝑛𝑛 x 𝑛𝑛] (có n đội tham gia và mỗi đội phải đá vòng tròn 1 lượt, 
tức là mỗi đội phải đá n – 1 trận).
Trong đó:
+ Tất cả các phần tử thuộc đường chéo chính bằng 0
+ 𝐴[𝑖][𝑗] = 3 nếu đội i thắng đội j, và đội i có 3 điểm.
+ 𝐴[𝑖][𝑗] = 1 nếu đội i hòa với đội j, và đội i có 1 điểm.
+ 𝐴[𝑖][𝑗] = 0 nếu đội i thua đội j, và đội i có 0 điểm.
Hãy thực hiện các công việc sau:
a) In ra màn hình tất cả các đội có số điểm lớn nhất.
b) In ra màn hình tất cả các đội có số trận thắng nhiều hơn thua?
c) Hãy chỉ ra các đội không thua trận nào?
*/

using System;
 
class Program
{ 
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

// Khởi tạo ma trận kết quả
        int[,] A = new int[n, n];

// Đọc ma trận kết quả từ input
        for (int i = 0; i < n; i++)
        {
            string a = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                A[i, j] = int.Parse(a[j].ToString());
            }
        }

// a) In ra màn hình tất cả các đội có số điểm lớn nhất
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            int t = 0;
            for (int j = 0; j < n; j++)
            {
                t += A[i, j];
            }
            max = Math.Max(max, t);
        }
        for (int i = 0; i < n; i++)
        {
            int t = 0;
            for (int j = 0; j < n; j++)
            {
                t += A[i, j];
            }
            if (t == max)
            {
                Console.WriteLine(i + 1);
            }
        }

// b) In ra màn hình tất cả các đội có số trận thắng nhiều hơn thua
        for (int i = 0; i < n; i++)
        {
            bool w = true;
            for (int j = 0; j < n; j++)
            {
                if (A[i, j] < A[j, i])
                {
                    w = false;
                    break; 
                }
            }
            if (w)
            {
                Console.WriteLine(i + 1);
            }
        } 
 
// c) In ra màn hình các đội không thua trận nào
        for (int i = 0; i < n; i++)
        {
            bool nL = true;
            for (int j = 0; j < n; j++)
            {
                if (A[i, j] == 0 && i != j)
                {
                    nL = false;
                    break;
                }
            }
            if (nL)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}


/////--------/////

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
//         int[] points = new int[n];

//         for (int i = 0; i < n; i++)
//         {
//             string row = Console.ReadLine();
//             for (int j = 0; j < n; j++)
//             {
//                 if (i != j)
//                 {
//                     if (row[j] == '3')
//                     {
//                         points[i] += 3;
//                     }
//                     else if (row[j] == '1')
//                     {
//                         points[i] += 1;
//                         points[j] += 1;
//                     }
//                     else if (row[j] == '0')
//                     {
//                         points[j] += 3;
//                     }
//                 }
//             }
//         }

//         int maxPoints = 0;
//         for (int i = 0; i < n; i++)
//         {
//             maxPoints = Math.Max(maxPoints, points[i]);
//         }

//         Console.WriteLine("a) In ra màn hình các đội có số điểm lớn nhất:");
//         for (int i = 0; i < n; i++)
//         {
//             if (points[i] == maxPoints)
//             {
//                 Console.Write((i + 1) + " ");
//             }
//         }
//         Console.WriteLine();

//         Console.WriteLine("b) In ra màn hình các đội có số trận thắng nhiều hơn thua:");
//         for (int i = 0; i < n; i++)
//         {
//             if (points[i] > n - 1)
//             {
//                 Console.Write((i + 1) + " ");
//             }
//         }
//         Console.WriteLine();

//         Console.WriteLine("c) In ra màn hình các đội không thua trận nào:");
//         for (int i = 0; i < n; i++)
//         {
//             bool isUnbeaten = true;
//             for (int j = 0; j < n; j++)
//             {
//                 if (i != j && points[i] < points[j])
//                 {
//                     isUnbeaten = false;
//                     break;
//                 }
//             }
//             if (isUnbeaten)
//             {
//                 Console.Write((i + 1) + " ");
//             }
//         }
//         Console.WriteLine();
//     }
// }
