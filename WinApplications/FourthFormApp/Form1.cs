namespace FourthFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            int side = int.Parse(txtInputBox.Text);

            int area = side * side;

            lblResult.Text = $"{area}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "---";
            txtInputBox.Clear();
        }
    }
}
