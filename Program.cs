using System;
class Program
{
    static void Main(string[] args)
    {
        //Task 1.

        Console.WriteLine("10 numbers of Fibonaccy:");

        int previous = 0;
        int current = 1;

        for (int i = 0; i<10; i++)
        {
            Console.WriteLine($"{previous} ");
            int next = previous + current;
            previous = current;
            current = next;
        }

        Console.WriteLine();

        //Task 2.

        Console.WriteLine("Even numbers from 2 to 20: ");

        for (int i = 2; i <= 20; i+= 2)
        {
            Console.WriteLine($"{i} ");
        }

        //Task 3.

        Console.WriteLine("Multiplication table from 1 to 5: ");

        for (int i = 1; i <= 5; i++)
        {
           
            for (int j = 1; j <=5; j++)
            {
                Console.Write($"{i * j} ");
            }
            
            Console.WriteLine();
        }

        //Task 4.

        string password = "qwerty";
        string input;
        
        do
        {
            Console.WriteLine("Put passward: ");
            input = Console.ReadLine();

            if (input != password)
                Console.WriteLine("Wrong password! Try again.");
        }

        while (input != password);

        Console.WriteLine("Welcome!");

     
    }
}






