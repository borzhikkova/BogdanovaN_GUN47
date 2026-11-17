using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

class Program

{
    static void Main()
    {
        // Task 1. Fibonacci numbers
        int[] a = new int[8];
        a[0] = 0;
        a[1] = 1;

        for (int i = 2; i < a.Length; i++)
        {
            a[i] = a[i - 1] + a[i - 2];
        }

        Console.WriteLine("Fibonacci numbers:");
        Console.WriteLine(string.Join(",", a));



        // Task 2.
        string[] b = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
       Console.WriteLine("Months:");
        for (int i = 0; i < b.Length; i++)
       Console.WriteLine($"{i + 1,1}. {b[i]}");

        // Task 3.
        int[,] c = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int baseNum = j + 2;
                int power = i + 1;
                c[i, j] = (int)Math.Pow(baseNum, power);
            }
        }
         Console.WriteLine("The matrix:");
        for (int i = 0; i < 3; i++)
        {
                for (int j = 0; j < 3; j++)
                Console.WriteLine($"{c[i, j],5}");
                Console.WriteLine();
            
        }

        // Task 4.
        double[][] d = new double[3][];
        d[0] = new double[] { 1, 2, 3, 4, 5 };
        d[1] = new double[] { Math.E, Math.PI };
        d[2] = new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

        Console.WriteLine("Jagged array:");
        for (int i = 0; i < d.Length; i++)
        { Console.WriteLine($" d[{i}]: ");
          for (int j = 0; j < d[i].Length; j++ )
            Console.WriteLine ($" { d[i][j], 8:F3}" );
            Console.WriteLine() ;
        }

        // Task 5.
        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 6, 7 , 8, 9, 10, 11, 12, 13 };

        Array.Copy(array, array2, 3 );
        Console.WriteLine();
        Console.WriteLine($"array = [{string.Join(", ", array)}]");
        Console.WriteLine($"array2 = [{string.Join(", ", array2)}]");

        // Task 6.
        string[] sample = { " ", "" };
        Array.Resize(ref array, array.Length * 2);
        Console.WriteLine($"double array = [{string.Join(", ", array)}]");
        Console.WriteLine($"Size double array = {array.Length}");

    }
}


