namespace OwnGame
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void start_label_Click(object sender, EventArgs e)
        {
            AddTeams addTeamsForm = new AddTeams();
            addTeamsForm.Show();
            Hide();
            addTeamsForm.FormClosed += AddTeams_FormClosed;
        }

        private void AddTeams_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void start_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Label text)
            {
                text.ForeColor = Color.Red;
            }
        }

        private void start_label_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label text)
            {
                text.ForeColor = Color.Black;
            }
        }
    }
}