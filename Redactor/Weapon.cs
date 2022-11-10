using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    public class Weapon
    {
        public string Name { get; set; }

        public int Lvl { get; set; } 
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelegence { get; set; }

        public Weapon(string name, int lvl,int strength, int dexterity, int constitution , int intelegence )
        {
            Name = name;
            Lvl = lvl;
            Strength = strength;    
            Dexterity = dexterity;
            Constitution = constitution;
            Intelegence = intelegence;
        }

        
    }
}
