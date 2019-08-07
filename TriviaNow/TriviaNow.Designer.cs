namespace TriviaNow
{
    partial class TriviaNow
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.questionNumDisplayLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.playButton = new System.Windows.Forms.Button();
            this.battleButton = new System.Windows.Forms.Button();
            this.quizQuestionNumberTextBox = new System.Windows.Forms.TextBox();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(421, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveQuestionsToolStripMenuItem,
            this.openQuestionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveQuestionsToolStripMenuItem
            // 
            this.saveQuestionsToolStripMenuItem.Name = "saveQuestionsToolStripMenuItem";
            this.saveQuestionsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveQuestionsToolStripMenuItem.Text = "&Save Questions";
            this.saveQuestionsToolStripMenuItem.Click += new System.EventHandler(this.saveQuestionsToolStripMenuItem_Click);
            // 
            // openQuestionsToolStripMenuItem
            // 
            this.openQuestionsToolStripMenuItem.Name = "openQuestionsToolStripMenuItem";
            this.openQuestionsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openQuestionsToolStripMenuItem.Text = "&Open Questions";
            this.openQuestionsToolStripMenuItem.Click += new System.EventHandler(this.openQuestionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionToolStripMenuItem,
            this.viewQuestionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addQuestionToolStripMenuItem
            // 
            this.addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            this.addQuestionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addQuestionToolStripMenuItem.Text = "Add &Question";
            this.addQuestionToolStripMenuItem.Click += new System.EventHandler(this.addQuestionToolStripMenuItem_Click);
            // 
            // viewQuestionToolStripMenuItem
            // 
            this.viewQuestionToolStripMenuItem.Name = "viewQuestionToolStripMenuItem";
            this.viewQuestionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewQuestionToolStripMenuItem.Text = "&View and Edit Question";
            this.viewQuestionToolStripMenuItem.Click += new System.EventHandler(this.viewQuestionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = " &Help";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.readMeToolStripMenuItem.Text = "Read Me!";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.readMeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 240);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(421, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.Text = "Ready;";
            // 
            // questionNumDisplayLabel
            // 
            this.questionNumDisplayLabel.AutoSize = true;
            this.questionNumDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumDisplayLabel.Location = new System.Drawing.Point(22, 59);
            this.questionNumDisplayLabel.Name = "questionNumDisplayLabel";
            this.questionNumDisplayLabel.Size = new System.Drawing.Size(189, 24);
            this.questionNumDisplayLabel.TabIndex = 4;
            this.questionNumDisplayLabel.Text = "Number Of Question:";
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(41, 170);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(125, 43);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // battleButton
            // 
            this.battleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleButton.Location = new System.Drawing.Point(258, 170);
            this.battleButton.Name = "battleButton";
            this.battleButton.Size = new System.Drawing.Size(125, 43);
            this.battleButton.TabIndex = 7;
            this.battleButton.Text = "1v1 Battle";
            this.battleButton.UseVisualStyleBackColor = true;
            this.battleButton.Click += new System.EventHandler(this.battleButton_Click);
            // 
            // quizQuestionNumberTextBox
            // 
            this.quizQuestionNumberTextBox.Location = new System.Drawing.Point(227, 121);
            this.quizQuestionNumberTextBox.Name = "quizQuestionNumberTextBox";
            this.quizQuestionNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.quizQuestionNumberTextBox.TabIndex = 8;
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.Location = new System.Drawing.Point(26, 120);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(185, 18);
            this.questionNumberLabel.TabIndex = 9;
            this.questionNumberLabel.Text = "Quiz Question Number:";
            // 
            // TriviaNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 262);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.quizQuestionNumberTextBox);
            this.Controls.Add(this.battleButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.questionNumDisplayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TriviaNow";
            this.Text = "TriviaNow Quiz Management System---Main";
            this.Load += new System.EventHandler(this.TriviaNow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label questionNumDisplayLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem saveQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openQuestionsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button battleButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.TextBox quizQuestionNumberTextBox;
        private System.Windows.Forms.Label questionNumberLabel;
    }
}

