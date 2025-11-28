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
            return $"{Name}, {Rank} of the {Alliance}, has a {LightSaberColor} lightsaber.";
        }
        public void ShowQuotes()
        {
            foreach (string quote in Quotes)
            {
                Console.WriteLine($"- \"{quote}\"");
            }
            if (Quotes.Count == 0)
            {
                Console.WriteLine("No quotes available.");

            }
        }
        public void AddQuote(string quote)
        {
            Quotes.Add(quote);
        }
        public void RemoveQuote(int indexOfQuote)
        {

            if (indexOfQuote >= 0 || indexOfQuote < Quotes.Count - 1)
            {
                this.Quotes.RemoveAt(indexOfQuote);
            }
            else
            {
                Console.WriteLine("Geen geldige index.");
            }


        }
        public bool KnowsQuote(string quote)
        {
            if (Quotes.Contains(quote))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ForgetAllQuotes()
        {
            Quotes.Clear();
        }
        

    }
}
