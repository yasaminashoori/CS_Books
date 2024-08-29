namespace Readonly_Field
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new ReadOnlyInitial();
            Console.WriteLine(obj1.MyField);
            var obj2 = new ReadOnlyCtor(2);
        }

        public class ReadOnlyInitial
        {
            public readonly int MyField = 10;
        }

        public class ReadOnlyCtor
        {
            public readonly int FieldCtor;

            public ReadOnlyCtor(int initialValue)
            {
                FieldCtor = initialValue;
            }
        }

    }
}
