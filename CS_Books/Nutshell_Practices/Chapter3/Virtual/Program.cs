namespace Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Foo(Asset a) { Console.WriteLine("Foo Asset"); ; }
            //static void Foo(House h) { Console.WriteLine("Foo House"); ; }

            Foo(new House());      // Calls Foo (House)

            Asset a = new House();
            Foo(a);                // Calls Foo (Asset)
        }
    }

    // When calling an overload method, the method with the most specific 
    // parameter type match has precedence, based on the *compile-time* variable type:
    public class Asset
    {
        public string Name;
    }

    public class Stock : Asset   // inherits from Asset
    {
        public long SharesOwned;
    }

    public class House : Asset   // inherits from Asset
    {
        public decimal Mortgage;
    }
}
