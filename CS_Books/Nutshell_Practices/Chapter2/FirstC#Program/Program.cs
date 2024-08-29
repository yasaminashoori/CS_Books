namespace FirstC_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wrox
            // Output text to the screen.
            Console.WriteLine("The first app in Beginning C# and .NET!");
            Console.ReadKey();

            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is";
            Console.WriteLine($"{myString} {myInteger}");
            Console.ReadKey();

            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}!");
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " +
                          $"{firstNumber + secondNumber}.");
            Console.WriteLine($"The result of subtracting {secondNumber} from " +
                          $"{firstNumber} is {firstNumber - secondNumber}.");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} " +
                          $"is {firstNumber * secondNumber}.");
            Console.WriteLine($"The result of dividing {firstNumber} by " +
                          $"{secondNumber} is {firstNumber / secondNumber}.");
            Console.WriteLine($"The remainder after dividing {firstNumber} by " +
                          $"{secondNumber} is {firstNumber % secondNumber}.");
            Console.ReadKey();

        }
    }
}
