using System.Diagnostics;

namespace InstanceConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal2 = new Animal();
        }
    }

    public class Animal
    {
        public Animal()
        {
            
        }
        private Animal(string Name, string Gender) // private cotor cant be instanciated 
        {
            this.Gender = Gender;
            this.Name = Name;
        }

        // also cant make object from an empty ctor
        //public Animal()
        //{
            
        //}

        public string Name { get; set; }        
        public string Gender { get; set; }
    }
}
