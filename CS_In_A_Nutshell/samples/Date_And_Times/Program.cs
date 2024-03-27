namespace Date_And_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Date and Times: The following immutable structs in the System namespace do the job of representing
            dates and times:
            DateTime, DateTimeOffset, TimeSpan, DateOnly, TimeOnly
            C# doesn’t define any special keywords that map to these types
            */

            #region TimeSpan
            // There are three ways to construct a TimeSpan:
            //  • Through one of the constructors
            //  • By calling one of the static From . . . methods
            //  • By subtracting one DateTime from another

            //constructors:
            /*public TimeSpan (int hours, int minutes, int seconds);
            public TimeSpan (int days, int hours, int minutes, int seconds);
            public TimeSpan (int days, int hours, int minutes, int seconds,
            int milliseconds);
            public TimeSpan (int days, int hours, int minutes, int seconds,
            int milliseconds, int microseconds);
            public TimeSpan (long ticks); // Each tick = 100ns
            */

            Console.WriteLine(new TimeSpan(2, 30, 0));     // 02:30:00
            Console.WriteLine(TimeSpan.FromHours(2.5));    // 02:30:00
            Console.WriteLine(TimeSpan.FromHours(-2.5));   // -02:30:00
            Console.WriteLine(DateTime.MaxValue - DateTime.MinValue);

            // TimeSpan overloads the < and > operators, as well as the + and - operators:

            Console.WriteLine("2.5 hours");
            var hours = (TimeSpan.FromHours(2) + TimeSpan.FromMinutes(30));

            Console.WriteLine("One second short of 10 days");
            var days = (TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1));
            #endregion

            #region TimeSpan Properites
            TimeSpan nearlyTenDays = TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1);

            // The following properties are all of type int:

            Console.WriteLine(nearlyTenDays.Days);          // 9
            Console.WriteLine(nearlyTenDays.Hours);         // 23
            Console.WriteLine(nearlyTenDays.Minutes);       // 59
            Console.WriteLine(nearlyTenDays.Seconds);       // 59
            Console.WriteLine(nearlyTenDays.Milliseconds);  // 0

            // In contrast, the Total... properties return values of type double describing the entire time span:

            Console.WriteLine();
            Console.WriteLine(nearlyTenDays.TotalDays);          // 9.99998842592593
            Console.WriteLine(nearlyTenDays.TotalHours);         // 239.999722222222
            Console.WriteLine(nearlyTenDays.TotalMinutes);       // 14399.9833333333
            Console.WriteLine(nearlyTenDays.TotalSeconds);       // 863999
            Console.WriteLine(nearlyTenDays.TotalMilliseconds);  // 863999000 
            #endregion
        }
    }
}
