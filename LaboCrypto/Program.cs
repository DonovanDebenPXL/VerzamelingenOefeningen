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
            Console.WriteLine();

            if (!wallet.TryAdd("BTC", 1.5m)) // TryAdd returns false als de key al bestaat, TryAdd voegt niet toe aan de value van die key: het probeert een nieuwe key-value pair toe te voegen
            {
                Console.WriteLine("BTC bestaat al in de wallet, toevoegen mislukt.");
                Console.WriteLine();
            }

            wallet.Add("DOG", 1m);
            Console.Write("Hoeveel wil je toevoegen aan BTC: ");
            decimal amountToAdd = Convert.ToDecimal(Console.ReadLine());
            wallet["BTC"] += amountToAdd; // dit is hoe je de value van een bestaande key kan aanpassen
            PrintWallet(wallet);
            Console.ReadKey();

            Console.WriteLine();
            Console.Write("Welke munt wil je opvragen uit de wallet: ");
            string coinToCheck = Console.ReadLine();
            coinToCheck = coinToCheck.ToUpper(); // om hoofdlettergevoeligheid te vermijden

            //try //if kan ook gebruikt worden in plaats van try-catch als je de fout al kan voorspellen
            //{
            //    decimal amount = wallet[coinToCheck];
            //    Console.WriteLine($"Je hebt {amount} van {coinToCheck} in je wallet.");
            //}
            //catch (KeyNotFoundException ex)
            //{
            //    Console.WriteLine($"De munt {coinToCheck} bestaat niet in je wallet.");
            //} 

            //if (wallet.ContainsKey(coinToCheck)) // defensief programmeren
            //{
            //    decimal amount = wallet[coinToCheck];
            //    Console.WriteLine($"Je hebt {amount} van {coinToCheck} in je wallet.");
            //}
            //else
            //{
            //    Console.WriteLine($"De munt {coinToCheck} bestaat niet in je wallet.");
            //}

            if (wallet.TryGetValue(coinToCheck, out decimal value)) // 1 lijn code verwijderd uit de if, doet hetzelfde als de ContainsKey/TryCatch versie
            {
                Console.WriteLine($"Je hebt {value} van {coinToCheck} in je wallet.");
            }
            else
            {
                Console.WriteLine($"De munt {coinToCheck} bestaat niet in je wallet.");
            }
            Console.ReadKey();

            Console.Clear();
            PrintWallet(wallet);
            Console.WriteLine();

            Console.Write("Welke coin wil je verwijderen: ");
            string coinToRemove = Console.ReadLine().ToUpper();
            Console.WriteLine();
            if (wallet.Remove(coinToRemove))
            {
                Console.WriteLine($"{coinToRemove} is verwijderd uit je wallet.");
                Console.WriteLine();
                PrintWallet(wallet);

            }
            else
            {
                Console.WriteLine($"{coinToRemove} bestaat niet in je wallet.");
            }
            Console.ReadKey();
        }
        static void PrintWallet(Dictionary<string, decimal> wallet)
        {
            foreach (string coin in wallet.Keys)
            {
                // decimal amount = wallet[coin]; kan het apart declareren maar is niet nodig als je  {wallet[coin]} gebruikt ipv {amount}
                Console.WriteLine($"{coin}: {wallet[coin]}");
            }
        }
    }
}
