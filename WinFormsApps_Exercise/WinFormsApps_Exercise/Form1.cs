namespace WinFormsApps_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double input))
            {
                double squareSide = input / 4;
                double squareArea = Math.Pow(squareSide, 2);
                lblResult.Text = squareArea.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblResult.Text = "_______";
        }
    }
}
