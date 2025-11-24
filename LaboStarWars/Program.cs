using LaboStarWars.Models;

namespace LaboStarWars

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<StarWarsCharacter> characters = new List<StarWarsCharacter>()
{
    new StarWarsCharacter()
    {
        Name = "Anakin Skywalker",
        Alliance = "Jedi",
        Rank = "Jedi Knight",
        LightSaberColor = "Blue",
        Quotes = new List<string>
        {
            "I see through the lies of the Jedi.",
            "This is where the fun begins."
        }
    },
    new StarWarsCharacter()
    {
        Name = "Obi-Wan Kenobi",
        Alliance = "Jedi",
        Rank = "Jedi Master",
        LightSaberColor = "Blue",
        Quotes = new List<string>
        {
            "I have the high ground.",
            "Only a Sith deals in absolutes.",
            "These are not the droids you are looking for."
        }
    },
    new StarWarsCharacter()
    {
        Name = "Darth Vader",
        Alliance = "Sith",
        Rank = "Sith Lord",
        LightSaberColor = "Red",
        Quotes = new List<string>
        {
            "I find your lack of faith disturbing.",
            "You don't know the power of the Dark Side."
        }
    },
    new StarWarsCharacter()
    {
        Name = "Yoda",
        Alliance = "Jedi",
        Rank = "Grand Master",
        LightSaberColor = "Green",
        Quotes = new List<string>
        {
            "Do or do not. There is no try.",
            "Fear is the path to the dark side."
        }
    },
    new StarWarsCharacter()
    {
        Name = "Darth Sidious",
        Alliance = "Sith",
        Rank = "Emperor",
        LightSaberColor = "Red",
        Quotes = new List<string>
        {
            "Power! Unlimited power!",
            "The Dark Side of the Force is a pathway to many abilities some consider to be unnatural."
        }
    },
    new StarWarsCharacter()
    {
        Name = "Luke Skywalker",
        Alliance = "Jedi",
        Rank = "Jedi Knight",
        LightSaberColor = "Green",
        Quotes = new List<string>
        {
            "I am a Jedi, like my father before me.",
            "No one’s ever really gone."
        }
    },
    new StarWarsCharacter()
    {
        Name = "Darth Maul",
        Alliance = "Sith",
        Rank = "Sith Apprentice",
        LightSaberColor = "Red",
        Quotes = new List<string>
        {
            "At last, we will reveal ourselves to the Jedi. At last, we will have revenge.",
            "I was lost, and yet I found purpose again."
        }
    },
    new StarWarsCharacter()
    {
        Name = "Qui-Gon Jinn",
        Alliance = "Jedi",
        Rank = "Jedi Master",
        LightSaberColor = "Green",
        Quotes = new List<string>
        {
            "Your focus determines your reality.",
            "Feel, don’t think. Trust your instincts."
        }
    }
};

            int index = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Deel 2 Collections:\n");
                Console.WriteLine(characters[index].DescribeCharacter());
                Console.WriteLine("\nQuotes:");
                characters[index].ShowQuotes();

                Console.WriteLine("\nGebruik de pijltjestoetsen om te navigeren (Links/Rechts), Insert om een quote toe te voegen, Delete om een quote te verwijderen of F om alle quotes te verwijderen.");
                Console.WriteLine("\nDruk op K om een quote op te zoeken en op S om alle Sith characters te tonen.");
                Console.WriteLine("\nDruk op escape om af te sluten");

                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.RightArrow)
                {
                    index++;
                    if (index >= characters.Count)
                    {
                        index = 0;
                    }

                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    index--;
                    if (index < 0)
                    {
                        index = characters.Count - 1;
                    }
                }
                else if (key == ConsoleKey.Insert)
                {
                    Console.WriteLine();
                    Console.WriteLine("Voer een nieuwe quote in:" );
                    string quote = Console.ReadLine();
                    characters[index].AddQuote(quote);
                }
                else if (key == ConsoleKey.Delete)
                {
                    Console.WriteLine();
                    Console.Write("Welke quote wil je verwijderen: ");
                    int quoteNumber = int.Parse(Console.ReadLine());
                    characters[index].RemoveQuote(quoteNumber);
                }
                else if (key == ConsoleKey.K)
                {
                    Console.WriteLine();
                    Console.WriteLine("Welke quote wil je opzoeken: ");
                    string quote = Console.ReadLine();

                    if (characters[index].KnowsQuote(quote))
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{characters[index].Name} kent die quote.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{characters[index].Name} kent die quote niet.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }

                }
                else if (key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (key == ConsoleKey.F)
                {
                    characters[index].ForgetAllQuotes();
                    Console.WriteLine();
                    Console.WriteLine("Alle quotes zijn vergeten.");
                    Console.ReadKey();
                }
                else if (key == ConsoleKey.S)
                {
                    Console.Clear();
                    Console.WriteLine("Sith Characters:\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (StarWarsCharacter sith in FilterSiths(characters))
                    {
                        Console.WriteLine(sith.DescribeCharacter());
                    }
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            static List<StarWarsCharacter> FilterSiths(List<StarWarsCharacter> characters)
            {     
                List<StarWarsCharacter> filtered = new List<StarWarsCharacter>();
                foreach (StarWarsCharacter character in characters)
                {
                    if (character.Alliance.Equals("Sith"))
                    {
                        filtered.Add(character);
                    }
                }
                return filtered;

            }
        }
    }
}
