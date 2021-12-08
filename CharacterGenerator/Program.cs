using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Program
    {
        private static List<ValueWithFrequency> genders = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> maleNames = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> femaleNames = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> races = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> characterClassTypes = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> ranks = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> adventurerCharacterClasses = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> merchantCharacterClasses = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> producerCharacterClasses = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> maleHairStyles = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> femaleHairStyles = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> hairColors = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> maleUniqueFeatures = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> femaleUniqueFeatures = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> personalities = new List<ValueWithFrequency>();
        private static List<ValueWithFrequency> backgrounds = new List<ValueWithFrequency>();

        private static int sleepTime = 100;
        static void Main(string[] args)
        {
            InitializeVariables();
            while (true)
            {
                Character character = GenerateCharacter();
                DisplayCharacter(character);
                Console.ReadLine();
            }
        }
        private static void InitializeVariables()
        {
            //Forking parameters
            genders.Add(new ValueWithFrequency("male", 100));
            genders.Add(new ValueWithFrequency("female", 100));

            characterClassTypes.Add(new ValueWithFrequency("adventurer", 20));
            characterClassTypes.Add(new ValueWithFrequency("merchant", 100));
            characterClassTypes.Add(new ValueWithFrequency("producer", 100));

            //Names
            maleNames.Add(new ValueWithFrequency("Zod", 100));
            maleNames.Add(new ValueWithFrequency("Judeo", 100));
            maleNames.Add(new ValueWithFrequency("Gibbin", 100));
            maleNames.Add(new ValueWithFrequency("David", 100));
            maleNames.Add(new ValueWithFrequency("Buck", 100));
            maleNames.Add(new ValueWithFrequency("Bedivere", 100));
            maleNames.Add(new ValueWithFrequency("Gotou", 100));
            maleNames.Add(new ValueWithFrequency("Walter", 100));
            maleNames.Add(new ValueWithFrequency("Wolfe", 100));
            maleNames.Add(new ValueWithFrequency("Anthony", 100));
            maleNames.Add(new ValueWithFrequency("Reiji", 100));
            maleNames.Add(new ValueWithFrequency("Hetheru", 100));
            maleNames.Add(new ValueWithFrequency("Benemba", 100));
            maleNames.Add(new ValueWithFrequency("Kirei", 100));
            maleNames.Add(new ValueWithFrequency("Amorose", 100));
            maleNames.Add(new ValueWithFrequency("Artin", 100));

            femaleNames.Add(new ValueWithFrequency("Erica", 100));
            femaleNames.Add(new ValueWithFrequency("Collette", 100));
            femaleNames.Add(new ValueWithFrequency("Kinessa", 100));
            femaleNames.Add(new ValueWithFrequency("Rosine", 100));
            femaleNames.Add(new ValueWithFrequency("Rin", 100));
            femaleNames.Add(new ValueWithFrequency("Illyasviel", 100));
            femaleNames.Add(new ValueWithFrequency("Seras", 100));
            femaleNames.Add(new ValueWithFrequency("Jessica", 100));
            femaleNames.Add(new ValueWithFrequency("Wolfe", 100));
            femaleNames.Add(new ValueWithFrequency("Mise", 100));
            femaleNames.Add(new ValueWithFrequency("Eriko", 100));
            femaleNames.Add(new ValueWithFrequency("Reiji", 100));
            femaleNames.Add(new ValueWithFrequency("Hetheru", 100));
            femaleNames.Add(new ValueWithFrequency("Benemba", 100));
            femaleNames.Add(new ValueWithFrequency("Ai", 100));
            femaleNames.Add(new ValueWithFrequency("Enoshimo", 100));
            femaleNames.Add(new ValueWithFrequency("Rauko", 100));
            femaleNames.Add(new ValueWithFrequency("Kirei", 100));
            femaleNames.Add(new ValueWithFrequency("Amorose", 100));
            femaleNames.Add(new ValueWithFrequency("Elora", 100));
            femaleNames.Add(new ValueWithFrequency("Syndra", 100));

            //Hair Styles
            maleHairStyles.Add(new ValueWithFrequency("short spikey", 100));
            maleHairStyles.Add(new ValueWithFrequency("undercut", 100));
            maleHairStyles.Add(new ValueWithFrequency("bald", 25));
            maleHairStyles.Add(new ValueWithFrequency("long wavy", 50));
            maleHairStyles.Add(new ValueWithFrequency("long straight", 50));

            femaleHairStyles.Add(new ValueWithFrequency("long wavy", 100));
            femaleHairStyles.Add(new ValueWithFrequency("long straight", 100));
            femaleHairStyles.Add(new ValueWithFrequency("very long straight", 10));
            //femaleHairStyles.Add(new ValueWithFrequency("short bangs", 50));
            //femaleHairStyles.Add(new ValueWithFrequency("pigtail", 100));
            femaleHairStyles.Add(new ValueWithFrequency("short spikey", 5));

            //Hair Colors
            hairColors.Add(new ValueWithFrequency("red", 100));
            hairColors.Add(new ValueWithFrequency("black", 100));
            hairColors.Add(new ValueWithFrequency("blonde", 100));
            hairColors.Add(new ValueWithFrequency("blue", 20));
            hairColors.Add(new ValueWithFrequency("white", 20));
            hairColors.Add(new ValueWithFrequency("orange", 20));

            //Races, Classes and Levels
            races.Add(new ValueWithFrequency("human", 200));
            races.Add(new ValueWithFrequency("elf", 100));
            races.Add(new ValueWithFrequency("goblin", 25));
            races.Add(new ValueWithFrequency("half elf", 100));
            races.Add(new ValueWithFrequency("half orc", 100));
            races.Add(new ValueWithFrequency("dwarf", 100));
            races.Add(new ValueWithFrequency("halfling", 100));
            races.Add(new ValueWithFrequency("gnome", 25));
            races.Add(new ValueWithFrequency("tauren", 50));
            races.Add(new ValueWithFrequency("catfolk", 50));
            races.Add(new ValueWithFrequency("undead", 5));

            ranks.Add(new ValueWithFrequency("bronze", 512));
            ranks.Add(new ValueWithFrequency("silver", 256));
            ranks.Add(new ValueWithFrequency("gold", 64));
            ranks.Add(new ValueWithFrequency("platinum", 4));
            ranks.Add(new ValueWithFrequency("diamond", 2));

            adventurerCharacterClasses.Add(new ValueWithFrequency("barbarian", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("bard", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("cleric", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("druid", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("fighter", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("monk", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("paladin", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("ranger", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("rogue", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("sorcerer", 100));
            adventurerCharacterClasses.Add(new ValueWithFrequency("wizard", 100));

            merchantCharacterClasses.Add(new ValueWithFrequency("blacksmith", 100));
            merchantCharacterClasses.Add(new ValueWithFrequency("leatherworker", 100));
            merchantCharacterClasses.Add(new ValueWithFrequency("tailor", 100));
            merchantCharacterClasses.Add(new ValueWithFrequency("alchemist", 50));
            merchantCharacterClasses.Add(new ValueWithFrequency("enchanter", 25));

            producerCharacterClasses.Add(new ValueWithFrequency("farmer", 100));
            producerCharacterClasses.Add(new ValueWithFrequency("miner", 100));
            producerCharacterClasses.Add(new ValueWithFrequency("hunter", 100));

            //Unique Feature and Personality
            personalities.Add(new ValueWithFrequency("polite", 100));
            personalities.Add(new ValueWithFrequency("crude", 100));
            personalities.Add(new ValueWithFrequency("ignorant", 100));
            personalities.Add(new ValueWithFrequency("religious", 100));
            personalities.Add(new ValueWithFrequency("like a leader", 100));

            maleUniqueFeatures.Add(new ValueWithFrequency("wears glasses", 100));
            maleUniqueFeatures.Add(new ValueWithFrequency("wears a blue lining on cloth", 100));
            maleUniqueFeatures.Add(new ValueWithFrequency("has a scar on his face", 5));
            maleUniqueFeatures.Add(new ValueWithFrequency("is crippled", 5));
            maleUniqueFeatures.Add(new ValueWithFrequency("is blind", 5));

            femaleUniqueFeatures.Add(new ValueWithFrequency("wears glasses", 100));
            femaleUniqueFeatures.Add(new ValueWithFrequency("wears a flower on her hair", 100));
            femaleUniqueFeatures.Add(new ValueWithFrequency("wears a blue lining on cloth", 50));
            femaleUniqueFeatures.Add(new ValueWithFrequency("wears a pink lining on cloth", 50));
            femaleUniqueFeatures.Add(new ValueWithFrequency("has a scar on her face", 5));
            femaleUniqueFeatures.Add(new ValueWithFrequency("is crippled", 5));
            femaleUniqueFeatures.Add(new ValueWithFrequency("is blind", 5));

            //Backgrounds
            backgrounds.Add(new ValueWithFrequency("was a street child", 100));
            backgrounds.Add(new ValueWithFrequency("was a noble", 100));
        }

        private static Character GenerateCharacter ()
        {
            ValueWithFrequency valueWithFrequency;
            Character character = new Character();

            valueWithFrequency = GetRandomValueWithFrequency(genders);
            character.Gender = valueWithFrequency.Value;

            valueWithFrequency = GetRandomValueWithFrequency(characterClassTypes);
            character.CharacterClassType = valueWithFrequency.Value;

            if (character.Gender == "male")
            {
                valueWithFrequency = GetRandomValueWithFrequency(maleNames);
                character.Name = valueWithFrequency.Value;

                valueWithFrequency = GetRandomValueWithFrequency(maleHairStyles);
                character.HairStyle = valueWithFrequency.Value;

                valueWithFrequency = GetRandomValueWithFrequency(maleUniqueFeatures);
                character.UniqueFeature = valueWithFrequency.Value;
            }
            else if (character.Gender == "female")
            {
                valueWithFrequency = GetRandomValueWithFrequency(femaleNames);
                character.Name = valueWithFrequency.Value;

                valueWithFrequency = GetRandomValueWithFrequency(femaleHairStyles);
                character.HairStyle = valueWithFrequency.Value;

                valueWithFrequency = GetRandomValueWithFrequency(femaleUniqueFeatures);
                character.UniqueFeature = valueWithFrequency.Value;
            }

            valueWithFrequency = GetRandomValueWithFrequency(ranks);
            character.Rank = valueWithFrequency.Value;

            if (character.CharacterClassType == "adventurer")
            {
                valueWithFrequency = GetRandomValueWithFrequency(adventurerCharacterClasses);
                character.CharacterClass = valueWithFrequency.Value;
            }
            else if (character.CharacterClassType == "merchant")
            {
                valueWithFrequency = GetRandomValueWithFrequency(merchantCharacterClasses);
                character.CharacterClass = valueWithFrequency.Value;
            }
            else if (character.CharacterClassType == "producer")
            {
                valueWithFrequency = GetRandomValueWithFrequency(producerCharacterClasses);
                character.CharacterClass = valueWithFrequency.Value;
            }

            valueWithFrequency = GetRandomValueWithFrequency(races);
            character.Race = valueWithFrequency.Value;



            valueWithFrequency = GetRandomValueWithFrequency(hairColors);
            character.HairColor = valueWithFrequency.Value;


            valueWithFrequency = GetRandomValueWithFrequency(personalities);
            character.Personality = valueWithFrequency.Value;

            valueWithFrequency = GetRandomValueWithFrequency(backgrounds);
            character.Background = valueWithFrequency.Value;

            return character;
        }
        private static void DisplayCharacter(Character character)
        {
            //First Line
            Console.WriteLine(character.Name);

            if (character.Gender == "male")
            {
                //Second Line
                Console.Write("He is ");
                Console.WriteLine(character.Gender + " " + character.Race + " " + character.Rank + " " + character.CharacterClass + ".");
                //Third line
                Console.Write("He has ");
                Console.WriteLine(character.HairColor + " " + character.HairStyle + " hair.");
                //Fourth line
                Console.Write("He ");
                Console.WriteLine(character.UniqueFeature + ".");
                //Fifth line
                Console.Write("He looks ");
                Console.WriteLine(character.Personality + ".");
                //Sixth line
                Console.Write("He ");
                Console.WriteLine(character.Background + ".");
            }
            else if (character.Gender == "female")
            {
                //Second Line
                Console.Write("She is ");
                Console.WriteLine(character.Gender + " " + character.Race + " " + character.Rank + " " + character.CharacterClass + ".");
                //Third line
                Console.Write("She has ");
                Console.WriteLine(character.HairColor + " " + character.HairStyle + " hair.");
                //Fourth line
                Console.Write("She ");
                Console.WriteLine(character.UniqueFeature + ".");
                //Fifth line
                Console.Write("She looks ");
                Console.WriteLine(character.Personality + ".");
                //Sixth line
                Console.Write("She ");
                Console.WriteLine(character.Background + ".");
            }
        }
        private static ValueWithFrequency GetRandomValueWithFrequency(List<ValueWithFrequency> list)
        {
            System.Threading.Thread.Sleep(sleepTime);
            int totalFrequency = 0;
            int cumulativeFrequency = 0;
            foreach (ValueWithFrequency item in list)
            {
                totalFrequency += item.Frequency;
            }
            int randomIndex = -1;
            Random random = new Random();
            randomIndex = random.Next(1, totalFrequency + 1);
            for (int listIndex = 0; listIndex < list.Count;listIndex++)
            {
                cumulativeFrequency += list.ElementAt(listIndex).Frequency;
                if (cumulativeFrequency >= randomIndex)
                {
                    return list.ElementAt(listIndex);
                }
            }
            return null;
        }
    }
}
