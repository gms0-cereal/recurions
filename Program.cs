// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

  Console.WriteLine("tribonacci");
int[] h = { 0, 1, 2};
///////////////  tribonacci
if (h.Length < 3)
{
    Console.WriteLine("here is the tribonacci sequence" + h);
}
else
{       
    for (int i = 0; i <11; i++)
    {
       int sum =h[^1] +h[^2] + h[^3];
       h = h.Append(sum).ToArray();     
       Console.WriteLine( h[i]);
    }  
}
////////////////fibonacci
/// if (h.Length < 3)
int[] j ={ 0, 1, 2};
if (j.Length < 3)
{
    Console.WriteLine("here is the tribonacci sequence" + j);
}
else
{
    Console.WriteLine("fibobnacci");
    for (int z = 0; z < 11; z++)
    {
        int sums = j[^1] + j[^2];
        j = j.Append(sums).ToArray();
        Console.WriteLine(j[z]);
    }

}
///////////// lucas numbers
 int[] a ={ 1, 1, 2};
if (a.Length < 3)
{
    Console.WriteLine("here is the tribonacci sequence" + a);
}
else
{
    Console.WriteLine("lucas");

    for (int u = 0; u < 11; u++)
    {
        int sumss = a[^1] + a[^3];
        a = a.Append(sumss).ToArray();
        Console.WriteLine(sumss);
    }

}