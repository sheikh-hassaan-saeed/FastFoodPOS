using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using Application = System.Windows.Forms.Application;


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

        
        private void Closelb_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            Friestxt.Enabled = FriesChBx.Checked;

            if (FriesChBx.Checked)
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


        //Decleration of Unit Prices
        double friesup = 50, burgerup = 150, sandwichup = 280, chickenup = 550, cheeseup = 800;
        double waterup = 80, colaup = 120, teaup = 70, custardup = 300;

        //Declreation of variables that will hold the price by multiplying the quantity
        double friestp, burgertp, sandwichtp, chickentp, cheesetp, watertp, teatp, colatp, custardtp, subtotal;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // TryParse to safely continue even if the text box is empty
            double.TryParse(Friestxt.Text, out double friesQty);
            double.TryParse(Burgertxt.Text, out double burgerQty);
            double.TryParse(Sandwichtxt.Text, out double sandwichQty);
            double.TryParse(Chickentxt.Text, out double chickenQty);
            double.TryParse(Cheesetxt.Text, out double cheeseQty);
            double.TryParse(Watertxt.Text, out double waterQty);
            double.TryParse(Colatxt.Text, out double colaQty);
            double.TryParse(Teatxt.Text, out double teaQty);
            double.TryParse(Custardtxt.Text, out double custardQty);

            friestp = friesup * friesQty;
            burgertp = burgerup * burgerQty;
            sandwichtp = sandwichup * sandwichQty;
            chickentp = chickenup * chickenQty;
            cheesetp = cheeseup * cheeseQty;
            watertp = waterup * waterQty;
            colatp = colaup * colaQty;
            teatp = teaup * teaQty;
            custardtp = custardup * custardQty;

            // --- Build Receipt ---
            subtotal = 0;
            ReceiptTb.Clear();
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tTASTY RESTAURANT" + Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t*****************" + Environment.NewLine);

            if (FriesChBx.Checked == true)
            {
                ReceiptTb.AppendText($"\tFries: {friestp}\n");
                subtotal += friestp;
            }

            if (BurgerChBx.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + Environment.NewLine);
                subtotal += burgertp;
            }

            if (SandwichChBx.Checked == true)
            {
                ReceiptTb.AppendText($"\tSandwich: {sandwichtp}\n");
                subtotal += sandwichtp;
            }

            if (ChickenChBx.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:\t" + chickentp + Environment.NewLine);
                subtotal += chickentp;
            }

            if (CheeseChBx.Checked == true)
            {
                ReceiptTb.AppendText("\tCheese:\t" + cheesetp + Environment.NewLine);
                subtotal += cheesetp;
            }

            if (WaterChBx.Checked == true)
            {
                ReceiptTb.AppendText("\tWater:\t" + watertp + Environment.NewLine);
                subtotal += watertp;
            }

            if (ColaChBx.Checked == true)
            {
                ReceiptTb.AppendText("\tCola:\t" + colatp + Environment.NewLine);
                subtotal += colatp;
            }

            if (TeaChBx.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + Environment.NewLine);
                subtotal += teatp;
            }

            if (CustardChBx.Checked == true)
            {
                ReceiptTb.AppendText("\tCustard:\t" + custardtp + Environment.NewLine);
                subtotal += custardtp;
            }

            SubTotallb.Text = subtotal.ToString("N2");

        }
    }
}
