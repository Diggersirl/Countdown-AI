namespace NumbersGame
{
    partial class NumberSelection
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
            this.lblLargeNums = new System.Windows.Forms.Label();
            this.lblSmallNums = new System.Windows.Forms.Label();
            this.cmbLargeNums = new System.Windows.Forms.ComboBox();
            this.cmbSmallNums = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLargeNums
            // 
            this.lblLargeNums.AutoSize = true;
            this.lblLargeNums.Location = new System.Drawing.Point(46, 83);
            this.lblLargeNums.Name = "lblLargeNums";
            this.lblLargeNums.Size = new System.Drawing.Size(111, 13);
            this.lblLargeNums.TabIndex = 0;
            this.lblLargeNums.Text = "No. of Large Numbers";
            // 
            // lblSmallNums
            // 
            this.lblSmallNums.AutoSize = true;
            this.lblSmallNums.Location = new System.Drawing.Point(235, 83);
            this.lblSmallNums.Name = "lblSmallNums";
            this.lblSmallNums.Size = new System.Drawing.Size(109, 13);
            this.lblSmallNums.TabIndex = 1;
            this.lblSmallNums.Text = "No. of Small Numbers";
            // 
            // cmbLargeNums
            // 
            this.cmbLargeNums.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLargeNums.FormattingEnabled = true;
            this.cmbLargeNums.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbLargeNums.Location = new System.Drawing.Point(49, 118);
            this.cmbLargeNums.Name = "cmbLargeNums";
            this.cmbLargeNums.Size = new System.Drawing.Size(115, 21);
            this.cmbLargeNums.TabIndex = 2;
            this.cmbLargeNums.SelectedIndexChanged += new System.EventHandler(this.cmbLargeNums_SelectedIndexChanged);
            this.cmbLargeNums.TextUpdate += new System.EventHandler(this.cmbLargeNums_SelectedIndexChanged);
            // 
            // cmbSmallNums
            // 
            this.cmbSmallNums.FormattingEnabled = true;
            this.cmbSmallNums.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbSmallNums.Location = new System.Drawing.Point(238, 118);
            this.cmbSmallNums.Name = "cmbSmallNums";
            this.cmbSmallNums.Size = new System.Drawing.Size(115, 21);
            this.cmbSmallNums.TabIndex = 3;
            this.cmbSmallNums.SelectedIndexChanged += new System.EventHandler(this.cmbSmallNums_SelectedIndexChanged);
            this.cmbSmallNums.TextUpdate += new System.EventHandler(this.cmbSmallNums_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(197, 183);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(106, 39);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit Decision";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(389, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Select No. of Large and Small Numbers you wish to play with";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(115, 40);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(199, 16);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "A Total of 6 Numbers is required";
            // 
            // NumberSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 271);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbSmallNums);
            this.Controls.Add(this.cmbLargeNums);
            this.Controls.Add(this.lblSmallNums);
            this.Controls.Add(this.lblLargeNums);
            this.Name = "NumberSelection";
            this.Text = "NumberSelection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumberSelection_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLargeNums;
        private System.Windows.Forms.Label lblSmallNums;
        private System.Windows.Forms.ComboBox cmbLargeNums;
        private System.Windows.Forms.ComboBox cmbSmallNums;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
    }
}