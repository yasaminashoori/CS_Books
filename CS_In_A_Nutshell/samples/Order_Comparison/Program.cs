namespace Order_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Order Comparison
            #region Order Comparisons
            // The static Array.Sort method works because System.String implements the IComparable interfaces:
            string[] colors = { "Green", "Red", "Blue" };
            Array.Sort(colors);
            foreach (string c in colors) Console.Write(c + " ");   // Blue Green Red

            //IComparable
            // The IComparable interfaces are defined as follows:
            //   public interface IComparable       { int CompareTo (object other); }
            //   public interface IComparable<in T> { int CompareTo (T other);      }

            Console.WriteLine("Beck".CompareTo("Anne"));       // 1
            Console.WriteLine("Beck".CompareTo("Beck"));       // 0
            Console.WriteLine("Beck".CompareTo("Chris"));      // -1

            //LessThan and GreateerThan opertaors
            // Some types define < and > operators:
            bool after2010 = DateTime.Now > new DateTime(2010, 1, 1);

            // The string type doesn't overload these operators (for good reason):
            //bool error = "Beck" > "Anne";       // Compile-time er


            //Customizing Order Comparisons
            Note n1 = new Note(1);
            Note n2 = new Note(2);
            Console.WriteLine(n2 > n1);

            #endregion

        }
    }

    #region Note Order Struct
    //Customizing Order Comparisons
    public struct Note : IComparable<Note>, IEquatable<Note>, IComparable
    {
        int _semitonesFromA;
        public int SemitonesFromA => _semitonesFromA;

        public Note(int semitonesFromA)
        {
            _semitonesFromA = semitonesFromA;
        }

        public int CompareTo(Note other)            // Generic IComparable<T>
        {
            if (Equals(other)) return 0;    // Fail-safe check
            return _semitonesFromA.CompareTo(other._semitonesFromA);
        }

        int IComparable.CompareTo(object other)     // Nongeneric IComparable
        {
            if (!(other is Note))
                throw new InvalidOperationException("CompareTo: Not a note");
            return CompareTo((Note)other);
        }

        public static bool operator <(Note n1, Note n2)
            => n1.CompareTo(n2) < 0;

        public static bool operator >(Note n1, Note n2)
            => n1.CompareTo(n2) > 0;

        public bool Equals(Note other)    // for IEquatable<Note>
            => _semitonesFromA == other._semitonesFromA;

        public override bool Equals(object other)
        {
            if (!(other is Note)) return false;
            return Equals((Note)other);
        }

        public override int GetHashCode()
            => _semitonesFromA.GetHashCode();

        public static bool operator ==(Note n1, Note n2)
            => Equals(n1, n2);

        public static bool operator !=(Note n1, Note n2)
            => !(n1 == n2);
    } 
    #endregion

}


