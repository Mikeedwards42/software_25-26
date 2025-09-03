namespace tiktactoe
{
    partial class Form1
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
            b1 = new Button();
            b6 = new Button();
            b2 = new Button();
            b5 = new Button();
            b4 = new Button();
            b9 = new Button();
            b3 = new Button();
            b7 = new Button();
            b8 = new Button();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b1.Location = new Point(227, 50);
            b1.Name = "b1";
            b1.Size = new Size(75, 107);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b6.Location = new Point(391, 163);
            b6.Name = "b6";
            b6.Size = new Size(78, 107);
            b6.TabIndex = 1;
            b6.UseVisualStyleBackColor = true;
            b6.Click += b1_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b2.Location = new Point(311, 50);
            b2.Name = "b2";
            b2.Size = new Size(74, 107);
            b2.TabIndex = 2;
            b2.UseVisualStyleBackColor = true;
            b2.Click += b1_Click;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b5.Location = new Point(311, 163);
            b5.Name = "b5";
            b5.Size = new Size(74, 107);
            b5.TabIndex = 3;
            b5.UseVisualStyleBackColor = true;
            b5.Click += b1_Click;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b4.Location = new Point(227, 163);
            b4.Name = "b4";
            b4.Size = new Size(78, 107);
            b4.TabIndex = 4;
            b4.UseVisualStyleBackColor = true;
            b4.Click += b1_Click;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b9.Location = new Point(391, 281);
            b9.Name = "b9";
            b9.Size = new Size(76, 107);
            b9.TabIndex = 5;
            b9.UseVisualStyleBackColor = true;
            b9.Click += b1_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b3.Location = new Point(391, 50);
            b3.Name = "b3";
            b3.Size = new Size(78, 107);
            b3.TabIndex = 6;
            b3.UseVisualStyleBackColor = true;
            b3.Click += b1_Click;
            // 
            // b7
            // 
            b7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b7.Location = new Point(227, 281);
            b7.Name = "b7";
            b7.Size = new Size(78, 107);
            b7.TabIndex = 7;
            b7.UseVisualStyleBackColor = true;
            b7.Click += b1_Click;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b8.Location = new Point(311, 281);
            b8.Name = "b8";
            b8.Size = new Size(74, 107);
            b8.TabIndex = 8;
            b8.UseVisualStyleBackColor = true;
            b8.Click += b1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b3);
            Controls.Add(b9);
            Controls.Add(b4);
            Controls.Add(b5);
            Controls.Add(b2);
            Controls.Add(b6);
            Controls.Add(b1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button b1;
        private Button b6;
        private Button b2;
        private Button b5;
        private Button b4;
        private Button b9;
        private Button b3;
        private Button b7;
        private Button b8;
    }
}
