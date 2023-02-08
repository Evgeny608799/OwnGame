namespace OwnGame
{
    partial class QuestionForm
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
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(608, 36);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(213, 23);
            this.ComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ответ: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(735, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(735, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 75);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer.Location = new System.Drawing.Point(120, 375);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(52, 21);
            this.Answer.TabIndex = 5;
            this.Answer.Text = "label2";
            this.Answer.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(538, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "Показать ответ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Question
            // 
            this.Question.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Question.Location = new System.Drawing.Point(30, 36);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(572, 291);
            this.Question.TabIndex = 7;
            this.Question.Text = "Вопрос:";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 501);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal ComboBox ComboBox;
        internal Label label1;
        private Button button1;
        private Button button2;
        internal Label Answer;
        private Button button3;
        internal RichTextBox Question;
    }
}