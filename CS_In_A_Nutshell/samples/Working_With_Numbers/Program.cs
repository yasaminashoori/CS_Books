using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;

namespace Working_With_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BigInteger
            // BigInteger supports arbitrary precision.

            BigInteger twentyFive = 25;      // implicit cast from integer

            BigInteger googol = BigInteger.Pow(10, 100);

            // Alternatively, you can Parse a string: 
            BigInteger googolFromString = BigInteger.Parse("1".PadRight(101, '0'));

            Console.WriteLine(googol.ToString());

            double g1 = 1e100;                  // implicit cast
            BigInteger g2 = (BigInteger)g1;    // explicit cast
            Console.WriteLine("Note loss of precision");
            Console.WriteLine(g2);

            // This uses the System.Security.Cryptography namespace:
            RandomNumberGenerator rand = RandomNumberGenerator.Create();
            byte[] bytes = new byte[32];
            rand.GetBytes(bytes);
            var bigRandomNumber = new BigInteger(bytes);   // Convert to BigInteger
            Console.WriteLine("Big random number");
            Console.WriteLine(bigRandomNumber);
            #endregion

            #region Random
            // If given the same seed, the random number series will be the same:
            Random r1 = new Random(1);
            Random r2 = new Random(1);
            Console.WriteLine(r1.Next(100) + ", " + r1.Next(100));      // 24, 11
            Console.WriteLine(r2.Next(100) + ", " + r2.Next(100));      // 24, 11

            // Using system clock for seed:
            Random r3 = new Random();
            Random r4 = new Random();
            Console.WriteLine(r3.Next(100) + ", " + r3.Next(100));      // ?, ?
            Console.WriteLine(r4.Next(100) + ", " + r4.Next(100));      // ", "
                                                                        // Notice we still get same sequences, because of limitations in system clock resolution.

            // Here's a workaround:
            Random r5 = new Random(Guid.NewGuid().GetHashCode());
            Random r6 = new Random(Guid.NewGuid().GetHashCode());
            Console.WriteLine(r5.Next(100) + ", " + r5.Next(100));      // ?, ?
            Console.WriteLine(r6.Next(100) + ", " + r6.Next(100));      // ?, ?

            // From .NET 8, the Random class includes a GetItems method, which picks n random items from a collection.
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Two random Items");
            int[] randomTwo = new Random().GetItems(numbers, 2);

            // Shuffle (also new to .NET 8) shuffles items in an array:
            new Random().Shuffle(numbers);
            Console.WriteLine("All shuffled!");
            Console.WriteLine(numbers);

            // Random is not crytographically strong (the following, however, is):
            var rand2 = System.Security.Cryptography.RandomNumberGenerator.Create();
            byte[] bytes2 = new byte[4];
            rand2.GetBytes(bytes2);       // Fill the byte array with random numbers.

            Console.WriteLine("A cryptographically strong random integer");
            BitConverter.ToInt32(bytes2, 0);
            #endregion
        
            //Calender
            var pc = new PersianCalendar();

            DateTime now = DateTime.Now;
            DateTime dt = new DateTime(1434, 11, 23, pc);

            //Random
            var r1 = new Random(1);
            var r2 = new Random(1);

            Console.WriteLine(r2.NextInt64());
            Console.WriteLine(r1.NextInt64());

        }

    }
}
