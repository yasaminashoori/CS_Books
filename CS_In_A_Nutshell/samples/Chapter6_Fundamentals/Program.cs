using Microsoft.VisualBasic;
using System.Globalization;
using System.Text;

namespace Chapter6_Fundamentals_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // char literals:
            #region char literals
            char c = 'A';
            char newLine = '\n';

            // System.Char defines a range of static methods for working with characters:
            Console.WriteLine(char.ToUpper('c'));               // C
            Console.WriteLine(char.IsWhiteSpace('\t'));     // True
            Console.WriteLine(char.IsLetter('x'));          // True
            Console.WriteLine(char.GetUnicodeCategory('x'));    // LowercaseLetter 
            #endregion

            Console.WriteLine("****************************************************");
            //end user’s locale
            #region enduser's-locale
            // ToUpper and ToLower honor the end-user’s locale, which can lead to subtle bugs.
            // This applies to both char and string.
            // To illustrate, let's pretend we live in Turkey:
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");

            // The following expression evaluates to false:
            Console.WriteLine(char.ToUpper('i') == 'I');

            // Let's see why:
            Console.WriteLine(char.ToUpper('i'));   // İ

            // In contrast, the *Invariant methods always apply the same culture:
            Console.WriteLine(char.ToUpperInvariant('i'));          // I
            Console.WriteLine(char.ToUpperInvariant('i') == 'I');		// True
            Console.WriteLine(char.ToUpper('i', CultureInfo.InvariantCulture)); //shortcut of the top code 
            #endregion

            //UnicodeCategory

            Console.WriteLine("****************************************************");
            // Example character outside the allocated Unicode set
            #region Test
            int invalidCharCode = 0xFFFF + 1; // Beyond the BMP (Basic Multilingual Plane)
            char invalidChar = (char)invalidCharCode;

            // Test the validity of the character
            UnicodeCategory category = char.GetUnicodeCategory(invalidChar);

            // Check if the character is invalid
            if (category == UnicodeCategory.OtherNotAssigned)
            {
                Console.WriteLine($"Character '{invalidChar}' is invalid.");
                // if the result is UnicodeCategory.OtherNotAssigned, the character is invalid.
            }
            else
            {
                Console.WriteLine($"Character '{invalidChar}' is valid.");
            }
            #endregion

            Console.WriteLine("****************************************************");
            // granular categorization
            #region Categorization

            char character = 'A';

            // Check if the character is a letter
            bool isLetter = char.IsLetter(character);
            Console.WriteLine($"Is '{character}' a letter? {isLetter}");

            // Check if the character is uppercase
            bool isUpper = char.IsUpper(character);
            Console.WriteLine($"Is '{character}' uppercase? {isUpper}");

            // Check if the character is a digit
            bool isDigit = char.IsDigit(character);
            Console.WriteLine($"Is '{character}' a digit? {isDigit}");

            // Check if the character is a whitespace
            bool isWhiteSpace = char.IsWhiteSpace(' ');
            Console.WriteLine($"Is '{character}' a whitespace? {isWhiteSpace}");

            // Check if the character is a punctuation symbol
            bool isPunctuation = char.IsPunctuation('.');
            Console.WriteLine($"Is '{character}' a punctuation symbol? {isPunctuation}");

            // Check if the character is a symbol
            bool isSymbol = char.IsSymbol('+');
            Console.WriteLine($"Is '{character}' a symbol? {isSymbol}");

            // Check if the character is a control character
            bool isControl = char.IsControl('\n');
            Console.WriteLine($"Is '{character}' a control character? {isControl}");
            #endregion


            Console.WriteLine("****************************************************");
            //Strings
            #region Constructing strings
            // String literals:
            string s1 = "Hello";
            string s2 = "First Line\r\nSecond Line";
            string s3 = @"\\server\fileshare\helloworld.cs";

            // To create a repeating sequence of characters you can use string’s constructor:
            Console.Write(new string('#', 10));    // ##########

            // You can also construct a string from a char array. ToCharArray does the reverse:
            char[] ca = "Hello".ToCharArray();
            string s = new string(ca);              // s = "Hello"
            Console.WriteLine(s);

            #endregion

            ////various (unsafe) pointer types like char*
            //var ch = 'b';
            //var ch2 = '*';

            //unsafe
            //{
            //    char c = 'c';
            //    char* p = &c;
            //    var s = new string(p);
            //}

            Console.WriteLine("*********************PADRIGHT");
            Console.WriteLine("12345".PadRight(9, '*'));
            //var str = new string(ch *);

            Console.WriteLine("****************************************************");
            #region Null and empty strings

            // An empty string has a length of zero:
            string empty = "";
            Console.WriteLine(empty == "");              // True
            Console.WriteLine(empty == string.Empty);    // True
            Console.WriteLine(empty.Length == 0);        // True

            //Because strings are reference types, they can also be null:
            string nullString = null;
            Console.WriteLine(nullString == null);        // True
            Console.WriteLine(nullString == "");          // False
            Console.WriteLine(string.IsNullOrEmpty(nullString));    // True
            //Console.WriteLine(nullString.Length == 0);             // NullReferenceException

            #endregion

            Console.WriteLine("****************************************************");
            #region Accessing characters within a string

            string str = "abcde";
            char letter = str[1];        // letter == 'b'

            // string also implements IEnumerable<char>, so you can foreach over its characters:
            foreach (char ch in "123") Console.Write(ch + ",");    // 1,2,3,

            #endregion

            Console.WriteLine("****************************************************");
            #region Searching within strings
            // The simplest search methods are Contains, StartsWith, and EndsWith:
            Console.WriteLine("quick brown fox".Contains("brown"));    // True
            Console.WriteLine("quick brown fox".EndsWith("fox"));      // True
            Console.WriteLine("quick brown fox".StartsWith("quick"));  // True
             
            // IndexOf returns the first position of a given character or substring:
            Console.WriteLine("abcde".IndexOf("cd"));   // 2
            Console.WriteLine("abcde".IndexOf("xx"));   // -1

            // IndexOf is overloaded to accept a startPosition StringComparison enum, which enables case-insensitive searches:
            Console.WriteLine("abcde".IndexOf("CD", StringComparison.CurrentCultureIgnoreCase));    // 2

            // LastIndexOf is like IndexOf, but works backward through the string.
            // IndexOfAny returns the first matching position of any one of a set of characters:
            Console.WriteLine("ab,cd ef".IndexOfAny(new char[] { ' ', ',' }));       // 2
            Console.WriteLine("pas5w0rd".IndexOfAny("0123456789".ToCharArray()));  // 3

            // LastIndexOfAny does the same in the reverse direction. 
            #endregion

            Console.WriteLine("****************************************************");
            #region Manipulating strings
            // Because String is immutable, all the methods below return a new string, leaving the original untouched.

            // Substring extracts a portion of a string:
            string left3 = "12345".Substring(0, 3);     // left3 = "123";
            string mid3 = "12345".Substring(1, 3);     // mid3 = "234";

            // If you omit the length, you get the remainder of the string:
            string end3 = "12345".Substring(2);        // end3 = "345";

            // Insert and Remove insert or remove characters at a specified position:
            string str3 = "helloworld".Insert(5, ", ");    // s1 = "hello, world"
            string str4 = str3.Remove(5, 2);                 // s2 = "helloworld";

            // PadLeft and PadRight pad a string to a given length with a specified character (or a space if unspecified):
            Console.WriteLine("12345".PadLeft(9, '*'));  // ****12345
            Console.WriteLine("12345".PadLeft(9));       //     12345

            // TrimStart, TrimEnd and Trim remove specified characters (whitespace, by default) from the string:
            Console.WriteLine("  abc \t\r\n ".Trim().Length);   // 3

            // Replace replaces all occurrences of a particular character or substring:
            Console.WriteLine("to be done".Replace(" ", " | "));  // to | be | done
            Console.WriteLine("to be done".Replace(" ", ""));  // tobedone 
            #endregion

            Console.WriteLine("****************************************************");
            #region Splitting and joining strings
            // Split takes a sentence and returns an array of words (default delimiters = whitespace):
            string[] words = "The quick brown fox".Split();
            Console.WriteLine(words);

            // The static Join method does the reverse of Split:
            string together = string.Join(" ", words);
            Console.WriteLine(together);                                // The quick brown fox

            // The static Concat method accepts only a params string array and applies no separator.
            // This is exactly equivalent to the + operator:
            string sentence = string.Concat("The", " quick", " brown", " fox");
            string sameSentence = "The" + " quick" + " brown" + " fox";

            Console.WriteLine(sameSentence);  // The quick brown fox
            #endregion

            Console.WriteLine("****************************************************");
            #region String.Format and composite format strings

            // When calling String.Format, provide a composite format string followed by each of the embedded variables
            string composite = "It's {0} degrees in {1} on this {2} morning";
            string sFormat = string.Format(composite, 35, "Perth", DateTime.Now.DayOfWeek);
            Console.WriteLine(sFormat);

            // The minimum width in a format string is useful for aligning columns.
            // If the value is negative, the data is left-aligned; otherwise, it’s right-aligned:
            composite = "Name={0,-20} Credit Limit={1,15:C}";

            Console.WriteLine(string.Format(composite, "Mary", 500));
            Console.WriteLine(string.Format(composite, "Elizabeth", 20000));

            // The equivalent without using string.Format:
            sFormat = "Name=" + "Mary".PadRight(20) + " Credit Limit=" + 500.ToString("C").PadLeft(15);
            Console.WriteLine(sFormat);
            #endregion


            Console.WriteLine("****************************************************");
            #region Comparing Strings
            // String comparisons can be ordinal vs culture-sensitive; case-sensitive vs case-insensitive.

            Console.WriteLine(string.Equals("foo", "FOO", StringComparison.OrdinalIgnoreCase));   // True

            // (The following symbols may not be displayed correctly, depending on your font):
            Console.WriteLine("ṻ" == "ǖ");   // False

            // The order comparison methods return a positive number, a negative number, or zero, depending
            // on whether the first value comes after, before, or alongside the second value:
            Console.WriteLine("Boston".CompareTo("Austin"));    // 1
            Console.WriteLine("Boston".CompareTo("Boston"));    // 0
            Console.WriteLine("Boston".CompareTo("Chicago"));   // -1
            Console.WriteLine("ṻ".CompareTo("ǖ"));              // 0
            Console.WriteLine("foo".CompareTo("FOO"));          // -1

            // The following performs a case-insensitive comparison using the current culture:
            Console.WriteLine(string.Compare("foo", "FOO", true));   // 0

            // By supplying a CultureInfo object, you can plug in any alphabet:
            CultureInfo german = CultureInfo.GetCultureInfo("de-DE");
            int i = string.Compare("Müller", "Muller", false, german);
            Console.WriteLine(i); // 1 
            #endregion

            Console.WriteLine("****************************************************");
            #region StringBuilder
            // Unlike string, StringBuilder is mutable.
            // The following is more efficient than repeatedly concatenating ordinary string types:

            StringBuilder sb = new StringBuilder();

            for (int i1 = 0; i1 < 50; i++) sb.Append(i1 + ",");

            // To get the final result, call ToString():
            Console.WriteLine(sb.ToString());

            sb.Remove(0, 60);       // Remove first 50 characters
            sb.Length = 10;         // Truncate to 10 characters
            sb.Replace(",", "+");   // Replace comma with +
            Console.WriteLine(sb.ToString());

            sb.Length = 0;          // Clear StringBuilder 
            #endregion

            Console.WriteLine("****************************************************");
            #region Text Encodings and Unicode
            Console.WriteLine(Encoding.UTF8);

            // Call Encoding.GetEncoding with a standard IANA name to obtain an encoding:
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding chinese = Encoding.GetEncoding("GB18030");
            Console.WriteLine(chinese);

            // The static GetEncodings method returns a list of all supported encodings:
            foreach (EncodingInfo info in Encoding.GetEncodings())
                Console.WriteLine(info.Name);
            #endregion

            Console.WriteLine("****************************************************");
            #region Encoding to Byte Arrays

            byte[] utf8Bytes = System.Text.Encoding.UTF8.GetBytes("0123456789");
            byte[] utf16Bytes = System.Text.Encoding.Unicode.GetBytes("0123456789");
            byte[] utf32Bytes = System.Text.Encoding.UTF32.GetBytes("0123456789");

            Console.WriteLine(utf8Bytes.Length);    // 10
            Console.WriteLine(utf16Bytes.Length);   // 20
            Console.WriteLine(utf32Bytes.Length);   // 40

            string original1 = System.Text.Encoding.UTF8.GetString(utf8Bytes);
            string original2 = System.Text.Encoding.Unicode.GetString(utf16Bytes);
            string original3 = System.Text.Encoding.UTF32.GetString(utf32Bytes);

            Console.WriteLine(original1);          // 0123456789
            Console.WriteLine(original2);          // 0123456789
            Console.WriteLine(original3);          // 0123456789 
            #endregion

            Console.WriteLine("****************************************************");
            #region UTF-16 and SurrogatePairs
            int musicalNote = 0x1D161;

            string sUTF = char.ConvertFromUtf32(musicalNote);
            Console.WriteLine(sUTF.Length);  // 2 (surrogate pair)

            Console.WriteLine(char.ConvertToUtf32(s, 0).ToString("X"));   // Consumes two chars
            Console.WriteLine(char.ConvertToUtf32(s[0], s[1]).ToString("X"));   // Explicitly specify two chars 
            #endregion

            // ToUpper and ToLower honor the end-user’s locale, which can lead to subtle bugs.
            // This applies to both char and string.

            // To illustrate, let's pretend we live in Turkey:
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");

            // The following expression evaluates to false:
            Console.WriteLine(char.ToUpper('i') == 'I');

            // Let's see why:
            Console.WriteLine(char.ToUpper('i'));   // İ

            // In contrast, the *Invariant methods always apply the same culture:
            Console.WriteLine(char.ToUpperInvariant('i'));          // I
            Console.WriteLine(char.ToUpperInvariant('i') == 'I');		// True

        }
    }
}
