namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Three ways to create a Tuple:
            #region Tuples
            var t1 = new Tuple<int, string>(123, "Hello");
            Tuple<int, string> t2 = Tuple.Create(123, "Hello");
            var t3 = Tuple.Create(123, "Hello");

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine(t1.Item1 * 2);         // 246
            Console.WriteLine(t1.Item2.ToUpper());   // HELLO

            // The alternative sacrafices static type safety and causes boxing with value types:

            object[] items = { 123, "Hello" };
            Console.WriteLine(((int)items[0]) * 2);   // 246
            Console.WriteLine(((string)items[1]).ToUpper());   // HELLO 
            #endregion

            #region Comparing Tuples
            var tu1 = Tuple.Create(123, "Hello");
            var tu2 = Tuple.Create(123, "Hello");

            Console.WriteLine(tu1 == tu2);           // False
            Console.WriteLine(tu1.Equals(tu2));     // True 
            #endregion

            var r1 = new Random(DateTime.Now.Millisecond);
            var r2 = new Random(DateTime.Now.Millisecond);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.BackgroundColor= ConsoleColor.Yellow;
        }
    }
}
