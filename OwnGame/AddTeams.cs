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
    public partial class AddTeams : Form
    {
        public AddTeams()
        {
            InitializeComponent();
        }

        private void addTeam_button_Click(object sender, EventArgs e)
        {
            string name = name_textBox.Text;

            MyOnwGame.AddTeam(new Team(name));

            teams_label.Text += "\n" + name;

            name_textBox.Clear();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            Game gameForm = new Game();
            gameForm.Show();
            gameForm.FormClosed += GameFormClosed;
            Hide();
        }

        private void GameFormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
