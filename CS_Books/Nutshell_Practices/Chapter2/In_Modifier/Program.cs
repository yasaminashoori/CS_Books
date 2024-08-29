using System.Threading.Channels;

namespace In_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {


            void Foo(SomeBigStruct a) => Console.WriteLine("Foo");
            //void Foo(in SomeBigStruct a) => Console.WriteLine("in Foo");
            void Bar(in SomeBigStruct a) => Console.WriteLine("in Bar");
        }
    }
    struct SomeBigStruct
    {
        public decimal A, B, C, D, E, F, G;
    }
}
