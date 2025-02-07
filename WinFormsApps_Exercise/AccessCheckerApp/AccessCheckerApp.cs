namespace AccessCheckerApp
{
    public partial class AccessCheckerApp : Form
    {
        // Деклариране на булевата променлива access
        bool access;
        public AccessCheckerApp()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Присвояване на стойността на променливата access според CheckBox-а
            access = checkBoxAccess.Checked;
            // Проверка дали CheckBox-ът е отметнат
            if (access)
            {
                
                lblResult.Text = "Достъп разрешен";
            }
            else
            {
                
                lblResult.Text = "Достъп отказан";
            }
        }
    }
}
