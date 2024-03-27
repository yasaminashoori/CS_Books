namespace Other_Conversion_Mechanisms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Convert
            double d = 3.9;
            int i = Convert.ToInt32(d);
            Console.WriteLine(i);

            int thirty = Convert.ToInt32("1E", 16);    // Parse in hexadecimal
            uint five = Convert.ToUInt32("101", 2);    // Parse in binary

            Console.WriteLine(thirty);
            Console.WriteLine(five);

            // Dynamic conversions:

            Type targetType = typeof(int);
            object source = "42";

            object result = Convert.ChangeType(source, targetType);

            Console.WriteLine(result);             // 42
            Console.WriteLine(result.GetType());   // System.Int32

            // Base-64 conversions:

            Console.WriteLine(Convert.ToBase64String(new byte[] { 123, 5, 33, 210 }));
            Console.WriteLine(Convert.FromBase64String("ewUh0g==")); 
            #endregion

        }
    }
}
