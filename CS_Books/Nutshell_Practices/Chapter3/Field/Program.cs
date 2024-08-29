using CommonLibrary;

namespace Field
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region FieldStatic_MyOwnPractice
            //my own practice
            var cust1 = new Customer("ali", "ali@gmail.com", "091234512345", "Tehran Vanak", "Tehran", "0092233", "Iran");
            Console.WriteLine(cust1.Id);

            var cust2 = new Customer("ali", "ali@gmail.com", "091234512345", "Tehran Vanak", "Tehran", "0092233", "Iran");
            Console.WriteLine(cust2.Id);
            //it prints id 1 and 2 because field id is static if it wasnt we had 1 every time. 
            #endregion

            #region FieldNutshell_Practice
            var o = new Octopus();
            Console.WriteLine(o.Age);
            // Compile time error for the protection level can't changing the value of readonly field => o.legs = 10;
            // Compile time error for the protection level it's private => o.name = "f";
            #endregion

            Console.ReadKey();  
        }
    }
    
    // for nutshell practice
    class Octopus
    {
        string name;
        public int Age = 10;
        static readonly int legs = 8, eyes = 1;
    }
}


//Notes: differences between static and static readonly field : 

/*
 * A static constructor is used for static fields because it ensures that the static fields
 * are initialized before any instance of the class is created or any static members are accessed. 
 */