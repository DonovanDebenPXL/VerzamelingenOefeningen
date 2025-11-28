namespace Priemgetalen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers = new int[100];

            int number = 2;
            int index = 0;

            do
            {
                bool isPrime = true;

                for (int divisor = 2; divisor <= (number / 2); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers[index] = number;
                    index++;
                }
                number++;
            } while (primeNumbers[99] == 0);

            int maxLength = primeNumbers[99].ToString().Length;

            Console.WriteLine("De eerste 100 priemgetalen zijn: ");
            Console.WriteLine();

            for (int i = 0; i < primeNumbers.Length; i++)
            {
                Console.Write(primeNumbers[i].ToString().PadLeft(maxLength, ' '));
            }
            Console.WriteLine();
        }
    }
}
