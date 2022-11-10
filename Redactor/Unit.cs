using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    [BsonKnownTypes(typeof(Warrior), typeof(Wizard), typeof(Rogue))]
    public class Unit
    {

        //public MongoDB.Bson.ObjectId _id { get; set; }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        internal string helmet;

        internal string chest;

        internal string weapon; 

        public string name { get; set; }
    
        public int health { get; set; }
        public int damage { get; set; } 
        public int armor { get; set; }
        public int mane { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelegence { get; set; }
        public List<Items> Items { get; set; } = new List<Items>();

        public List<string> Helmet { get; set; } = new List<string>();

        public List<string> Chest { get; set; } = new List<string>();

        public List<string> Weapon { get; set; } = new List<string>();
        public int lvl { get; set; }
        public string skill { get; set; }

        public Unit(string name,int health, int damage, int armor, int mane, int strength, int dexterity, int constitution, int intelegence, int lvl, string skill)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.armor = armor;
            this.mane = mane;
            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intelegence = intelegence;
            this.lvl = lvl;
            this.skill = skill;
        }
    }
}
