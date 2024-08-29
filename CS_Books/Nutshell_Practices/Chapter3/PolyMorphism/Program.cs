namespace PolyMorphism
{
    /// <summary>
    /// References are polymorphism
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // A variable of type x can refer to an object that subclasses x.

            // The Display method below accepts an Asset. This means means we can pass it any subtype:
            Display(new Stock { Name = "MSFT", SharesOwned = 1000 });
            Display(new House { Name = "Mansion", Mortgage = 100000 });

            void Display(Asset asset)
            {
                Console.WriteLine(asset.Name);
            }
        }

    }
    public class Asset
    {
        public string Name;
    }

    public class Stock : Asset   // inherits from Asset
    {
        public long SharesOwned;
    }

    public class House : Asset   // inherits from Asset
    {
        public decimal Mortgage;
    }
}

/* in this example we have kind of polymorphism with Inheritance! we have an Asset class
 * that has two subclass and we can pass to the input of method both of the subclasses.
 */