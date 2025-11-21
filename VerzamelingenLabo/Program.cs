using PokemonCollections.Models;

namespace PokemonCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Pokemon[] pokemonTeam1 = new Pokemon[6];
                pokemonTeam1[0] = new Pokemon("Squirtle")
                {
                    Level = 5,
                    Type = "Water"

                };
                pokemonTeam1[1] = new Pokemon("Charmander")
                {
                    Level = 8,
                    Type = "Fire"
                };
                pokemonTeam1[2] = new Pokemon("Bulbasaur")
                {
                    Level = 7,
                    Type = "Grass"
                };
                pokemonTeam1[3] = new Pokemon("Pikachu")
                {
                    Level = 10,
                    Type = "Electric"
                };
                pokemonTeam1[4] = new Pokemon("Jigglypuff")
                {
                    Level = 6,
                    Type = "Fairy"
                };


                //Console.WriteLine(pokemonTeam1[0]);
                // Array.Clear(pokemonTeam1, 2, 1); // om pokemon te verwijderen op positie 2 en dan 1 element verwijderen
                Console.WriteLine("Voor Traden");
                PrintPokemonRoster(pokemonTeam1);

                if (IsValidPokemonTeam(pokemonTeam1))
                {
                    Console.WriteLine("Deze array heeft een geldige lengte");
                }
                else
                {
                    Console.WriteLine("Deze array heeft GEEN geldige lengte");
                }
                Console.WriteLine();

                Pokemon[] pokemonTeam2 = new Pokemon[6]
                {
                    new Pokemon("Eevee")
                    {
                        Level = 12,
                        Type = "Normal"
                    },
                    new Pokemon("Snorlax")
                    {
                        Level = 15,
                        Type = "Normal"
                    },
                    new Pokemon("Aegislash")
                    {
                        Level = 50,
                        Type = "Ghost"
                    },
                    new Pokemon("Decidueye")
                    {
                        Level = 54,
                        Type = "Grass"
                    },
                    new Pokemon("Lucario")
                    {
                        Level = 50,
                        Type = "Fighting"
                    },
                    new Pokemon("Corviknight")
                    {
                        Level = 50,
                        Type = "Steel"
                    }

                };
                PrintPokemonRoster(pokemonTeam2);
                Console.ReadKey();
                Trainer trainer1 = new Trainer() 
                {
                    Name = "Ash Ketchum",
                    PokemonTeam = pokemonTeam1


                };
                Trainer trainer2 = new Trainer() 
                {
                    Name = "Donovan Deben",
                    PokemonTeam = pokemonTeam2
                };

                // Ruil de eerste Pokemon van trainer1 met de eerste Pokemon van trainer2
                //Pokemon[] tradedPokemon = new Pokemon[2] 
                //{
                //    trainer1.PokemonTeam[0],
                //    trainer2.PokemonTeam[0]

                //};
                //trainer1.PokemonTeam[0] = tradedPokemon[1];
                //trainer2.PokemonTeam[0] = tradedPokemon[0];

                // bovenstaande code kan korter door volgende code te gebruiken:
                Pokemon tradedPokemon = trainer1.PokemonTeam[0];
                trainer1.PokemonTeam[0] = trainer2.PokemonTeam[0];
                trainer2.PokemonTeam[0] = tradedPokemon;

                Console.Clear();
                Console.WriteLine("Na Traden:");
                Console.WriteLine();
                PrintPokemonRoster(pokemonTeam1);
                Console.WriteLine();
                PrintPokemonRoster(pokemonTeam2);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        public static void PrintPokemonRoster(Pokemon[] pokemonTeam)
        {
            foreach (Pokemon element in pokemonTeam)
            {
                Console.WriteLine(element);
            }
        }
        public static bool IsValidPokemonTeam(Pokemon[] pokemonTeam)
        {
            return (pokemonTeam.Length <= 6);

        }
    }
}
