namespace LaboCrypto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> wallet = new Dictionary<string, decimal>()
            {
                { "BTC", 0.5m },
                { "ETH", 2m },
                { "SOL", 10m }
            };
            PrintWallet(wallet);
        }
        static void PrintWallet(Dictionary<string, decimal> wallet)
        {
            foreach (string coin in wallet.Keys)
            {
                Console.WriteLine($"{coin}: {}");
            }
        }
    }
}
