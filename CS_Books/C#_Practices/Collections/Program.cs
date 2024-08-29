using System.Collections;
using System.Reflection;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // BCL: collections 
            //WCF = > map to what collection? a simple kind of set is an array 

            // a simple pattern for a collection and traverse inside it 
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i);
            }


           
        }
        public interface IEnummerator
        {
            object Current { get; }

            bool MoveNext();

            void Reset();
        }
        public interface IEnumerator<out T> : IEnumerator, IDisposable
        {
            T Current { get; }
        }

        public interface IDisposable
        {
            void Dispose();
        }

        public interface IEnumerable<out T> : IEnumerable // the low level protocol: no add, remove and etc just iterate.
        {
            IEnumerator<T> GetEnumerator();
        }

        // count and copyto metohds
        public interface ICollection : IEnumerable
        {
            int Count { get; }
            bool IsSynchronized { get; }

            object SyncRoot { get; }
            void CopyTo(Array array, int index);
        }

        // add, remove and ... 
        // inherited form ICollection
        public interface IList : ICollection, IEnumerable
        {
            // in IEnummerable we hadnt random access we should traverse till the end to find the
            // index 5 for example but now we have random access
            object? this[int index] { get; set; } // random access
      
            bool IsFixedSize { get; }
           
            bool IsReadOnly { get; }
            int Add(object? value); // add to the end of the array 
           
            void Clear();
           
            bool Contains(object? value);
          
            int IndexOf(object? value);
           
            void Insert(int index, object? value); // add anywhere in the middle we want 
            void Remove(object? value);
            void RemoveAt(int index);
        }
    }
}
