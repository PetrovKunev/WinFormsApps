namespace ThirdWinApp
{
    public partial class FormThird : Form
    {
        public FormThird()
        {
            InitializeComponent();
        }

        private void btnWords_Click(object sender, EventArgs e)
        {
           if(txtBox.Text == "1") lblWords.Text = "One";
           else if(txtBox.Text == "2") lblWords.Text = "Two";
           else if (txtBox.Text == "3") lblWords.Text = "Three";
           else if (txtBox.Text == "4") lblWords.Text = "Four";
           else if (txtBox.Text == "5") lblWords.Text = "Five";
           else if (txtBox.Text == "6") lblWords.Text = "Six";
           else if (txtBox.Text == "7") lblWords.Text = "Seven";
           else if (txtBox.Text == "8") lblWords.Text = "Eight";
           else if (txtBox.Text == "9") lblWords.Text = "Nine";
           else if (txtBox.Text == "10") lblWords.Text = "Ten";
           else if (txtBox.Text == "") MessageBox.Show("Please enter number from 1 to 10");
           else MessageBox.Show("Invalid enter! Please try again!");
            
        }
    }
}
