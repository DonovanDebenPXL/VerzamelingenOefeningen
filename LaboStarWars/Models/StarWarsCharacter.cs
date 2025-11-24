using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboStarWars.Models
{
    internal class StarWarsCharacter
    {
        public string Name { get; set; }
        public string Alliance { get; set; }
        public string Rank { get; set; }
        public string LightSaberColor { get; set; }
        public List<string> Quotes { get; set; }

        public string DescribeCharacter()
        {
            return $"{Name}, {Rank} van de {Alliance}, heeft een {LightSaberColor} lightsaber.";
        }
        public void ShowQuotes()
        {
            foreach (var quote in Quotes)
            {
                Console.WriteLine($"- \"{quote}\"");
            }
        }
        public void AddQuote(string quote)
        {
            Quotes.Add(quote);
        }
        public void RemoveQuote(string quote)
        {
            Quotes.Remove(quote);
        }
        public void KnowsQuote(string quote)
        {
            if (Quotes.Contains(quote))
            {
                Console.WriteLine($"{Name} kent de quote: \"{quote}\"");
            }
            else
            {
                Console.WriteLine($"{Name} kent de quote: \"{quote}\" niet");
            }
        }
        public void ForgetAllQuotes()
        {
            Quotes.Clear();
        }
        public bool isSith()
        {
            return Alliance.Contains("Sith");
        }

    }
}
