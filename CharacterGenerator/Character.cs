using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Character
    {
        private string gender;
        private string name;
        private string race;
        private string characterClassType;
        private string rank;
        private string characterClass;
        private int age;
        private string hairStyle;
        private string hairColor;
        private string uniqueFeature;
        private string personality;
        private string background;

        public Character()
        {

        }

        public string Gender { get => gender; set => gender = value; }
        public string Name { get => name; set => name = value; }
        public string Race { get => race; set => race = value; }
        public string CharacterClassType { get => characterClassType; set => characterClassType = value; }
        public string Rank { get => rank; set => rank = value; }
        public string CharacterClass { get => characterClass; set => characterClass = value; }
        public int Age { get => age; set => age = value; }
        public string HairStyle { get => hairStyle; set => hairStyle = value; }
        public string HairColor { get => hairColor; set => hairColor = value; }
        public string UniqueFeature { get => uniqueFeature; set => uniqueFeature = value; }
        public string Personality { get => personality; set => personality = value; }
        public string Background { get => background; set => background = value; }
    }
}
