namespace Null_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>? numbers = null;
            int? a = null;

            Console.WriteLine((numbers is null)); // expected: true
                                                  // if numbers is null, initialize it. Then, add 5 to numbers
            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5
            Console.WriteLine((numbers is null)); // expected: false        

            Console.WriteLine((a is null)); // expected: true
            Console.WriteLine((a ?? 3)); // expected: 3 since a is still null 
                                         // if a is null then assign 0 to a and add a to the list
            numbers.Add(a ??= 0);
            Console.WriteLine((a is null)); // expected: false        
            Console.WriteLine(string.Join(" ", numbers));  // output: 5 0
            Console.WriteLine(a);  // output: 0

            // another example: null coalescing operator
            #region  null coalescing operator
            string s1 = null;
            string s2 = s1 ?? "nothing";   // s2 evaluates to "nothing"
            Console.WriteLine(s2); 
            #endregion

            //  null coalescing assignment operator
            #region null coalescing assignment operator
            string s3 = null;
            s3 ??= "something";
            Console.WriteLine(s3);  // something

            s3 ??= "everything";
            Console.WriteLine(s3);  // something 
            #endregion

            // null conditional operator
            #region null conditional operator
            System.Text.StringBuilder sb = null;
            string s = sb?.ToString();   // No error; s instead evaluates to null
            Console.WriteLine(s);

            string s4 = sb?.ToString().ToUpper();   // s evaluates to null without error
            Console.WriteLine(s4);

            string[] words = null;
            string word = words?[1];   // word is null 
            #endregion

            #region Non-Conditional operator with nullable types
            System.Text.StringBuilder sb2 = null;
            int? length = sb2?.ToString().Length;   // OK : int? can be null

            Console.WriteLine(length);

            string s5 = sb2?.ToString() ?? "nothing";   // s evaluates to "nothing"
            Console.WriteLine(s5);
            #endregion

            Console.ReadKey();  
        }
    }
}
