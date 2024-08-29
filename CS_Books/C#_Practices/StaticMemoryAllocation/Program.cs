namespace StaticMemoryAllocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instance method vs class method 

            User user1 = new User();
            user1.GetOld();

            User2.GetOld();
        }

        public class User
        {
            //instance method: stores in the heap with the metadate especialized for each object.
            public int GetOld() { return 1; }
        }

        public class User2
        {
        //class method : in HFH stores withits class and metadata. 
        // in multithread we should use carefully! it may be change.
            public static int GetOld() { return 1; }
        }
    }
}
