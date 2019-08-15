using System;

namespace PlayerData
{
    public class Player
    {
        public Player(string name, string playerClass, int level, int healthPoints, int[] stats, List<int> standardArray)
        {
            this.name = name;
            this.playerClass = playerClass;
            this.level = level;
            this.hitPoints = healthPoints;
            this.stats = stats;
            this.standardArray = standardArray;
        }

        private string name;
        public string Name { get => this.name; set => this.name = value; }
        private string playerClass;
        public string PlayerClass { get => this.playerClass; set => this.playerClass = value; }
        private int level;
        public int Level { get => this.level; set => this.level = value; }
        private int hitPoints;
        public int HitPoints { get => this.hitPoints; set => this.hitPoints = value; }
        //order of stats: strength, dexterity, constitution, inteligence, wisdom, //initiative, //proficiency, charisma
        private int[] stats;
        public int[] Stats { get => this.stats; set => this.stats = value; }
        //standardArray holds these values 8,10,12,13,14,15. Values assigned to stats
        private List<int> standardArray;
        public List<int> StandardArray { get => this.standardArray; set => this.standardArray = value; }


        // method to check players level
        public int getProfBonus()
        {
            if (level <= 4)
            {
                return 2;
            }
            else if (level > 4 && level <= 8)
            {
                return 3;
            }
            else if (level > 8 && level <= 12)
            {
                return 4;
            }
            else if (level > 12 && level <= 16)
            {
                return 5;
            }
            else if (level > 16 && level <= 20)
            {
                return 6;
            }
            return 0;
        }
        //public int getHealth()
        //{
        //    return (classDice + constitution) + ((Random(classDice) + constitution) * level - 1);
        //}

        //public int getAttack()
        //{
        //    return classDice + proficiencybonus;
        //}


        //public string GetName()
        //{
        //    return this.name;
        //}

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetPlayerClass()
        //{
        //    return this.playerClass;
        //}

        //public void SetPlayerClass(string playerClass)
        //{
        //    this.playerClass = playerClass;
        //}

        //public int GetLevel()
        //{
        //    return this.level;
        //}

        //public void SetLevel(int level)
        //{
        //    this.level = level;
        //}

        //public int GetHealthPoints()
        //{
        //    return this.healthPoints;
        //}

        //public void SetHealthPoints(int healthPoints)
        //{
        //    this.healthPoints = healthPoints;
        //}

        //public int[] GetStats()
        //{
        //    return this.stats;
        //}

        //public void SetStats(int[] stats)
        //{
        //    this.stats = stats;
        //}

        //public List<int> GetStandardArray()
        //{
        //    return this.standardArray;
        //}

        //public void SetName(List<int> standardArray)
        //{
        //    this.standardArray = standardArray;
        //}

    }
}
