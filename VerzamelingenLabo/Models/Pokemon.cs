using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCollections.Models
{
    internal class Pokemon
    {
        private const string WaterType = "Water";
        private const string FireType = "Fire";
        private const string GrassType = "Grass";
        private const string ElectricType = "Electric";


        public string Name { get; set; }
        public int Level { get; set; }
        private string _type;

        public string Type
        {
            get { return _type; }
            set
            {
                if (value.Equals(WaterType) || value.Equals(FireType) || value.Equals(GrassType) || value.Equals(ElectricType))
                {
                    _type = value;
                    return;
                }
                else
                {
                    throw new ArgumentException("Invalid Pokemon type. Allowed types are: Water, Fire, Grass, Electric.");
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
