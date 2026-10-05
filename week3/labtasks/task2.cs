using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Gamecharacter
    {
        public string charactername;
        public int level;
        public int healthpoints;
        public int attackpower;
        public int defencepower;
        public int experiencepoints;
        public int stamina;
        public string specialability;
        public Gamecharacter(string gamecharacter, int level , int healthpoints , int attackpower , int defencepower 
            , int experiencepoints , int stamina, string specialability )
        {
            this.charactername = gamecharacter;
            this.level = level;
            this .healthpoints = healthpoints;
            this .attackpower = attackpower;
            this .defencepower = defencepower;
            this.experiencepoints = experiencepoints;
            this.stamina = stamina;
            this .specialability = specialability;
        }
        public void increaselevel()
        {
            level++;
            Console.WriteLine("Your Level is increased to level " + level);

        }
        public void takedamage(int damage)
        {
            healthpoints = healthpoints - damage;
            if (healthpoints < 0)
            {         
                healthpoints = 0;
            }

            Console.WriteLine("Health after damage: " + healthpoints);
        }
        public void potion(string potiontype)
        {
            if(potiontype =="health")
            {
                healthpoints = healthpoints + 30;
                if (healthpoints > 100 )
                {
                    healthpoints = 100;
                }
                Console.WriteLine("Health Potion Used Your health is " + healthpoints);

            }
            else if (potiontype == "stamina")
            {
                stamina += 30;
                if (stamina > 100)
                {
                    stamina = 100;
                }
                Console.WriteLine("stamina Potion Used Your health is " + stamina);
            }
            else
            {
                Console.WriteLine("Invalid potion ");
            }
        }
        public int Calculatetotalpower()
        {
            return attackpower + defencepower;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Character Details ---");
            Console.WriteLine("Character Name: " + charactername);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Health Points: " + healthpoints);
            Console.WriteLine("Attack Power: " + attackpower);
            Console.WriteLine("Defense Power: " + defencepower);
            Console.WriteLine("Experience Points: " + experiencepoints);
            Console.WriteLine("Stamina: " + stamina);
            Console.WriteLine("Special Ability: " + specialability);
            Console.WriteLine("Total Power: " + Calculatetotalpower());
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamecharacter character = new Gamecharacter(
               "Warrior",
               5,
               100,
               40,
               30,
               500,
               80,
               "Fire Blast"
           );

            character.DisplayDetails();
            character.increaselevel();
            character.takedamage(25);
            character.potion("health");
            character.potion("stamina");
            Console.WriteLine("\nTotal Power: " + character.Calculatetotalpower());
            character.DisplayDetails();

            Console.ReadLine();
        }
    }
}
