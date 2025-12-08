
using System.Text;

namespace BGPasswordValidator
{
    public partial class Form1 : Form
    {
        private UserData currentUser;
        private SecurityScanner scanner;

        public Form1()
        {
            InitializeComponent();

            currentUser = new UserData();
            scanner = new SecurityScanner();

        }
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            // 1) Взимаме данните от формата
            currentUser.Username = txtUsername.Text.Trim();
            currentUser.Password = txtPassword.Text;
            if (cmbAccountType.SelectedItem != null)
            {
                currentUser.AccountType = cmbAccountType.SelectedItem.ToString();
            }
            else
            {
                // Стойност по подразбиране
                currentUser.AccountType = "Потребител";
            }

            // 2) Проверяваме името
            bool isNameValid = scanner.CheckUsernameValid(currentUser.Username, out string nameMessage);

            // 3) Анализираме паролата (for цикълът е вътре в AnalyzePassword)
            int score = scanner.AnalyzePassword(currentUser.Password);

            // 4) Вземаме текстово съобщение според score (switch-case)
            string securityMessage = SystemHelper.GetSecurityMessage(score);

            // 5) Определяме дали като цяло е „валиден“ потребител
            bool isOverallValid = isNameValid && score >= 2;

            if (isOverallValid)
            {
                lblResult.Text = "ВАЛИДЕН";
                lblResult.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblResult.Text = "НЕВАЛИДЕН";
                lblResult.ForeColor = Color.DarkRed;
            }

            // 6) Обновяваме ProgressBar
            int percent = 0;
            switch (score)
            {
                case 1: percent = 30; break;
                case 2: percent = 60; break;
                case 3: percent = 100; break;
            }

            if (percent < progressPassword.Minimum) percent = progressPassword.Minimum;
            if (percent > progressPassword.Maximum) percent = progressPassword.Maximum;
            progressPassword.Value = percent;


            // 7) Показваме кратка информация в MessageBox – тук използваме GetSummary()
            string info = currentUser.GetSummary() + Environment.NewLine +
                          "Статус на потребителското име: " + nameMessage + Environment.NewLine +
                          "Ниво на защита на паролата: " + securityMessage;

            MessageBox.Show(info, "Резултат от проверката");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            if (cmbAccountType.Items.Count > 0)
            {
                cmbAccountType.SelectedIndex = 1;
            }

            lblResult.Text = "-";
            lblResult.ForeColor = SystemColors.ControlText;

            progressPassword.Value = progressPassword.Minimum;

            currentUser.ClearData();
        }

    }
}
