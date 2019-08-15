using System;
namespace DD_Beyond
{
    public class S_Classes
    {

        string character;
        string hit_Die;
        string primaryAbility;
        string[] saves;
        string imagePath;

        public S_Classes(string character, string hit_Die, string primaryAbility, string[] saves, string imagePath)
        {
            this.character = character;
            this.hit_Die = hit_Die;
            this.primaryAbility = primaryAbility;
            this.saves = saves;
            this.imagePath = imagePath;
        }


    }
}
