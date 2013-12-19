using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class TargetProperties : EnteredDamage
    {   
        //Properties        
        public int Toughness { set; get; }
        public int Armor { set; get; }   
        public int HP { set; get; }             

        //methods
        public int Defense()
        {
            return Armor + Toughness;
        }

        public void AskforHP()
        {
            Console.WriteLine("Enter the target's HP: ");
            string hpEntered = Console.ReadLine();
            int HP = int.Parse(hpEntered);
            
        }
        public void AskforToughness()
        {
            Console.WriteLine("Enter the target's Tougness Modifier: ");
            string toughnessEntered = Console.ReadLine();
            int toughness = int.Parse(toughnessEntered);
        }
        public void AskforArmor()
        {
            Console.WriteLine("Enter the target's Armor: ");
            string armorEntered = Console.ReadLine();
            int armor = int.Parse(armorEntered);
        }
        public void AskforDamage()
        {
            Console.WriteLine("Enter the amount of damage dealt to the target: ");
            string damageEntered = Console.ReadLine();
            int damage = int.Parse(damageEntered);
        }
        public void AskforPenetration()
        {
            Console.WriteLine("Enter the attack's penetration: ");
            string penetrationEntered = Console.ReadLine();
            int penetration = int.Parse(penetrationEntered);
        }
        //Constructor
        //public UserEnteredTargetProperties(int hp)  I would like to force the created class to include HP, but it keeps returning a zerp
        //{
        //}
    }
}