using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnGame
{
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            var teamsRating = from team in MyOnwGame.GetTeams() 
                             orderby team.Score descending
                              select team;

            int place = 1;
            foreach (Team team in teamsRating)
            {
                richTextBox1.Text += $"{place} - {team.Name} ({team.Score} баллов)\n";
                place++;
            }
        }
    }
}
