using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OwnGame
{
    public partial class Game : Form
    {
        private FlowLayoutPanel[]? teamsGroupBoxes;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            MyOnwGame.GameStarted += MyOnwGame_GameStarted;
            MyOnwGame.NotifyGame += MyOnwGame_NotifyGame;
            MyOnwGame.StartGame();
        }

        private void MyOnwGame_NotifyGame(string obj)
        {
            MessageBox.Show(obj);
            UpdateData(MyOnwGame.GetTeams());
        }

        private void UpdateData(List<Team> teams)
        {
            if (teamsGroupBoxes is null)
            {
                teamsGroupBoxes = new FlowLayoutPanel[MyOnwGame.TeamCount];

                for (int i = 0; i < teamsGroupBoxes.Length; i++)
                {
                    teamsGroupBoxes[i] = new FlowLayoutPanel();

                    teamsGroupBoxes[i].Width = 200;
                    teamsGroupBoxes[i].Height = 178;
                }
            }

            foreach (FlowLayoutPanel panel in teamsGroupBoxes)
            {
                foreach (Control control in panel.Controls)
                {
                    panel.Controls.Remove(control);
                    control.Dispose();
                }
            }

            for (int i = 0; i < teamsGroupBoxes.Length; i++)
            {

                Label name = new Label();
                Label scores = new Label();
                Label _multiplier = new Label();

                Font font = new Font(FontFamily.GenericMonospace.Name, 15, FontStyle.Bold);
                name.Font = font;
                name.UseCompatibleTextRendering = true;

                name.Text = "-" + teams[i].Name + "-";
                scores.Text = $"Счёт: {teams[i].Score}";
                _multiplier.Text = $"Множитель: {teams[i].Multiplier}Х";

                teamsGroupBoxes[i].Controls.Add(name);
                teamsGroupBoxes[i].Controls.Add(scores);
                teamsGroupBoxes[i].Controls.Add(_multiplier);

                teams_flowLayoutPanel.Controls.Add(teamsGroupBoxes[i]);
            }
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.Enabled = false;
                int complexIndex = int.Parse(button.Text) / 10 - 1;
                int categoryIndex = int.Parse(button?.Tag.ToString() ?? "0");
                MyOnwGame.ShowQuestionDialog(categoryIndex, complexIndex);
            }
        }

        private void MyOnwGame_GameStarted(object? sender, GameStartedEventArgs e)
        {
            UpdateData(e.Teams);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.Show();
            Hide();
            finalForm.FormClosed += FinalForm_FormClosed;
        }

        private void FinalForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
