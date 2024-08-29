namespace Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();

            bool B = int.TryParse(s, out int n);

            if (B)
                Console.WriteLine(n);
            else Console.WriteLine("fail");

        }
    }
}
