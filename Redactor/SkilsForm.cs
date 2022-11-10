using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor
{
    public partial class SkilsForm : Form
    {
        Unit Unit { get; set; }
        public SkilsForm(Unit unit)
        {
            InitializeComponent();
            Unit = unit;
        }

        private void Skill_one_Click(object sender, EventArgs e)
        {
            Unit.skill = "Fire Ball";
            this.Hide();
        }

        private void Skill_two_Click(object sender, EventArgs e)
        {
            Unit.skill = "Berserker's Call";
            this.Hide();
        }

        private void Skill_three_Click(object sender, EventArgs e)
        {
            Unit.skill = "Blink";   
            this.Hide();
        }
    }
}
