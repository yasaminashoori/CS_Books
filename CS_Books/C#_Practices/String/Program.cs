namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // thread safe => cant chane it, immuatable 
            // password dont get in the plain way! trojan can search for memory 
            // stringBuilder: if we work with for and Append, concat so use from this. its better than interpolation
            //string builder gets a whole Store and dont get refernce each time 
            // ToUpper is the same to and make a new one and get refernce
            // array has a char structure cause has Range and Index Methods (array metohds).

            // interning: two variables with the same value 
            // strings: Private Heap: LOH (strings, has an intern part), SOH 
        }
    }
}
