namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new(); // target type expression 
            user.name = "Test";
            ChangeUser(user);
            Console.WriteLine(user.name);
            Console.ReadKey();  
        }

        public static void ChangeUser(User user)
        {
            user.name = "THIS IS FROM CLASS";
    
        }

        public class User
        {
            public string name;
            public int id;
        }
    }
}
