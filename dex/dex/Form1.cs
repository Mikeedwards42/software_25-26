using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dex
{
    public partial class name : Form
    {
        public name()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gender.Text = "male";
            dps.Text = "687";
            Damage.Text = "1,100";
            health.Text = "2075";
            namelabel.Text = "mini pecker";
            displaypb.Image = MP.Image;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
                gender.Text = "male";
                dps.Text = "656";
                Damage.Text = "1,186";
                health.Text = "5400";
                namelabel.Text = "big pecker";
                displaypb.Image = PP.Image;
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
                gender.Text = "male";
                dps.Text = "256";
                Damage.Text = "308";
                health.Text = "3348";
                namelabel.Text = "Goblin machine";
                displaypb.Image = GM.Image;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                gender.Text = "female";
                dps.Text = "296";
                Damage.Text = "148";
                health.Text = "1302";
                namelabel.Text = "beserker";
                displaypb.Image = B.Image;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                gender.Text = "female";
                dps.Text = "325";
                Damage.Text = "390";
                health.Text = "3813";
                namelabel.Text = "Boss bandit";
                displaypb.Image = bs.Image;
            
        }
    }
}
