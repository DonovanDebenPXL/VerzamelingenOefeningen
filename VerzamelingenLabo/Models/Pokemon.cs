using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCollections.Models
{
    internal class Pokemon
    {
        private readonly string[] AvailableTypes = { "Normal", "Water", "Fire", "Grass", "Electric", "Fairy", "Fighting","Flying", "Dark", "Steel", "Ghost", "Bug", "Ground", "Rock", "Psychic"};

        public string Name { get; set; }
        public int Level { get; set; }
        private string _type;

        public string Type
        {
            get { return _type; }
            set
            {
                if (Array.Exists(AvailableTypes, element => element.Equals(value)))
                {
                    _type = value;
                    return;
                }
                else
                {
                    throw new ArgumentException($"{value} is geen geldig type.");
                }
            }
        }
        public Pokemon(string name)
        {
            this.Name = name;
            this.Level = 1;


        }
        public override string ToString()
        {
            return $"Pokemon Name: {Name}, Level: {Level}, Type: {Type}";
        }

    }
}
