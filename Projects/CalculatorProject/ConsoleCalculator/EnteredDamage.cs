using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleCalculator
{
    class EnteredDamage
    {
        public int Damage
        { set; get; }   

        public int Penetration
        { set; get; }

        public void IgnoreToughness()
        {
            int Toughness = 0;
        }

        public void IgnoreArmor()
        {
            int Armor = 0;
        }

        public void DealDamage() 
        {

        }

        public void ApplyPenetration()
        {
            //return UserEnteredTargetProperties.defense();

        }
    }
}