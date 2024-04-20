// See https://aka.ms/new-console-template for more information
/*bài 3: Trong mảng một chiều gồm n phần tử là số thực, hãy tính:
a) Tổng giá trị tuyệt đối các phần tử âm của mảng;
b) Tích của các phần tử nằm giữa phần tử tối đa và phần tử tối thiểu của mảng.
c) Sắp xếp các phần tử của mảng theo thứ tự tăng dần.
d) Lấy phần nguyên của các phần tử là số thực, sau đó sắp xếp tất cả các phần tử
chẵn đứng trước (bên trái), còn các phần tử lẻ đứng sau (bên phải)
*/

using System.IO;
using System;
int n,i,j,x=0,y=0;
float a,s=0;
Console.Write("n = ");
n= int.Parse(Console.ReadLine());
float [] A;
A = new float [n];
for (i=0;i<n;i++)
{
  A[i] = float.Parse(Console.ReadLine());
}
foreach(float k in A)
    if (k < 0)
    {
        s+=Math.Abs(k);
    }
Console.WriteLine("Tong= {0}",s);
Console.Write("Tich= ");
float max=A[0];
float min=A[0];
for (i=0;i<n;i++)
{
    float t=1;
    if (max < A[i])
    {
        max=A[i];
        x = i;
    }
    if (min > A[i])
    {
        min = A[i];
        y = i;
    }
}
if (x==y+1 || x+1==y)
{
    Console.WriteLine(" 0 ");
}
else if (x > y)
{
    float t=1;
    for (j=1+y;j<x;j++)
    {
        t*=A[j];
    }
    Console.WriteLine("{0} ",t);
}
else  
{
    float t=1;
     for (j=1+x;j<y;j++)
    {
    t*=A[j];
    }
    Console.WriteLine("{0} ",t);
}

for (i = 0; i < n; i++)
{
    for (j = i + 1; j < n; j++)
        {
            if (A[j] < A[i])
            {
                a = A[i];
                A[i] = A[j];
                A[j] = a;
            }
        }
}
Console.Write("A_tang: ");
for (i = 0; i < n; i++)
{
    Console.Write("{0} ", A[i]);
}
Console.Write("A_biendoi = ");
for (i=0;i<n;i++)
{
    int b =(int)(A[i]);
    if ((b)%2==0)
    {
        Console.Write("{0} ",b);
    }
}
for (i=0;i<n;i++)
{
    int c =(int)(A[i]);
    if ((c)%2!=0)
    {
        Console.Write("{0} ",c);
    }
}
