using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class DamageCalculator
    {
        #region properties
        public int hp { set; get; }

        public int toughness { set; get; }

        public int armor { set; get; }

        public int damage { set; get; }

        public int penetration { set; get; }
        #endregion

        public void RequestTargetValues()
        {
            Console.Write("The target's HP: ");
            hp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target's Toughness: ");
            toughness = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target's Armor: ");
            armor = Convert.ToInt32(Console.ReadLine());
        }

        public void RequestDamageValues()
        {
            Console.Write("Attack Damage: ");
            damage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Attack Penetration: ");
            penetration = Convert.ToInt32(Console.ReadLine());
        }

        public void RequestDamageProperties()
        {
            Console.Write("Ignore armor? (y/n) ");
            string answer1 = Console.ReadLine();
            switch (answer1)
            {
                case "y":
                armor = 0;
                    break;
                default:
                    break;
            }
            Console.Write("Ignore Toughness? (y/n) ");
            string answer2 = Console.ReadLine();
            switch (answer2)
            {
                case "y":
                    toughness = 0;
                    break;
                default:
                    break;
            }
        }

        public void CalculateDamage()
        {
            var absorb = armor + toughness;
            if (penetration >= absorb)
            {
                absorb = 0;
            }
            else
            {
                absorb = absorb - penetration;
            }
            var damageTotal = damage - absorb;
            var sign = Math.Sign(damageTotal);
            if (sign == -1)
            {
                Console.WriteLine("\nThis attack deals no damage");
                Console.WriteLine("\nThe target's remaining HP is " + (hp));
            }
            else
            {
                var remainingHp = hp - damageTotal;
                Console.WriteLine("\nThe target's remaining HP is " + (remainingHp));
                hp = remainingHp;
            }
        }

        public void ClosingOptions()
        {
            Console.WriteLine("\nEnter (c) to Continue applying damage, (r) to Restart, or (e) to Exit... ");
            string response = Console.ReadLine();
            switch (response)
            {
                case "c":
                    RequestDamageValues();
                    RequestDamageProperties();
                    CalculateDamage();
                    ClosingOptions();
                    break;
                case "r":
                    RequestTargetValues();
                    RequestDamageValues();
                    RequestDamageProperties();
                    CalculateDamage();
                    ClosingOptions();
                    break;
                case "e":
                    Environment.Exit(0);
                    break;
                default:
                    return;
            }   
        }
    }
}