namespace NumbersGame
{
    partial class Form1
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
            this.lblComputerResults = new System.Windows.Forms.Label();
            this.lblPlayerEq = new System.Windows.Forms.Label();
            this.grpNumbers = new System.Windows.Forms.GroupBox();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.grpOperators = new System.Windows.Forms.GroupBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblGoalDisplay = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblCountdownDisplay = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.AiWorker = new System.ComponentModel.BackgroundWorker();
            this.lblPlayerCurrentAnswer = new System.Windows.Forms.Label();
            this.lblPlayerResults = new System.Windows.Forms.Label();
            this.grpBrackets = new System.Windows.Forms.GroupBox();
            this.btnCloseBracket = new System.Windows.Forms.Button();
            this.btnOpenBracket = new System.Windows.Forms.Button();
            this.grpScoreBoard = new System.Windows.Forms.GroupBox();
            this.lblComputerScoreDisplay = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblPlayerScoreDisplay = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblRoundNo = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.grpNumbers.SuspendLayout();
            this.grpOperators.SuspendLayout();
            this.grpBrackets.SuspendLayout();
            this.grpScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblComputerResults
            // 
            this.lblComputerResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblComputerResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComputerResults.Location = new System.Drawing.Point(119, 186);
            this.lblComputerResults.Name = "lblComputerResults";
            this.lblComputerResults.Size = new System.Drawing.Size(301, 61);
            this.lblComputerResults.TabIndex = 0;
            // 
            // lblPlayerEq
            // 
            this.lblPlayerEq.BackColor = System.Drawing.Color.White;
            this.lblPlayerEq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerEq.Location = new System.Drawing.Point(175, 321);
            this.lblPlayerEq.Name = "lblPlayerEq";
            this.lblPlayerEq.Size = new System.Drawing.Size(187, 27);
            this.lblPlayerEq.TabIndex = 1;
            this.lblPlayerEq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpNumbers
            // 
            this.grpNumbers.Controls.Add(this.btnNum6);
            this.grpNumbers.Controls.Add(this.btnNum5);
            this.grpNumbers.Controls.Add(this.btnNum4);
            this.grpNumbers.Controls.Add(this.btnNum3);
            this.grpNumbers.Controls.Add(this.btnNum2);
            this.grpNumbers.Controls.Add(this.btnNum1);
            this.grpNumbers.Location = new System.Drawing.Point(48, 379);
            this.grpNumbers.Name = "grpNumbers";
            this.grpNumbers.Size = new System.Drawing.Size(220, 131);
            this.grpNumbers.TabIndex = 2;
            this.grpNumbers.TabStop = false;
            this.grpNumbers.Text = "Numbers";
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(149, 79);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(46, 38);
            this.btnNum6.TabIndex = 5;
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(87, 79);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(46, 38);
            this.btnNum5.TabIndex = 4;
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(25, 79);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(46, 38);
            this.btnNum4.TabIndex = 3;
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(149, 20);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(46, 38);
            this.btnNum3.TabIndex = 2;
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(87, 20);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(46, 38);
            this.btnNum2.TabIndex = 1;
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(25, 20);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(46, 38);
            this.btnNum1.TabIndex = 0;
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // grpOperators
            // 
            this.grpOperators.Controls.Add(this.btnDivide);
            this.grpOperators.Controls.Add(this.btnMultiply);
            this.grpOperators.Controls.Add(this.btnSubtract);
            this.grpOperators.Controls.Add(this.btnAdd);
            this.grpOperators.Location = new System.Drawing.Point(297, 379);
            this.grpOperators.Name = "grpOperators";
            this.grpOperators.Size = new System.Drawing.Size(200, 131);
            this.grpOperators.TabIndex = 3;
            this.grpOperators.TabStop = false;
            this.grpOperators.Text = "Operators";
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(113, 78);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(64, 38);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(28, 78);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(64, 38);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(113, 20);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(64, 38);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(28, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblGoalDisplay
            // 
            this.lblGoalDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblGoalDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGoalDisplay.Location = new System.Drawing.Point(154, 130);
            this.lblGoalDisplay.Name = "lblGoalDisplay";
            this.lblGoalDisplay.Size = new System.Drawing.Size(103, 41);
            this.lblGoalDisplay.TabIndex = 4;
            this.lblGoalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(113, 149);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(29, 13);
            this.lblGoal.TabIndex = 5;
            this.lblGoal.Text = "Goal";
            // 
            // lblCountdownDisplay
            // 
            this.lblCountdownDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCountdownDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountdownDisplay.Location = new System.Drawing.Point(340, 130);
            this.lblCountdownDisplay.Name = "lblCountdownDisplay";
            this.lblCountdownDisplay.Size = new System.Drawing.Size(103, 41);
            this.lblCountdownDisplay.TabIndex = 6;
            this.lblCountdownDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(273, 149);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(61, 13);
            this.lblCountdown.TabIndex = 7;
            this.lblCountdown.Text = "Countdown";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(301, 532);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 36);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit Answer";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(410, 532);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Answer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AiWorker
            // 
            this.AiWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AiWorker_DoWork);
            this.AiWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AiWorker_RunWorkerCompleted);
            // 
            // lblPlayerCurrentAnswer
            // 
            this.lblPlayerCurrentAnswer.BackColor = System.Drawing.Color.White;
            this.lblPlayerCurrentAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerCurrentAnswer.Location = new System.Drawing.Point(383, 321);
            this.lblPlayerCurrentAnswer.Name = "lblPlayerCurrentAnswer";
            this.lblPlayerCurrentAnswer.Size = new System.Drawing.Size(61, 27);
            this.lblPlayerCurrentAnswer.TabIndex = 10;
            this.lblPlayerCurrentAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerResults
            // 
            this.lblPlayerResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPlayerResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerResults.Location = new System.Drawing.Point(119, 247);
            this.lblPlayerResults.Name = "lblPlayerResults";
            this.lblPlayerResults.Size = new System.Drawing.Size(301, 61);
            this.lblPlayerResults.TabIndex = 11;
            // 
            // grpBrackets
            // 
            this.grpBrackets.Controls.Add(this.btnCloseBracket);
            this.grpBrackets.Controls.Add(this.btnOpenBracket);
            this.grpBrackets.Location = new System.Drawing.Point(59, 522);
            this.grpBrackets.Name = "grpBrackets";
            this.grpBrackets.Size = new System.Drawing.Size(145, 68);
            this.grpBrackets.TabIndex = 12;
            this.grpBrackets.TabStop = false;
            this.grpBrackets.Text = "Brackets";
            // 
            // btnCloseBracket
            // 
            this.btnCloseBracket.Enabled = false;
            this.btnCloseBracket.Location = new System.Drawing.Point(76, 19);
            this.btnCloseBracket.Name = "btnCloseBracket";
            this.btnCloseBracket.Size = new System.Drawing.Size(46, 37);
            this.btnCloseBracket.TabIndex = 1;
            this.btnCloseBracket.Text = ")";
            this.btnCloseBracket.UseVisualStyleBackColor = true;
            this.btnCloseBracket.Click += new System.EventHandler(this.btnCloseBracket_Click);
            // 
            // btnOpenBracket
            // 
            this.btnOpenBracket.Location = new System.Drawing.Point(14, 19);
            this.btnOpenBracket.Name = "btnOpenBracket";
            this.btnOpenBracket.Size = new System.Drawing.Size(46, 37);
            this.btnOpenBracket.TabIndex = 0;
            this.btnOpenBracket.Text = "(";
            this.btnOpenBracket.UseVisualStyleBackColor = true;
            this.btnOpenBracket.Click += new System.EventHandler(this.btnOpenBracket_Click);
            // 
            // grpScoreBoard
            // 
            this.grpScoreBoard.Controls.Add(this.lblComputerScoreDisplay);
            this.grpScoreBoard.Controls.Add(this.lblComputerScore);
            this.grpScoreBoard.Controls.Add(this.lblPlayerScoreDisplay);
            this.grpScoreBoard.Controls.Add(this.lblPlayerScore);
            this.grpScoreBoard.Location = new System.Drawing.Point(99, 55);
            this.grpScoreBoard.Name = "grpScoreBoard";
            this.grpScoreBoard.Size = new System.Drawing.Size(358, 63);
            this.grpScoreBoard.TabIndex = 14;
            this.grpScoreBoard.TabStop = false;
            this.grpScoreBoard.Text = "Scoreboard";
            // 
            // lblComputerScoreDisplay
            // 
            this.lblComputerScoreDisplay.BackColor = System.Drawing.Color.White;
            this.lblComputerScoreDisplay.Location = new System.Drawing.Point(238, 28);
            this.lblComputerScoreDisplay.Name = "lblComputerScoreDisplay";
            this.lblComputerScoreDisplay.Size = new System.Drawing.Size(71, 22);
            this.lblComputerScoreDisplay.TabIndex = 3;
            this.lblComputerScoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Location = new System.Drawing.Point(174, 28);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(52, 13);
            this.lblComputerScore.TabIndex = 2;
            this.lblComputerScore.Text = "Computer";
            // 
            // lblPlayerScoreDisplay
            // 
            this.lblPlayerScoreDisplay.BackColor = System.Drawing.Color.White;
            this.lblPlayerScoreDisplay.Location = new System.Drawing.Point(73, 28);
            this.lblPlayerScoreDisplay.Name = "lblPlayerScoreDisplay";
            this.lblPlayerScoreDisplay.Size = new System.Drawing.Size(71, 22);
            this.lblPlayerScoreDisplay.TabIndex = 1;
            this.lblPlayerScoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(17, 28);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(36, 13);
            this.lblPlayerScore.TabIndex = 0;
            this.lblPlayerScore.Text = "Player";
            // 
            // lblRoundNo
            // 
            this.lblRoundNo.AutoSize = true;
            this.lblRoundNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNo.Location = new System.Drawing.Point(211, 21);
            this.lblRoundNo.Name = "lblRoundNo";
            this.lblRoundNo.Size = new System.Drawing.Size(57, 20);
            this.lblRoundNo.TabIndex = 15;
            this.lblRoundNo.Text = "Round";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(422, 9);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lblDifficulty.TabIndex = 16;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 610);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblRoundNo);
            this.Controls.Add(this.grpScoreBoard);
            this.Controls.Add(this.grpBrackets);
            this.Controls.Add(this.lblPlayerResults);
            this.Controls.Add(this.lblPlayerCurrentAnswer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblCountdownDisplay);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblGoalDisplay);
            this.Controls.Add(this.grpOperators);
            this.Controls.Add(this.grpNumbers);
            this.Controls.Add(this.lblPlayerEq);
            this.Controls.Add(this.lblComputerResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNumbers.ResumeLayout(false);
            this.grpOperators.ResumeLayout(false);
            this.grpBrackets.ResumeLayout(false);
            this.grpScoreBoard.ResumeLayout(false);
            this.grpScoreBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComputerResults;
        private System.Windows.Forms.Label lblPlayerEq;
        private System.Windows.Forms.GroupBox grpNumbers;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.GroupBox grpOperators;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblGoalDisplay;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblCountdownDisplay;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.ComponentModel.BackgroundWorker AiWorker;
        private System.Windows.Forms.Label lblPlayerCurrentAnswer;
        private System.Windows.Forms.Label lblPlayerResults;
        private System.Windows.Forms.GroupBox grpBrackets;
        private System.Windows.Forms.Button btnCloseBracket;
        private System.Windows.Forms.Button btnOpenBracket;
        private System.Windows.Forms.GroupBox grpScoreBoard;
        private System.Windows.Forms.Label lblComputerScoreDisplay;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblPlayerScoreDisplay;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblRoundNo;
        private System.Windows.Forms.Label lblDifficulty;
    }
}

