namespace DelegatePart3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggingDelegate logging = LogToDb;
            Action<string> logging2 = LogToDb;
            var logging3 = LogToDb;

            //MulticastDelegate 
            logging += LogToFile;

            logging("Hello World");
            logging.Invoke("Hello with invoke");
        }

        public delegate void LoggingDelegate(string message);

        static void LogToDb(string message) { Console.WriteLine($" Log to db with {message} data"); }
        static void LogToFile(string message) { Console.WriteLine(); }
    }
}
