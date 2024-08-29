namespace Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 64, 34, 25, 5, 22, 11, 90, 12 };

            int n = myArray.Length; // length of the array 
            for (int i = 0; i < n - 1; i++) // looping from 0 to n - 1
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (myArray[j] < myArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = myArray[minIndex];
                myArray[minIndex] = myArray[i];
                myArray[i] = temp;
            }

            Console.WriteLine("Sorted array: " + string.Join(", ", myArray));
            Console.ReadKey();
        }
    }
}
