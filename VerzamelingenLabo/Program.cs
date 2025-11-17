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

                Console.WriteLine(pokemonTeam1[0]);
                Array.Clear(pokemonTeam1, 2, 1); // om pokemon te verwijderen op positie 2 en dan 1 element verwijderen
                PrintPokemonRoster(pokemonTeam1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        public static void PrintPokemonRoster(Pokemon[] pokemonTeam)
        {
            foreach (Pokemon pokemon in pokemonTeam)
            {
                Console.WriteLine(pokemon);
            }
        }
        public static bool IsValidPokemonRosterSize(Pokemon[] pokemonTeam)
        {
            if (pokemonTeam.Length == 6)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
