using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Redactor
{
    public partial class SelectorUnits : Form
    {
        Unit unit { get; set; }

        int OneTeam = 0;
        int TwoTeam = 0;
        int lvl;
        Dictionary<string, int> units = new Dictionary<string, int>();

        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("Redactor");
        static IMongoCollection<Unit> collection = database.GetCollection<Unit>("Heroes");

        public void FindAllUnit(ListBox list)
        {
            List<Unit> characters = collection.AsQueryable().ToList<Unit>();
            foreach (var item in characters)
            {
                units.Add(item.name, item.lvl);
            }
            foreach (var pair in units.OrderBy(pair => pair.Value).Reverse())
            {
                list.Items.Add(pair.ToString());
            }
        }

        public SelectorUnits()
        {
            InitializeComponent();
            FindAllUnit(listUnit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team1.Items.Clear();
            Team2.Items.Clear();

            OneTeam = 0;
            TwoTeam = 0;
            Random rnd = new Random();

            int value = rnd.Next(2);

            if (listUnit.Items.Count != 0)
            {
                foreach (var pain in units.OrderBy(pain => pain.Value).Reverse())
                {
                    if (OneTeam > TwoTeam)
                    {
                        Team2.Items.Add(pain);
                        TwoTeam += pain.Value;
                    }
                    else if (TwoTeam > OneTeam)
                    {
                        Team1.Items.Add(pain);
                        OneTeam += pain.Value;
                    }
                    else
                    {
                        if (value == 1)
                        {
                            Team1.Items.Add(pain);
                            OneTeam += pain.Value;
                        }
                        else
                        {
                            Team2.Items.Add(pain);
                            TwoTeam += pain.Value;
                        }
                    }
                    listUnit.Items.Remove(pain);
                }
            }
            if (OneTeam - TwoTeam >= 10 || TwoTeam - OneTeam >= 10)
            {
                MessageBox.Show("Невозможно создать сбалансированные команды!");
                Team1.Items.Clear();
                Team2.Items.Clear();
            }

        }
    }

}
