using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor
{
    public class MongoExamples
    { 
        private string connection = "mongodb://localhost:27017";
        private IMongoDatabase database;

        public MongoExamples()
        {
            var client = new MongoClient(connection);
            database = client.GetDatabase("Redactor");
        }

        public  void AddUser(Unit user)
        {
            var collection = database.GetCollection<Unit>("Heroes");
            collection.InsertOne(user);

        }

        public List<Unit> FindAll()
        {
            var collection = database.GetCollection<Unit>("Heroes");
            var list = collection.Find(x => true).ToList();
            return list;

        }

        public void Find(string name)
        {
            var collection = database.GetCollection<Unit>("Heroes");
            var one = collection.Find(x => x.name == name).FirstOrDefault();

            MessageBox.Show($" Name - {one.name} {"\n"}Health - {one.health} {"\n"} Damage - {one.damage} {"\n"}  {"\n"} Armor - {one.armor} {"\n"} Mana - {one.mane}");
        }

        public void ReplaceByName(string name, Unit user1)
        {
            var collection = database.GetCollection<Unit>("Heroes");
            collection.ReplaceOne(x => x.name == name, user1);
        }

    }
    }
