namespace Equality_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Equality Comparison
            #region Value vs Referential Equality
            // Simple value equality:
            int x = 5, y = 5;
            Console.WriteLine(x == y);   // True (by virtue of value equality)

            // A more elaborate demonstration of value equality:
            var dt1 = new DateTimeOffset(2010, 1, 1, 1, 1, 1, TimeSpan.FromHours(8));
            var dt2 = new DateTimeOffset(2010, 1, 1, 2, 1, 1, TimeSpan.FromHours(9));
            Console.WriteLine(dt1 == dt2);   // True (same point in time)

            // Referential equality:
            Foo f1 = new Foo { X = 5 };
            Foo f2 = new Foo { X = 5 };
            Console.WriteLine(f1 == f2);   // False (different objects)

            Foo f3 = f1;
            Console.WriteLine(f1 == f3);   // True (same objects)

            // Customizing classes to exhibit value equality:
            Uri uri1 = new Uri("http://www.linqpad.net");
            Uri uri2 = new Uri("http://www.linqpad.net");
            Console.WriteLine(uri1 == uri2);              // True 
            #endregion

            #region == and !=
            {
                int x3 = 5;
                int y3 = 5;
                Console.WriteLine(x == y);      // True
            }
            {
                object x3 = 5;
                object y3 = 5;
                Console.WriteLine(x == y);      // False
            }
            #endregion

            #region Virtual Equals Method
            // Here's an example of how we can leverage the virtual Equals mehtod:
            object x4 = 5;
            object y4 = 5;
            Console.WriteLine(x.Equals(y4));      // True

            Console.WriteLine(AreEqual(x4, y4));    // True
            Console.WriteLine(AreEqual(null, null));    // True

            bool AreEqual(object obj1, object obj2)
            {
                if (obj1 == null) return obj2 == null;
                return obj1.Equals(obj2);
                // What we've written is in fact equivalent to the static object.Equals method!
            }
            #endregion

            #region Static Equlas Method
            // Here's how we can use object.Equals:
            object x5 = 3, y5 = 3;
            Console.WriteLine(object.Equals(x5, y5));   // True
            x5 = null;
            Console.WriteLine(object.Equals(x5, y5));   // False
            y5 = null;
            Console.WriteLine(object.Equals(x5, y5));   // True 
            #endregion



        }
    }

    //Value vs Referential Equality
    class Foo { public int X; }

    //Static Equals method
    class Test<T>
    {
        T _value;
        public void SetValue(T newValue)
        {
            if (!object.Equals(newValue, _value))
            {
                _value = newValue;
                OnValueChanged();
            }
        }

        protected virtual void OnValueChanged() { /*...*/ }
    }

}
