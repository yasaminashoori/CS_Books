namespace InRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //internal API in EF: used so much form in and out 
            // in: input (ref) is readonly form. and Immutable, cant assign to it.
            // out: output (ref) in Write form. should change and modify the inout and wirte something and assign to it.
            //C++: pointer was so much to manage.

            // not remove from stack 

            AddOne(out int c);
            Console.WriteLine(c);

            int a = 9;
            WriteOne(in a);
        }

        public static int AddOne(out int number)
        {
            number = 1;
            return number;
        }
        public static void WriteOne(in int number)
        {
            Console.WriteLine(number);
        }
    }
}
