using System;
using System.Data;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class CalcHome : Form
    {
        Boolean isCalcPressed = false;
        public CalcHome()
        {
            InitializeComponent();
            txtCalc.Text = "0";
        }

        private void NumKeyPressed(object sender)
        {
            bool isDot = txtCalc.Text.IndexOf(".") == txtCalc.Text.Length - 1;

            double dblVal = double.Parse(txtCalc.Text);
            string strVal = ((ButtonBase)sender).Text;

            if (isCalcPressed) txtCalc.Text = strVal;
            else if (isDot) txtCalc.Text = (double.Parse(dblVal.ToString() + "." + strVal)).ToString();
            else txtCalc.Text = (double.Parse(dblVal.ToString() + strVal)).ToString();

            isCalcPressed = false;
        }

        private void DoCalculation()
        {
            if (isCalcPressed) txtCalMemory.Text = string.Empty;

            isCalcPressed = true;

            DataTable dt = new DataTable();

            if (!string.IsNullOrEmpty(txtCalMemory.Text))
            {
                string strVal = txtCalMemory.Text.ToString() + txtCalc.Text.ToString();
                var res = dt.Compute(strVal, "");
                txtCalc.Text = res.ToString();
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {

            double dblVal = double.Parse(txtCalc.Text);
            txtCalc.Text = dblVal.ToString();

            if (dblVal % 1 == 0) txtCalc.Text = dblVal.ToString() + ".";
        }

        private void NumBtn_Click(object sender, EventArgs e)
        {
            NumKeyPressed(sender);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            DoCalculation();
            txtCalMemory.Text = string.Empty;
        }

        private void btnAAdd_Click(object sender, EventArgs e)
        {
            DoCalculation();

            txtCalMemory.Text = txtCalc.Text + "+";
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            DoCalculation();

            txtCalMemory.Text = txtCalc.Text + "-";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            DoCalculation();

            txtCalMemory.Text = txtCalc.Text + "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            DoCalculation();

            txtCalMemory.Text = txtCalc.Text + "/";
        }

        private void btnMC_Click(object sender, EventArgs e)
        {

        }

        private void btnMR_Click(object sender, EventArgs e)
        {

        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnMS_Click(object sender, EventArgs e)
        {

        }

        private void btnMv_Click(object sender, EventArgs e)
        {

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCalMemory.Text = string.Empty;
            txtCalc.Text = "0";
        }

        private void btnESc_Click(object sender, EventArgs e)
        {

        }

        private void btn1ByX_Click(object sender, EventArgs e)
        {

        }

        private void btnX2_Click(object sender, EventArgs e)
        {

        }

        private void btn2RootX_Click(object sender, EventArgs e)
        {

        }
    }
}
