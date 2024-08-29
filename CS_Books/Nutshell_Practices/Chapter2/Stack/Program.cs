namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person a = new();
            a.name = "Arash";
            Person b = new();
            a = b;
            a.name = "Amir";
            Console.WriteLine(a.name);
            Console.WriteLine(b.name);
        }
    }

    public class Person
    {
        public string name { get; set; }
    }
}
