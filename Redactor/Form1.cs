using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Redactor
{
    public partial class Form1 : Form
    {
        MongoExamples mongo { get; set; }

        int CountExp = 0;

        int LvlConst = 1000;
        Unit unit { get; set; }
        public Form1()
        {
            InitializeComponent();
            mongo = new MongoExamples();
            DataUnits.DataSource = mongo.FindAll();

        }

        //private void DataUnits_CellContentClick1(object sender, DataGridViewCellEventArgs e)
        //{
        //   if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        var client = new MongoClient();
        //        var database = client.GetDatabase("Redactor");
        //        var collection = database.GetCollection<Unit>("Heroes");
        //        var one = collection.Find(x => x.name == DataUnits.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
        //        int ind = 0;
        //        Name_TextBox.Text = one.name;
        //        Strength.Value = one.strength;
        //        Dexterity.Value = one.dexterity;
        //        Constitution.Value = one.constitution;
        //        LvL.Text = one.lvl.ToString();
        //        Intrligence.Value = one.intelegence;
        //        switch(one.clas)
        //        {
        //            case "Warrior":
        //                ind = 0;
        //                break;

        //            case "Wizard":
        //                ind = 1;
        //                break;

        //            case "Rogue":
        //                ind = 2;
        //                break;
        //        }
        //        Choice.Text = one.clas;

        //    }
        //}

        private void Choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Choice.Text == "Warrior")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }

            else if (Choice.Text == "Wizard")
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }

            else if (Choice.Text == "Rouge")
            {
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }

            switch (Choice.SelectedIndex)
            {
                case 0:
                    Strength.Minimum = 30;
                    Strength.Maximum = 250;
                    Dexterity.Minimum = 15;
                    Dexterity.Maximum = 40;
                    Constitution.Minimum = 20;
                    Constitution.Maximum = 100;
                    Intrligence.Minimum = 10;
                    Intrligence.Maximum = 70;
                    unit = new Warrior();
                    break;

                case 1:
                    Strength.Minimum = 10;
                    Strength.Maximum = 45;
                    Dexterity.Minimum = 20;
                    Dexterity.Maximum = 70;
                    Constitution.Minimum = 15;
                    Constitution.Maximum = 60;
                    Intrligence.Minimum = 35;
                    Intrligence.Maximum = 250;
                    unit = new Wizard();
                    break;

                case 2:
                    Strength.Minimum = 15;
                    Strength.Maximum = 55;
                    Dexterity.Minimum = 40;
                    Dexterity.Maximum = 250;
                    Constitution.Minimum = 20;
                    Constitution.Maximum = 80;
                    Intrligence.Minimum = 15;
                    Intrligence.Maximum = 70;
                     unit = new Rogue();
                    break;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            int strength = Convert.ToInt32(Strength.Value);
            int constitution = Convert.ToInt32(Dexterity.Value);
            int dexterity = Convert.ToInt32(Constitution.Value);
            int intelegence = Convert.ToInt32(Intrligence.Value);

            switch (Choice.SelectedIndex)
            {
                case 0:
                   
                    unit.name = Name_TextBox.Text;
                    unit.health = (strength * 2) + (constitution * 10);
                    unit.damage = (strength * 5) + dexterity;
                    unit.armor = dexterity + (constitution * 2);
                    unit.mane = intelegence;
                    unit.lvl = Convert.ToInt32(LvL.Text);
                    MessageBox.Show($" Name - {unit.name} {"\n"} Health - {unit.health} {"\n"} Damage - {unit.damage} {"\n"}  {"\n"} Armor - {unit.armor} {"\n"} Mana - {unit.mane} {"\n"} LvL - {unit.lvl}");
                    mongo.AddUser(unit);
                    break;

               case 1:
                   
                    unit.name = Name_TextBox.Text;
                    unit.health = strength + (constitution * 3);
                    unit.damage = strength * 3;
                    unit.armor = (dexterity * 1) + constitution;
                    unit.mane = intelegence * 2;
                    unit.lvl = Convert.ToInt32(LvL.Text);
                    MessageBox.Show($" Name - {unit.name} {"\n"}Health - {unit.health} {"\n"} Damage - {unit.damage} {"\n"}  {"\n"} Armor - {unit.armor} {"\n"} Mana - {unit.mane} {"\n"} LvL - {unit.lvl}");
                    mongo.AddUser(unit);
                    break;

                case 2:
                   
                    unit.name = Name_TextBox.Text;
                    unit.health = strength + (constitution * 6);
                    unit.damage = (strength * 2) + (dexterity * 4);
                    unit.armor = dexterity * 1;
                    unit.mane = intelegence * 1;
                    unit.lvl = Convert.ToInt32(LvL.Text);
                    MessageBox.Show($" Name - {unit.name} {"\n"}Health - {unit.health} {"\n"} Damage - {unit.damage} {"\n"}  {"\n"} Armor - {unit.armor} {"\n"} Mana - {unit.mane} {"\n"} LvL - {unit.lvl}");
                    mongo.AddUser(unit);
                    break;
            }
            DataUnits.DataSource = mongo.FindAll();

        }

        private void Find_Click(object sender, EventArgs e)
        {
            mongo.Find(FindName.Text);
            FindName.Text = "";
        }

        private void ExpUp_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ExpValue.Maximum = LvlConst;
            //    CountExp += 500;
            //    ExpValue.Value = CountExp;
            //}
            //catch (Exception)
            //{
            //    if (CountExp > LvlConst)
            //    {
            //        unit.lvl++;
            //        LvL.Text = Convert.ToString(unit.lvl);
            //    }
            //    LvlConst = LvlConst * 2;
            //    ExpValue.Maximum = LvlConst;

            //}

            if (CountExp < LvlConst)
            {
                ExpValue.Maximum = LvlConst;
                CountExp += 500;
                ExpValue.Value = CountExp;


            }
            else
            {
                LvlConst = LvlConst * 2;
                ExpValue.Maximum = LvlConst;

                unit.lvl++;
                LvL.Text = Convert.ToString(unit.lvl);

                CountExp = 0;
                ExpValue.Value = CountExp;

                if (Int32.Parse(LvL.Text) % 3 == 0)
                {
                    SkilsForm skilsForm = new SkilsForm(unit);
                    skilsForm.Show();
                }
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            int strength = Convert.ToInt32(Strength.Value);
            int constitution = Convert.ToInt32(Dexterity.Value);
            int dexterity = Convert.ToInt32(Constitution.Value);
            int intelegence = Convert.ToInt32(Intrligence.Value);

            switch (Choice.SelectedIndex)
            {
                case 0:

                    unit.name = Name_TextBox.Text;
                    unit.health = (strength * 2) + (constitution * 10);
                    unit.damage = (strength * 5) + dexterity;
                    unit.armor = dexterity + (constitution * 2);
                    unit.mane = intelegence;
                    unit.lvl = Convert.ToInt32(LvL.Text);
                    break;

                case 1:

                    unit.name = Name_TextBox.Text;
                    unit.health = strength + (constitution * 3);
                    unit.damage = strength * 3;
                    unit.armor = (dexterity * 1) + constitution;
                    unit.mane = intelegence * 2;
                    unit.lvl = Convert.ToInt32(LvL.Text);
                    break;

                case 2:

                    unit.name = Name_TextBox.Text;
                    unit.health = strength + (constitution * 6);
                    unit.damage = (strength * 2) + (dexterity * 4);
                    unit.armor = dexterity * 1;
                    unit.mane = intelegence * 1;
                    unit.lvl = Convert.ToInt32(LvL.Text);
                    break;
            }
            Unit unit1 = new Unit(unit.name, unit.health, unit.damage, unit.armor, unit.mane, strength, dexterity, intelegence, constitution, unit.lvl, unit.skill);
            var client = new MongoClient();
            var database = client.GetDatabase("Redactor");
            var collection = database.GetCollection<Unit>("Heroes");
            collection.ReplaceOne(x => x.name == Name_TextBox.Text, unit1);
        }

        private void Inventory_Unit_Click(object sender, EventArgs e)
        {
            Inventory_List inventory_List = new Inventory_List(unit);
            inventory_List.Show();
        }

        private void Intrligence_ValueChanged(object sender, EventArgs e)
        {
            if (unit != null)
            {
                unit.intelegence = Convert.ToInt32(Intrligence.Value);
            }
        }

        private void Strength_ValueChanged(object sender, EventArgs e)
        {
            if (unit != null)
            {
                unit.strength = Convert.ToInt32(Strength.Value);
            }
        }

        private void Constitution_ValueChanged(object sender, EventArgs e)
        {
            if (unit != null)
            {
                unit.constitution = Convert.ToInt32(Constitution.Value);
            }
        }

        private void Dexterity_ValueChanged(object sender, EventArgs e)
        {
            if (unit != null)
            {
                unit.dexterity = Convert.ToInt32(Dexterity.Value);
            }
        }

        private void Team_click_Click(object sender, EventArgs e)
        {
            SelectorUnits selectorUnits = new SelectorUnits();
            selectorUnits.Show();
        }
    }
}
