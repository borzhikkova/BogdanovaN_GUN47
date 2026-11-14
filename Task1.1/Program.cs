class Program
{
    static void Main(string[] args)
    {
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a Number!");
            return;
        }

        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a Number!");
            return;
        }
        char op;
        while (true)
        {
            Console.WriteLine("PUT (&, | или ^): ");
            string s = Console.ReadLine();

            if (!string.IsNullOrEmpty(s) && s.Length == 1 && (s[0] == '&' || s[0] == '|' || s[0] == '^'))
            {
                op = s[0];
                break;
            }

            Console.WriteLine("ERROR");
        }
        switch (op)
        {
            case '&':
                Console.WriteLine("Result of {0} & {1} = {2}", a, b, a & b);
                Console.WriteLine(Convert.ToString (a & b, 2));
                Console.WriteLine("{0:X}", a & b);
                break;
            case '|':
                Console.WriteLine("Result of {0} | {1} = {2}", a, b, a | b);
                Console.WriteLine(Convert.ToString(a | b, 2));
                Console.WriteLine("{0:X}", a | b);
                break;
            case '^':
                Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, a ^ b);
                Console.WriteLine(Convert.ToString(a ^ b, 2));
                Console.WriteLine("{0:X}", a ^ b);
                break;
            default:
                Console.WriteLine("Wrong sign");
                break;
        }

    }
  
}