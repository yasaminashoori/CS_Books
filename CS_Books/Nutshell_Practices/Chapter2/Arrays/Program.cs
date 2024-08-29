namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array initialization expression
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            // simpler 
            char[] vowels2 = { 'a', 'e', 'i', 'o', 'u' };

            // in C# 12: collection expression
            char[] vowels3 = ['a', 'e', 'i', 'o', 'u'];

            // the elements have default value
            int[] a = new int[1000];
            Console.Write(a[123]);    // 0

            //ineseeson -  



            // All array indexing is bounds-checked by the runtime:

            int[] arr = new int[3];
            arr[3] = 1;               // IndexOutOfRangeException thrown


        }
    }
}
