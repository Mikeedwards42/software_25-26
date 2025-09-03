namespace tiktactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void b1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            checkWinner();
            winCheck_Tick();
        }
        private Boolean checkWinner()
        {
            // Horizontal
            if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != "")
                return true;
            if (b4.Text == b5.Text && b5.Text == b6.Text && b4.Text != "")
                return true;
            if (b7.Text == b8.Text && b8.Text == b9.Text && b7.Text != "")
                return true;
            // Vertical
            if (b1.Text == b4.Text && b4.Text == b7.Text && b1.Text != "")
                return true;
            if (b2.Text == b5.Text && b5.Text == b8.Text && b2.Text != "")
                return true;
            if (b3.Text == b6.Text && b6.Text == b9.Text && b3.Text != "")
                return true;
            // Diagonal
            if (b1.Text == b5.Text && b5.Text == b9.Text && b1.Text != "")
                return true;
            if (b3.Text == b5.Text && b5.Text == b7.Text && b3.Text != "")
                return true;
            return false;
        }
        private void reset()
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
        }
        private void winCheck_Tick()
        {
            if (checkWinner() == true)
            {
                MessageBox.Show("We have a winner!");
                reset();
            }
        }
    }
}
