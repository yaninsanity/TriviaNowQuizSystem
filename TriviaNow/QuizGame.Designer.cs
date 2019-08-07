namespace TriviaNow
{
    partial class QuizGame
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
            this.questionTitleLabel = new System.Windows.Forms.Label();
            this.choice1Label = new System.Windows.Forms.Label();
            this.choice2Label = new System.Windows.Forms.Label();
            this.choice3Label = new System.Windows.Forms.Label();
            this.choice4Label = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.dChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.cChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.bChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.aChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.answerAndFeedbackLabel = new System.Windows.Forms.Label();
            this.saveAnswerButton = new System.Windows.Forms.Button();
            this.currentGradeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionTitleLabel
            // 
            this.questionTitleLabel.AutoSize = true;
            this.questionTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTitleLabel.Location = new System.Drawing.Point(21, 19);
            this.questionTitleLabel.Name = "questionTitleLabel";
            this.questionTitleLabel.Size = new System.Drawing.Size(139, 25);
            this.questionTitleLabel.TabIndex = 0;
            this.questionTitleLabel.Text = "QuestionTitle";
            // 
            // choice1Label
            // 
            this.choice1Label.AutoSize = true;
            this.choice1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1Label.Location = new System.Drawing.Point(58, 67);
            this.choice1Label.Name = "choice1Label";
            this.choice1Label.Size = new System.Drawing.Size(55, 16);
            this.choice1Label.TabIndex = 1;
            this.choice1Label.Text = "choice1";
            // 
            // choice2Label
            // 
            this.choice2Label.AutoSize = true;
            this.choice2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2Label.Location = new System.Drawing.Point(58, 99);
            this.choice2Label.Name = "choice2Label";
            this.choice2Label.Size = new System.Drawing.Size(55, 16);
            this.choice2Label.TabIndex = 2;
            this.choice2Label.Text = "choice2";
            // 
            // choice3Label
            // 
            this.choice3Label.AutoSize = true;
            this.choice3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice3Label.Location = new System.Drawing.Point(58, 135);
            this.choice3Label.Name = "choice3Label";
            this.choice3Label.Size = new System.Drawing.Size(55, 16);
            this.choice3Label.TabIndex = 3;
            this.choice3Label.Text = "choice3";
            // 
            // choice4Label
            // 
            this.choice4Label.AutoSize = true;
            this.choice4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice4Label.Location = new System.Drawing.Point(58, 171);
            this.choice4Label.Name = "choice4Label";
            this.choice4Label.Size = new System.Drawing.Size(55, 16);
            this.choice4Label.TabIndex = 4;
            this.choice4Label.Text = "choice4";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(252, 300);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(76, 39);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // dChoiceRadioButton
            // 
            this.dChoiceRadioButton.AutoSize = true;
            this.dChoiceRadioButton.Location = new System.Drawing.Point(11, 171);
            this.dChoiceRadioButton.Name = "dChoiceRadioButton";
            this.dChoiceRadioButton.Size = new System.Drawing.Size(33, 17);
            this.dChoiceRadioButton.TabIndex = 25;
            this.dChoiceRadioButton.TabStop = true;
            this.dChoiceRadioButton.Text = "D";
            this.dChoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // cChoiceRadioButton
            // 
            this.cChoiceRadioButton.AutoSize = true;
            this.cChoiceRadioButton.Location = new System.Drawing.Point(12, 135);
            this.cChoiceRadioButton.Name = "cChoiceRadioButton";
            this.cChoiceRadioButton.Size = new System.Drawing.Size(32, 17);
            this.cChoiceRadioButton.TabIndex = 24;
            this.cChoiceRadioButton.TabStop = true;
            this.cChoiceRadioButton.Text = "C";
            this.cChoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // bChoiceRadioButton
            // 
            this.bChoiceRadioButton.AutoSize = true;
            this.bChoiceRadioButton.Location = new System.Drawing.Point(12, 99);
            this.bChoiceRadioButton.Name = "bChoiceRadioButton";
            this.bChoiceRadioButton.Size = new System.Drawing.Size(32, 17);
            this.bChoiceRadioButton.TabIndex = 23;
            this.bChoiceRadioButton.TabStop = true;
            this.bChoiceRadioButton.Text = "B";
            this.bChoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // aChoiceRadioButton
            // 
            this.aChoiceRadioButton.AutoSize = true;
            this.aChoiceRadioButton.Location = new System.Drawing.Point(12, 67);
            this.aChoiceRadioButton.Name = "aChoiceRadioButton";
            this.aChoiceRadioButton.Size = new System.Drawing.Size(32, 17);
            this.aChoiceRadioButton.TabIndex = 22;
            this.aChoiceRadioButton.TabStop = true;
            this.aChoiceRadioButton.Text = "A";
            this.aChoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerAndFeedbackLabel
            // 
            this.answerAndFeedbackLabel.AutoSize = true;
            this.answerAndFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.answerAndFeedbackLabel.Location = new System.Drawing.Point(12, 210);
            this.answerAndFeedbackLabel.Name = "answerAndFeedbackLabel";
            this.answerAndFeedbackLabel.Size = new System.Drawing.Size(58, 13);
            this.answerAndFeedbackLabel.TabIndex = 26;
            this.answerAndFeedbackLabel.Text = "Feedback;";
            // 
            // saveAnswerButton
            // 
            this.saveAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAnswerButton.Location = new System.Drawing.Point(61, 300);
            this.saveAnswerButton.Name = "saveAnswerButton";
            this.saveAnswerButton.Size = new System.Drawing.Size(79, 39);
            this.saveAnswerButton.TabIndex = 27;
            this.saveAnswerButton.Text = "Save";
            this.saveAnswerButton.UseVisualStyleBackColor = true;
            this.saveAnswerButton.Click += new System.EventHandler(this.saveAnswer_Click);
            // 
            // currentGradeLabel
            // 
            this.currentGradeLabel.AutoSize = true;
            this.currentGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGradeLabel.Location = new System.Drawing.Point(388, 314);
            this.currentGradeLabel.Name = "currentGradeLabel";
            this.currentGradeLabel.Size = new System.Drawing.Size(67, 16);
            this.currentGradeLabel.TabIndex = 28;
            this.currentGradeLabel.Text = "Grade: 0";
            // 
            // QuizGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 363);
            this.Controls.Add(this.currentGradeLabel);
            this.Controls.Add(this.saveAnswerButton);
            this.Controls.Add(this.answerAndFeedbackLabel);
            this.Controls.Add(this.dChoiceRadioButton);
            this.Controls.Add(this.cChoiceRadioButton);
            this.Controls.Add(this.bChoiceRadioButton);
            this.Controls.Add(this.aChoiceRadioButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.choice4Label);
            this.Controls.Add(this.choice3Label);
            this.Controls.Add(this.choice2Label);
            this.Controls.Add(this.choice1Label);
            this.Controls.Add(this.questionTitleLabel);
            this.Name = "QuizGame";
            this.Text = "TriviaNow Quiz Management System---Quiz Game";
            this.Load += new System.EventHandler(this.QuizGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTitleLabel;
        private System.Windows.Forms.Label choice1Label;
        private System.Windows.Forms.Label choice2Label;
        private System.Windows.Forms.Label choice3Label;
        private System.Windows.Forms.Label choice4Label;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RadioButton dChoiceRadioButton;
        private System.Windows.Forms.RadioButton cChoiceRadioButton;
        private System.Windows.Forms.RadioButton bChoiceRadioButton;
        private System.Windows.Forms.RadioButton aChoiceRadioButton;
        private System.Windows.Forms.Label answerAndFeedbackLabel;
        private System.Windows.Forms.Button saveAnswerButton;
        private System.Windows.Forms.Label currentGradeLabel;
    }
}