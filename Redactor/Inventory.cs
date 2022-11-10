using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using MongoDB;
using MongoDB.Driver;

namespace Redactor
{
    public partial class Inventory_List : Form
    {
        Unit Unit { get; set; }

        string name = string.Empty;
        string helmet = string.Empty;
        string chest = string.Empty;
        string weapon = string.Empty;

        public Inventory_List(Unit unit)
        {
            InitializeComponent();
            Unit = unit;

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1) return;
            var item = listView1.SelectedItems[0];

            if (Unit.strength >= int.Parse(item.SubItems[2].Text) && Unit.dexterity >= int.Parse(item.SubItems[3].Text) && Unit.constitution >= int.Parse(item.SubItems[4].Text) && Unit.intelegence >= int.Parse(item.SubItems[5].Text))
            {
                listView1.Items.Add((ListViewItem)item.Clone());
                listView1.Items.Remove((ListViewItem)listView1.SelectedItems[0]);
                switch (item.SubItems[6].Text)
                {
                    case "Helmet":
                        comboArrmor.Items.Add(item.SubItems[0].Text);
                        break;

                    case "Arms":
                        comboChest.Items.Add(item.SubItems[0].Text);
                        break;

                    case "Weapon":
                        comboWeapon.Items.Add(item.SubItems[0].Text);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Иди фарми опыт");
            }
        }

        private void Add_item_Click(object sender, EventArgs e)
        {
                foreach (var item in comboArrmor.Items)
                {
                    Unit.Helmet.Add(item.ToString());
                }

                foreach (var item in comboChest.Items)
                {
                    Unit.Chest.Add(item.ToString());
                }

                foreach (var item in comboWeapon.Items)
                {
                    Unit.Weapon.Add(item.ToString());
                }
        }
    }
}
