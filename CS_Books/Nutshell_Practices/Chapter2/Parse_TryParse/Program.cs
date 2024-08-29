namespace Parse_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ab = null;
            int? abc = int.Parse(ab);

            string abcd = null;
            int parsedValue;
            bool success = int.TryParse(abcd, out parsedValue);

        }
    }
}
