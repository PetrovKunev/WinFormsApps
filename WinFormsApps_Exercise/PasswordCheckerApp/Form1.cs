namespace PasswordCheckerApp
{
    public partial class Form1 : Form
    {
        const string correctPassword = "pass123";
        
        bool isValid = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            isValid = txtBoxPassword.Text == correctPassword;

            if (isValid)
            {
                lblMessage.Text = "����� �����!";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "������ ������!";
                lblMessage.ForeColor = Color.Red;
                txtBoxPassword.Clear();
            }

        }
    }
}
