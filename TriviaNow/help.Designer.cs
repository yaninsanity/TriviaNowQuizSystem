namespace TriviaNow
{
    partial class help
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
            this.readMeLabel = new System.Windows.Forms.Label();
            this.understandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readMeLabel
            // 
            this.readMeLabel.AutoSize = true;
            this.readMeLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readMeLabel.ForeColor = System.Drawing.Color.Red;
            this.readMeLabel.Location = new System.Drawing.Point(12, 25);
            this.readMeLabel.Name = "readMeLabel";
            this.readMeLabel.Size = new System.Drawing.Size(77, 15);
            this.readMeLabel.TabIndex = 0;
            this.readMeLabel.Text = "Read ME!!!!";
            // 
            // understandButton
            // 
            this.understandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.understandButton.Location = new System.Drawing.Point(139, 223);
            this.understandButton.Name = "understandButton";
            this.understandButton.Size = new System.Drawing.Size(154, 41);
            this.understandButton.TabIndex = 1;
            this.understandButton.Text = "Understand";
            this.understandButton.UseVisualStyleBackColor = true;
            this.understandButton.Click += new System.EventHandler(this.understandButton_Click);
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 276);
            this.Controls.Add(this.understandButton);
            this.Controls.Add(this.readMeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "help";
            this.Text = "TriviaNow Quiz Management System---Help";
            this.Load += new System.EventHandler(this.help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label readMeLabel;
        private System.Windows.Forms.Button understandButton;
    }
}