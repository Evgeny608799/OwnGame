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
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }

        public Team? Team { get; set; }
        public List<Team>? Teams { get; set; }
        public Complexity Complexity { get; set; }
        private string? currentTeamName => ComboBox.SelectedItem.ToString();

        private void button3_Click(object sender, EventArgs e)
        {
            Answer.Visible = true;
            button3.Visible = false;
            button3.Enabled = false;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            if (Teams != null)
            {
                foreach (var t in Teams)
                {
                    ComboBox.Items.Add(t.Name);
                }
                ComboBox.Text = Team?.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Team != null)
            {
                if (Team.Name == currentTeamName)
                {
                    Team.AddScores((int)Complexity);
                }
                else if (Teams is not null)
                {
                    foreach (Team t in Teams)
                    {
                        if (t.Name == currentTeamName)
                        {
                            t.AddScores((int)Complexity / 2);
                        }
                    }
                    Team.ResetMultiplier();
                }
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Team?.ResetMultiplier();
            Close();
        }
    }
}
