namespace OwnGame
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_label.Font = new System.Drawing.Font("Sitka Small", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.start_label.Location = new System.Drawing.Point(-6, 101);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(689, 69);
            this.start_label.TabIndex = 0;
            this.start_label.Text = "Игра по Д.И. Менделееву";
            this.start_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_label.Click += new System.EventHandler(this.start_label_Click);
            this.start_label.MouseLeave += new System.EventHandler(this.start_label_MouseLeave);
            this.start_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.start_label_MouseMove);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 283);
            this.Controls.Add(this.start_label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Text = "Своя игра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label start_label;
    }
}