namespace Fibonacci

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacciNumbers = new int[12];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;
            for (int i = 2; i < fibonacciNumbers.Length; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1];
            }

            foreach (int number in fibonacciNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
