class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Divide(double a, double b)
    {
        if(b==0)
        {
            Console.WriteLine("Cannot divide by zero");
            return 0;
        }
        return a / b;
    }
}
class Program
{
    static void Main()
    {
        Calculator c= new Calculator();
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        
        Console.Write("Enter your choice(1-4): ");
        int choice=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter first number: ");
        double num1= Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2= Convert.ToDouble(Console.ReadLine());
        
        double result;
        switch (choice)
        {
            case 1:
                result= c.Add(num1, num2);
                break;

            case 2:
                result = c.Subtract(num1, num2);
                break;

            case 3:
                result = c.Multiply(num1, num2);
                break;

            case 4:
                result = c.Divide(num1, num2);
                break;

            default:
                Console.WriteLine("Invalid choice");
                return;
        }
        Console.WriteLine("Output= " + result);
    }
}
