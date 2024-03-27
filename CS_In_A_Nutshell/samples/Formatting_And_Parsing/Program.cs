using System.Globalization;

namespace Formatting_And_Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Formatting means converting to a string;
             parsing means converting from a string.
             The need to format or parse arises frequently in programming, in a variety of
             situations. Hence, .NET provides a variety of mechanisms.
            */

            #region ToString and Parse
            // The simplest formatting mechanism is the ToString method.
            string s = true.ToString();
            Console.WriteLine(s);

            // Parse does the reverse:
            bool b = bool.Parse(s);
            Console.WriteLine(b);

            // TryParse avoids a FormatException in case of error:
            int i;
            Console.WriteLine("Successful");
            Console.WriteLine(int.TryParse("qwerty", out i));
            Console.WriteLine("Successful");
            Console.WriteLine(int.TryParse("123", out i));

            if (int.TryParse("123", out int j))
            {
                Console.WriteLine("Use j");
                Console.WriteLine(j);
            }

            bool validInt = int.TryParse("123", out int _);
            Console.WriteLine("We don't care about the actual value so use discard.");
            Console.WriteLine(validInt);

            // Culture trap:
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");  // Germany
            Console.WriteLine("Parsing 1.234");  // 1234 
            Console.WriteLine(double.Parse("1.234"));

            // Specifying invariant culture fixes this:
            Console.WriteLine(double.Parse("1.234", CultureInfo.InvariantCulture));
            Console.WriteLine("Parsing 1.234 Invariantly");

            Console.WriteLine("1.234.ToString()");
            Console.WriteLine((1.234).ToString());
            Console.WriteLine("1.234.ToString Invariant");
            Console.WriteLine((1.234).ToString(CultureInfo.InvariantCulture)); 
            #endregion


        }
    }
}
