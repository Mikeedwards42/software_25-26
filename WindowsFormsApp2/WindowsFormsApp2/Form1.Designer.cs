namespace WindowsFormsApp2
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
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.difficulty = new System.Windows.Forms.Label();
            this.chkPlayerStarts = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(290, 30);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(45, 44);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(341, 30);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(45, 44);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(392, 30);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(45, 44);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(290, 80);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(45, 44);
            this.btn10.TabIndex = 3;
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(341, 80);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(45, 44);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(392, 80);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(45, 44);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(290, 130);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(45, 44);
            this.btn20.TabIndex = 6;
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(341, 130);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(45, 44);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(392, 130);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(45, 44);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(278, 277);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 16);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "turn : x";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(278, 310);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(177, 16);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score — You: 0 AI: 0 Draws: 0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(304, 340);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 24);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "New Game";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(304, 200);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(121, 24);
            this.cmbDifficulty.TabIndex = 12;
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = true;
            this.difficulty.Location = new System.Drawing.Point(330, 181);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(56, 16);
            this.difficulty.TabIndex = 13;
            this.difficulty.Text = "Difficulty";
            // 
            // chkPlayerStarts
            // 
            this.chkPlayerStarts.AutoSize = true;
            this.chkPlayerStarts.Location = new System.Drawing.Point(304, 230);
            this.chkPlayerStarts.Name = "chkPlayerStarts";
            this.chkPlayerStarts.Size = new System.Drawing.Size(122, 20);
            this.chkPlayerStarts.TabIndex = 14;
            this.chkPlayerStarts.Text = "Player starts (X)";
            this.chkPlayerStarts.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkPlayerStarts);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label difficulty;
        private System.Windows.Forms.CheckBox chkPlayerStarts;
    }
}

