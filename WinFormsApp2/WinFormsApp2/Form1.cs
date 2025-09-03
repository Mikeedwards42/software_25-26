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
    }
}
