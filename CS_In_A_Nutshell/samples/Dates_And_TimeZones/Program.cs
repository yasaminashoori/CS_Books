namespace Dates_And_TimeZones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DateTime and Time Zones
            // When you compare two DateTime instances, only their ticks values are compared; their DateTimeKinds are ignored:

            DateTime dt1 = new DateTime(2000, 1, 1, 10, 20, 30, DateTimeKind.Local);
            DateTime dt2 = new DateTime(2000, 1, 1, 10, 20, 30, DateTimeKind.Utc);
            Console.WriteLine(dt1 == dt2);          // True

            DateTime local = DateTime.Now;
            DateTime utc = local.ToUniversalTime();
            Console.WriteLine(local == utc);        // False

            // You can construct a DateTime that differs from another only in Kind with the static DateTime.SpecifyKind method:

            DateTime d = new DateTime(2000, 12, 12);  // Unspecified
            DateTime utc2 = DateTime.SpecifyKind(d, DateTimeKind.Utc);
            Console.WriteLine(utc2);            // 12/12/2000 12:00:00 AM 
            #endregion

            #region DateTimeOffset and Time Zones
            // Comparisons look only at the (UTC) DateTime; the Offset is used primarily for formatting.

            DateTimeOffset local3 = DateTimeOffset.Now;
            DateTimeOffset utc3 = local.ToUniversalTime();

            Console.WriteLine(local3.Offset);   // -06:00:00 (in Central America)
            Console.WriteLine(utc3.Offset);     // 00:00:00

            Console.WriteLine(local == utc);                 // True

            //To include the Offset in the comparison, you must use the EqualsExact method:

            Console.WriteLine(local3.EqualsExact(utc3));      // False 
            #endregion
        }
    }
}
