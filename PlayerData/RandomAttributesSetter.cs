using System;
using System.Collections.Generic;
using System.Linq;

//order of stats: strength, dexterity, constitution, inteligence, wisdom, //initiative, //proficiency, charisma
namespace PlayerData
{
    // !!!! To be used in main program file in order for code to work !!!
    // RandomAttributeSetter randomAttributeSetter = new RandomAttributeSetter();
    // randomAttributeSetter.createList();
    // randomAttributeSetter.setValues();
    public class RandomAttributeSetter
    {
        private int strength;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int wisdom;
        private int charisma;


        public List<int> defaultValuesList = new List<int>();

        public void createList()
        {
            defaultValuesList.Add(8);
            defaultValuesList.Add(10);
            defaultValuesList.Add(12);
            defaultValuesList.Add(13);
            defaultValuesList.Add(14);
            defaultValuesList.Add(15);

        }


        public int getRandomValue()
        {
            // first should select number and delete once used
            Random rnd = new Random();

            // pick random number which is < that list size

            int mIndex = rnd.Next(defaultValuesList.Count);

            // pick element from a list

            int val = (defaultValuesList.ElementAt(mIndex));

            // used element of list is being removed

            defaultValuesList.RemoveAt(mIndex);
            return (val);
        }

        public void setValues()
        {
            strength = getRandomValue();
            dexterity = getRandomValue();
            constitution = getRandomValue();
            intelligence = getRandomValue();
            wisdom = getRandomValue();
            charisma = getRandomValue();

        }

    }








}