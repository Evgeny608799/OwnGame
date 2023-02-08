namespace OwnGame
{
    partial class AddTeams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTeam_button = new System.Windows.Forms.Button();
            this.teams_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTeam_button
            // 
            this.addTeam_button.Location = new System.Drawing.Point(176, 110);
            this.addTeam_button.Name = "addTeam_button";
            this.addTeam_button.Size = new System.Drawing.Size(368, 143);
            this.addTeam_button.TabIndex = 0;
            this.addTeam_button.Text = "Добавить команду";
            this.addTeam_button.UseVisualStyleBackColor = true;
            this.addTeam_button.Click += new System.EventHandler(this.addTeam_button_Click);
            // 
            // teams_label
            // 
            this.teams_label.AutoSize = true;
            this.teams_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.teams_label.Location = new System.Drawing.Point(12, 275);
            this.teams_label.Name = "teams_label";
            this.teams_label.Size = new System.Drawing.Size(110, 30);
            this.teams_label.TabIndex = 1;
            this.teams_label.Text = "Команды:";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(176, 55);
            this.name_textBox.MaxLength = 32;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(368, 23);
            this.name_textBox.TabIndex = 2;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(611, 346);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(140, 86);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "Начать";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // AddTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 444);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.teams_label);
            this.Controls.Add(this.addTeam_button);
            this.Name = "AddTeams";
            this.Text = "AddTeams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addTeam_button;
        private Label teams_label;
        private TextBox name_textBox;
        private Button start_button;
    }
}