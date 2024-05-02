
# This Repo includes my notes and summarized info, codes about C# 12 in a nutshell 
# Includes  : 

1 - C# Microsoft Documnet (important topics).

2- Algorithm and DS (best questions and concepts).

3- Topics that prepare us for the day of the interview.
# Contents : 

4- Asp .NET Core

<ul>
<li><a href="https://github.com/yasaminashoori/My-Resources/blob/master/LevelUp-Math/Math.md">LevelUp Math (for Algorithms)</a></li>
<li><a href="https://github.com/yasaminashoori/Good-Stuffs/blob/master/Git-Github/git.md">Git & Github</a></li>
</ul>




// OOP 
 
namespace TestOOP
{
    class A
    {
        public void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public new virtual void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public override void Test() { Console.WriteLine("C::Test()"); }
    }

    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            B b = new B();
            C c = new C();

            a.Test();
            b.Test();
            c.Test();

            a = new B();
            a.Test();

            b = new C();
            b.Test();

            Console.ReadKey();
        }
    }
}
  

    class A
    {
        public void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public new virtual void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public override void Test() { Console.WriteLine("C::Test()"); }
    }

    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            B b = new B();
            C c = new C();

            a.Test();
            b.Test();
            c.Test();

            a = new B();
            a.Test();

            b = new C();
            b.Test();

            Console.ReadKey();
        }
    }

