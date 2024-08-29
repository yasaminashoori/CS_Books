namespace BooleanOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // == and != test for equality and inequality of any type, but always return a bool value
            // (unless overloaded otherwise). Value types typically have a very simple notion of equality:
            int x = 1;
            int y = 2;
            int z = 1;

            Console.WriteLine(x == y);      // False
            Console.WriteLine(x != y);      // True
            Console.WriteLine(x == z);      // True

            Console.WriteLine(x < y);       // True
            Console.WriteLine(x >= z);		// True

            //Equality with references 
            Dude d1 = new Dude("John");
            Dude d2 = new Dude("John");
            Console.WriteLine(d1 == d2);       // False
            Dude d3 = d1;
            Console.WriteLine(d1 == d3);       // True


            // The && and || operators test for and and or conditions. They are frequently used in
            // conjunction with the ! operator, which expresses not:

            Console.WriteLine(UseUmbrella(true, false, false)); // True
            Console.WriteLine(UseUmbrella(true, true, true)); // False

            bool UseUmbrella(bool rainy, bool sunny, bool windy)
            {
                return !windy && (rainy || sunny);
            }

        }
    }
    public class Dude
    {
        public string Name;
        public Dude(string n) { Name = n; }
    }
}
