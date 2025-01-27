namespace SecondWinApp
{
    public partial class SecondApp : Form
    {
        public SecondApp()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtBox.Text = "HELLO WORLD! This is ";
            //txtBox.BackColor = Color.Red;
            //txtBox.ForeColor = Color.White;
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            //txtBox.BackColor = Color.White;

        }
    }
}
