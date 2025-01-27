namespace FirstWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowWords_Click(object sender, EventArgs e)
        {
            string textToShow = txtBox.Text;

            MessageBox.Show($"This is your text: {textToShow}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }
    }
}
