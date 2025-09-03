namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int rarea(int l, int w)
        {
            return l * w;
        }

        private void Rcalc_Click(object sender, EventArgs e)
        {
            int l = 0;
            int w = 0;
            w = int.Parse(RW.Text);
            l = int.Parse(RL.Text);
            int area = rarea(l, w);
            RA.Text = area.ToString();
            int perimeter = 2 * (l + w);
            RP.Text = perimeter.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            s = int.Parse(SS.Text);
            int area = s * s;
            SA.Text = area.ToString();
            int perimeter = 4 * s;
            SP.Text = perimeter.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 0;
            int h = 0;
            int s1 = 0;
            int s2 = 0;
            s1 = int.Parse(TS1.Text);
            s2 = int.Parse(TS2.Text);
            b = int.Parse(TB.Text);
            h = int.Parse(TH.Text);
            int area = (b * h) / 2;
            TA.Text = area.ToString();
            int perimeter = b + s1 + s2;
             TP.Text = perimeter.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = 0;
            r = int.Parse(CR.Text);
            double area = Math.PI * r * r;
            CA.Text = area.ToString();
            double circumference = 2 * Math.PI * r;
            CC.Text = circumference.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s   = 0;
            s = int.Parse(CS.Text);
            CV.Text = (s * s * s).ToString();
            CSA.Text = (s*s*6).ToString();


        }
    }
}
