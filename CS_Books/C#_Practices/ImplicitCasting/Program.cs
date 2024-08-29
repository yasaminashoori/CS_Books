namespace ImplicitCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            int b;
            b = a;
            Console.WriteLine($"{a} {b}");
            Console.ReadKey();      
        }
    }
}
