class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int b = Int32.Parse(Console.ReadLine());
            
        Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
        Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
        Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);
    }

}
         


