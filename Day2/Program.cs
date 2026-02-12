class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        
        s.SetName(name);
        Console.WriteLine(s.GetName());
    }
}

class Solution
{
    public string name { get; set; }

    public void  SetName(String name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }
}