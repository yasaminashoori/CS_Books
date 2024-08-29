namespace CallByReferneceVSCallByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Add(number); //call by value and 
            Console.WriteLine(number);

            //example 1: call by ref 
            // send the ref address of the value, not make itself ref.
            int number2 = 4;
            Multiply(ref number2);
            Console.WriteLine(number2);

            // example 2: call by ref
            // Output: test
            User user = new User();
            user.Name = "Yas";
            Console.WriteLine(user);

            //local method 
            int Add(int number)
            {
                number++;
                return number;
            }

            //call by ref 
            double Multiply(ref int number2)
            {
                number2 = number2 * number2;
                return number2;
            }

        }

        public static void ChangeUser(User user)
        {
            user.Name = "TEST";
        }
        public class User
        {
            public int Id;
            public string Name;
        }
    }

}
