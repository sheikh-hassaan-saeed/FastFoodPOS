namespace FastFoodPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FastMeallb_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FriedChBx_CheckedChanged(object sender, EventArgs e)
        {
            Friestxt.Enabled = FriedChBx.Checked;

            if (FriedChBx.Checked)
            {
                Friestxt.Text = "0";
                Friestxt.Focus();
            }
            else
            {
                Friestxt.Text = "";
            }
        }

        private void BurgerChBx_CheckedChanged(object sender, EventArgs e)
        {
            Burgertxt.Enabled = BurgerChBx.Checked;

            if (BurgerChBx.Checked)
            {
                Burgertxt.Text = "0";
                Burgertxt.Focus();
            }
            else
            {
                Burgertxt.Text = "";
            }
        }

        private void SandwichChBx_CheckedChanged(object sender, EventArgs e)
        {
            Sandwichtxt.Enabled = SandwichChBx.Checked;

            if (SandwichChBx.Checked)
            {
                Sandwichtxt.Text = "0";
                Sandwichtxt.Focus();
            }
            else
            {
                Sandwichtxt.Text = "";
            }
        }

        private void ChickenChBx_CheckedChanged(object sender, EventArgs e)
        {
            Chickentxt.Enabled = ChickenChBx.Checked;

            if (ChickenChBx.Checked)
            {
                Chickentxt.Text = "0";
                Chickentxt.Focus();
            }
            else
            {
                Chickentxt.Text = "";
            }
        }

        private void CheeseChBx_CheckedChanged(object sender, EventArgs e)
        {
            Cheesetxt.Enabled = CheeseChBx.Checked;

            if (CheeseChBx.Checked)
            {
                Cheesetxt.Text = "0";
                Cheesetxt.Focus();
            }
            else
            {
                Cheesetxt.Text = "";
            }
        }

        private void WaterChBx_CheckedChanged(object sender, EventArgs e)
        {
            Watertxt.Enabled = WaterChBx.Checked;

            if (WaterChBx.Checked)
            {
                Watertxt.Text = "0";
                Watertxt.Focus();
            }
            else
            {
                Watertxt.Text = "";
            }
        }

        private void ColaChBx_CheckedChanged(object sender, EventArgs e)
        {
            Colatxt.Enabled = ColaChBx.Checked;

            if (ColaChBx.Checked)
            {
                Colatxt.Text = "0";
                Colatxt.Focus();
            }
            else
            {
                Colatxt.Text = "";
            }
        }

        private void TeaChBx_CheckedChanged(object sender, EventArgs e)
        {
            Teatxt.Enabled = TeaChBx.Checked;

            if (TeaChBx.Checked)
            {
                Teatxt.Text = "0";
                Teatxt.Focus();
            }
            else
            {
                Teatxt.Text = "";
            }
        }

        private void CustardChBx_CheckedChanged(object sender, EventArgs e)
        {
            Custardtxt.Enabled = CustardChBx.Checked;

            if (CustardChBx.Checked)
            {
                Custardtxt.Text = "0";
                Custardtxt.Focus();
            }
            else
            {
                Custardtxt.Text = "";
            }
        }
    }
}
