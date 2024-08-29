namespace DelegatePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // delegate format:
            Console.WriteLine($"Total salary for Manager is {SalaryCalculator(20, ManagerSalaryCalcualtor):NO}");
            Console.WriteLine($"Total salary for HR is {SalaryCalculator(20, HRSalalryCalculator):NO}");
        }


        //delegate Format:
        //1: public static int SalaryCalculator(int hours, Formule formule)
        //2: public static int SalaryCalculator(int hours, Formule<int> formule)
        //3: public static int SalaryCalculator(int hours, Formule<int,int> formule)
        public static int SalaryCalculator(int hours, Func<int, int> formule)
        {
            // delegate instance:
            return formule(hours);
        }

        //delegate type:

        //1: public delegate int Formule(int hours);
        //2: public delegate T Formule<T>(T hours);
        //3: public delegate TResult Formule<in T, out TResult>(T hours);
        //4: public delegate TResult Func<in T, out TResult>(T hours);

        static int NormalSalaryCalcualtor(int hours)
            => hours * 150_000;
        static int ManagerSalaryCalcualtor(int hours)
            => hours * 150_000 + 5000;

        static int HRSalalryCalculator(int hours)
            => hours * 160_000 + 3000;

    }
}
