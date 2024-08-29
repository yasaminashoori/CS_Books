namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Total salary for manager is {SalaryCalculator(15, "Manager"):NO}");
            Console.WriteLine($"Total salary for Employer is {SalaryCalculator(20, "Employer"):NO}");
            // delegate format:
            // Console.WriteLine($"Total salary for Manager is {SalaryCalculator(20, ManagerSalaryCalcualtor):NO}");
            //Console.WriteLine($"Total salary for HR is {SalaryCalculator(20, HRSalalryCalculator):NO}");
        }

        public static int SalaryCalculator(int hours, string position)
        //delegate Format:
        //public static int SalaryCalculator(int hours, Formule formule)
        {
            if (position == "HR")
                //return hours * 150_000;
                return NormalSalaryCalcualtor(hours);

            else if (position == "Manager")
                return hours * 175_000;
            return 0;

            // delegate instance:
            // return formule(hours);
        }

        //delegate type
        public delegate int Formule(int hours);
        static int NormalSalaryCalcualtor(int hours) 
            => hours * 150_000;
        static int ManagerSalaryCalcualtor(int hours)
            => hours * 150_000 + 5000;

    }
}
