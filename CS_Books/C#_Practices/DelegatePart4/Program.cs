using static DelegatePart4.DelegatePart2.Program;

namespace DelegatePart4
{
    namespace DelegatePart2
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                // delegate format:
                //Console.WriteLine($"Total salary for Manager is {SalaryCalculator(20, ManagerSalaryCalcualtor):NO}");
                //Console.WriteLine($"Total salary for HR is {SalaryCalculator(20, HRSalalryCalculator):NO}");
                Console.WriteLine($"Total salary for Manager is {SalaryCalculator(20, new NormalFormule()):NO}");
                Console.WriteLine($"Total salary for HR is {SalaryCalculator(20, new HRFormule()):NO}");
            }


            //delegate Format:
            public static int SalaryCalculator(int hours, IFormule formule)
            {
                // delegate instance:
                return formule.Calculate(hours);
            }

            public class NormalFormule : IFormule
            {
                public int Calculate(int hours) => hours * 150_000;
            }
            public class ManagerFormule: IFormule
            {
                public int Calculate(int hours) => hours * 150_000 + 5000;
            }

            public class HRFormule : IFormule
            {
                public int Calculate(int hours) => hours * 160_000 + 3000;
            }


        }
    }

}

public interface IFormule
{
    int Calculate(int hours);   
}