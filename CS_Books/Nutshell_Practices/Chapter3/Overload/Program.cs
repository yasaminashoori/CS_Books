namespace Overload
{
    internal class Program
    {
        void Main(string[] args) //remove static 
        {
            Foo(123);           // int
            Foo(123.0);     // double
            Foo(123, 123F); // int, float
            Foo(123F, 123);	// float, int
        }


        // We can overload Foo as follows:
        void Foo(int x) { Console.WriteLine("int"); }
        void Foo(double x) { Console.WriteLine("double"); }
        void Foo(int x, float y) { Console.WriteLine("int, float"); }
        void Foo(float x, int y) { Console.WriteLine("flaot, int"); }

        // We have to use a Main() method here to test this,
        // because methods in top-level statements are *local methods*
        // which cannot be overloaded.
    }
}
