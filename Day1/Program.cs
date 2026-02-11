class Program
{

    static int sum()
    { 
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());   
        int c = a + b; 
        return c;
    }

    static int diff(int a, int b)
    {
        int d = a - b;
        return d;
    }
   
    public static void Main()
    {
        int result = sum();
        Console.WriteLine("The sum of 2 numbers is " + result);

        Console.WriteLine("The difference is: " + diff(400, 200));
    }
    
    
}

