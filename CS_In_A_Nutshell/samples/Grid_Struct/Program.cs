using System.Collections.Concurrent;

namespace Grid_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * The Guid struct represents a globally unique identifier: a 16-byte value that, when
             * generated, is almost certainly unique in the world. Guids are often used for keys of
             * various sorts, in applications and databases
             */
            #region Grid
            Guid g = Guid.NewGuid();
            Console.WriteLine("Guid.NewGuid.ToString()");
            Console.WriteLine(g.ToString());

            Guid g1 = new Guid("{0d57629c-7d6e-4847-97cb-9e2fc25083fe}");
            Guid g2 = new Guid("0d57629c7d6e484797cb9e2fc25083fe");
            Console.WriteLine(g1 == g2);  // True

            byte[] bytes = g.ToByteArray();
            Guid g3 = new Guid(bytes);
            Console.WriteLine(g3);

            Console.WriteLine("Guid.Empty");
            Console.WriteLine(Guid.Empty);
            Console.WriteLine("default(Guid)");
            Console.WriteLine(default(Guid));
            Console.WriteLine("Guid.Empty - bytes");
            Console.WriteLine(Guid.Empty.ToByteArray()); 
            #endregion

        }
    }
}
