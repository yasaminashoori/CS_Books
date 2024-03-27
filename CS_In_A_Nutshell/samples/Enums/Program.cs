using System.Drawing;

namespace Enums
{
    internal class Program
    {
        #region Enum Type Unification

        //Type Unification
        static void Main(string[] args)
        {
            Display(Nut.Macadamia);     // Nut.Macadamia
            Display(Size.Large);        // Size.Large
        }

        //Type Unification
        enum Nut { Walnut, Hazelnut, Macadamia }
        enum Size { Small, Medium, Large }

        //Type Unification
        static void Display(Enum value)     // The Enum type unifies all enums
        {
            Console.WriteLine(value.GetType().Name + "." + value.ToString());
        } 
        #endregion
    }

}
