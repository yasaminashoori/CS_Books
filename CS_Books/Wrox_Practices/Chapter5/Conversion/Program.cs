namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Casting <destinationType>)<sourceVar> : not conversion or anything else this is the syntax for casting 


            // this is the unchecked code with overflow, unchecked is default one 
            byte destinationVar;
            short sourceVar = 281;
            destinationVar = (byte)sourceVar;
            Console.WriteLine($"sourceVar val: {sourceVar}");
            Console.WriteLine($"destinationVar val: {destinationVar}");

            // this is the checked code and error of overflow
            byte destinationVar2;
            short sourceVar2 = 281;
            destinationVar2 = checked((byte)sourceVar2);
            Console.WriteLine($"sourceVar val: {sourceVar2}");
            Console.WriteLine($"destinationVar val: {destinationVar2}");



            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;
            Console.WriteLine("Variable Conversion Examples\n");
            doubleResult = floatVal * shortVal;
            Console.WriteLine($"Implicit, -> double: {floatVal} * {shortVal} -> { doubleResult }"); 
            shortResult = (short)floatVal;
            Console.WriteLine($"Explicit, -> short: {floatVal} -> {shortResult}");
            stringResult = Convert.ToString(boolVal) +
            Convert.ToString(doubleVal);
            Console.WriteLine($"Explicit, -> string: \"{boolVal}\" + \"{doubleVal}\" -> " +
            $"{stringResult}");
            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine($"Mixed, -> long: {integerVal} + {stringVal} -> { longResult}"); 

            Console.ReadKey();          

        }
    }
}
