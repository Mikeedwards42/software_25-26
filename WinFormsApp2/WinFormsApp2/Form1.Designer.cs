namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Rcalc = new Button();
            RP = new TextBox();
            RA = new TextBox();
            lb3 = new Label();
            lb1 = new Label();
            RW = new TextBox();
            RL = new TextBox();
            lb2 = new Label();
            lb = new Label();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            SS = new TextBox();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 427);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(Rcalc);
            tabPage1.Controls.Add(RP);
            tabPage1.Controls.Add(RA);
            tabPage1.Controls.Add(lb3);
            tabPage1.Controls.Add(lb1);
            tabPage1.Controls.Add(RW);
            tabPage1.Controls.Add(RL);
            tabPage1.Controls.Add(lb2);
            tabPage1.Controls.Add(lb);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 394);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Rectangle";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Rcalc
            // 
            Rcalc.Location = new Point(241, 200);
            Rcalc.Name = "Rcalc";
            Rcalc.Size = new Size(94, 38);
            Rcalc.TabIndex = 8;
            Rcalc.Text = "calculate";
            Rcalc.UseVisualStyleBackColor = true;
            Rcalc.Click += Rcalc_Click;
            // 
            // RP
            // 
            RP.Location = new Point(400, 88);
            RP.Name = "RP";
            RP.Size = new Size(125, 27);
            RP.TabIndex = 7;
            // 
            // RA
            // 
            RA.Location = new Point(400, 27);
            RA.Name = "RA";
            RA.Size = new Size(125, 27);
            RA.TabIndex = 6;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Location = new Point(304, 88);
            lb3.Name = "lb3";
            lb3.Size = new Size(74, 20);
            lb3.TabIndex = 5;
            lb3.Text = "perimeter";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(304, 34);
            lb1.Name = "lb1";
            lb1.Size = new Size(40, 20);
            lb1.TabIndex = 4;
            lb1.Text = "Area";
            // 
            // RW
            // 
            RW.Location = new Point(120, 81);
            RW.Name = "RW";
            RW.Size = new Size(125, 27);
            RW.TabIndex = 3;
            // 
            // RL
            // 
            RL.Location = new Point(120, 34);
            RL.Name = "RL";
            RL.Size = new Size(125, 27);
            RL.TabIndex = 2;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(68, 84);
            lb2.Name = "lb2";
            lb2.Size = new Size(46, 20);
            lb2.TabIndex = 1;
            lb2.Text = "width";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(63, 37);
            lb.Name = "lb";
            lb.Size = new Size(51, 20);
            lb.TabIndex = 0;
            lb.Text = "length";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 394);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "triangle ";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(439, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 161);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(448, 196);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 192);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(293, 304);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 18;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(409, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(409, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 99);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 15;
            label1.Text = "perimeter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 45);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 14;
            label2.Text = "Area";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(129, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 95);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 11;
            label3.Text = "height ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 48);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 10;
            label4.Text = "base";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(129, 178);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 225);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 21;
            label5.Text = "side 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 181);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 20;
            label6.Text = "side 1";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(129, 258);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 261);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 24;
            label7.Text = "side 3";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(textBox9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(SS);
            tabPage3.Controls.Add(label11);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 394);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "square ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(768, 394);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "circle";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(768, 394);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "cube";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(448, 196);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(248, 161);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(250, 211);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 18;
            button2.Text = "calculate";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(409, 99);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(409, 38);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(313, 99);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 15;
            label8.Text = "perimeter";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(313, 45);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 14;
            label9.Text = "Area";
            // 
            // SS
            // 
            SS.Location = new Point(129, 45);
            SS.Name = "SS";
            SS.Size = new Size(125, 27);
            SS.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(72, 48);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 10;
            label11.Text = "Side";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lb2;
        private Label lb;
        private TabPage tabPage2;
        private TextBox RW;
        private TextBox RL;
        private Button Rcalc;
        private TextBox RP;
        private TextBox RA;
        private Label lb3;
        private Label lb1;
        private PictureBox pictureBox1;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private PictureBox pictureBox3;
        private Button button2;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label8;
        private Label label9;
        private TextBox textBox10;
        private TextBox SS;
        private Label label10;
        private Label label11;
        private TabPage tabPage5;
    }
}
