namespace CalculateHypotenuse
{
    public partial class Main : Form
    {
        double cadetA;
        double cadetB;
        double hypotenuseC;
        public Main()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            cadetA = double.Parse(txtCadetA.Text);
            cadetB = double.Parse(txtCadetB.Text);

            if (cadetA <= 0 || cadetB <= 0)
            {
                MessageBox.Show("Both cadetA and cadetB must be greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }

            hypotenuseC = Math.Sqrt(Math.Pow(cadetA, 2) + Math.Pow(cadetB, 2));

            lblResult.Text = $"Hypotenuse C = {hypotenuseC:F2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCadetA.Text = "";
            txtCadetB.Text = "";
            lblResult.Text = "_________";
        }
    }
}
