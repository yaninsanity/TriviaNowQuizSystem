﻿namespace TriviaNow
{
    partial class EditQuestion
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
            this.updateButton = new System.Windows.Forms.Button();
            this.feedbackTextBox = new System.Windows.Forms.TextBox();
            this.dChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.cChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.bChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.choiceATextBox = new System.Windows.Forms.TextBox();
            this.choiceCTextBox = new System.Windows.Forms.TextBox();
            this.choiceBTextBox = new System.Windows.Forms.TextBox();
            this.aChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.choiceDTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(94, 274);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(276, 47);
            this.updateButton.TabIndex = 35;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Location = new System.Drawing.Point(31, 162);
            this.feedbackTextBox.Multiline = true;
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(418, 106);
            this.feedbackTextBox.TabIndex = 34;
            this.feedbackTextBox.Text = "Feedback:";
            // 
            // dChoiceRadioButton
            // 
            this.dChoiceRadioButton.AutoSize = true;
            this.dChoiceRadioButton.Location = new System.Drawing.Point(55, 128);
            this.dChoiceRadioButton.Name = "dChoiceRadioButton";
            this.dChoiceRadioButton.Size = new System.Drawing.Size(33, 17);
            this.dChoiceRadioButton.TabIndex = 33;
            this.dChoiceRadioButton.TabStop = true;
            this.dChoiceRadioButton.Text = "D";
            this.dChoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // cChoiceRadioButton
            // 
            this.cChoiceRadioButton.AutoSize = true;
            this.cChoiceRadioButton.Location = new System.Drawing.Point(55, 105);
            this.cChoiceRadioButton.Name = "cChoiceRadioButton";
            this.cChoiceRadioButton.Size = new System.Drawing.Size(32, 17);
            this.cChoiceRadioButton.TabIndex = 32;
            this.cChoiceRadioButton.TabStop = true;
            this.cChoiceRadioButton.Text = "C";
            this.cChoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // bChoiceRadioButton
            // 
            this.bChoiceRadioButton.AutoSize = true;
            this.bChoiceRadioButton.Location = new System.Drawing.Point(55, 82);
            this.bChoiceRadioButton.Name = "bChoiceRadioButton";
            this.bChoiceRadioButton.Size = new System.Drawing.Size(32, 17);
            this.bChoiceRadioButton.TabIndex = 31;
            this.bChoiceRadioButton.TabStop = true;
            this.bChoiceRadioButton.Text = "B";
            this.bChoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // choiceATextBox
            // 
            this.choiceATextBox.Location = new System.Drawing.Point(94, 47);
            this.choiceATextBox.Name = "choiceATextBox";
            this.choiceATextBox.Size = new System.Drawing.Size(325, 20);
            this.choiceATextBox.TabIndex = 24;
            // 
            // choiceCTextBox
            // 
            this.choiceCTextBox.Location = new System.Drawing.Point(94, 99);
            this.choiceCTextBox.Name = "choiceCTextBox";
            this.choiceCTextBox.Size = new System.Drawing.Size(325, 20);
            this.choiceCTextBox.TabIndex = 25;
            // 
            // choiceBTextBox
            // 
            this.choiceBTextBox.Location = new System.Drawing.Point(94, 73);
            this.choiceBTextBox.Name = "choiceBTextBox";
            this.choiceBTextBox.Size = new System.Drawing.Size(325, 20);
            this.choiceBTextBox.TabIndex = 26;
            // 
            // aChoiceRadioButton
            // 
            this.aChoiceRadioButton.AutoSize = true;
            this.aChoiceRadioButton.Location = new System.Drawing.Point(55, 57);
            this.aChoiceRadioButton.Name = "aChoiceRadioButton";
            this.aChoiceRadioButton.Size = new System.Drawing.Size(32, 17);
            this.aChoiceRadioButton.TabIndex = 30;
            this.aChoiceRadioButton.TabStop = true;
            this.aChoiceRadioButton.Text = "A";
            this.aChoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // choiceDTextBox
            // 
            this.choiceDTextBox.Location = new System.Drawing.Point(94, 125);
            this.choiceDTextBox.Name = "choiceDTextBox";
            this.choiceDTextBox.Size = new System.Drawing.Size(325, 20);
            this.choiceDTextBox.TabIndex = 27;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(17, 18);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(52, 13);
            this.questionLabel.TabIndex = 29;
            this.questionLabel.Text = "Question:";
            // 
            // questionTextbox
            // 
            this.questionTextbox.Location = new System.Drawing.Point(81, 15);
            this.questionTextbox.Name = "questionTextbox";
            this.questionTextbox.Size = new System.Drawing.Size(338, 20);
            this.questionTextbox.TabIndex = 28;
            // 
            // EditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 336);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.dChoiceRadioButton);
            this.Controls.Add(this.cChoiceRadioButton);
            this.Controls.Add(this.bChoiceRadioButton);
            this.Controls.Add(this.choiceATextBox);
            this.Controls.Add(this.choiceCTextBox);
            this.Controls.Add(this.choiceBTextBox);
            this.Controls.Add(this.aChoiceRadioButton);
            this.Controls.Add(this.choiceDTextBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionTextbox);
            this.Name = "EditQuestion";
            this.Text = "TriviaNow Quiz Management System---Edit Question";
            this.Load += new System.EventHandler(this.EditQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox feedbackTextBox;
        private System.Windows.Forms.RadioButton dChoiceRadioButton;
        private System.Windows.Forms.RadioButton cChoiceRadioButton;
        private System.Windows.Forms.RadioButton bChoiceRadioButton;
        private System.Windows.Forms.TextBox choiceATextBox;
        private System.Windows.Forms.TextBox choiceCTextBox;
        private System.Windows.Forms.TextBox choiceBTextBox;
        private System.Windows.Forms.RadioButton aChoiceRadioButton;
        private System.Windows.Forms.TextBox choiceDTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox questionTextbox;
    }
}