namespace UserRegistrationApp
{
    public partial class UserReg : Form
    {
        
        public UserReg()
        {
            InitializeComponent();
            btnRegistration.Enabled = false;
            
        }

        // Обработчик за събитие, когато състоянието на CheckBox "Приемам условията" се променя
        private void checkBoxConditions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRegistrationButton();
        }

        // Обработчик за събитие, когато състоянието на CheckBox "Потвърждавам, че съм навършил/а необходимата възраст" се променя
        private void checkBoxAge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRegistrationButton();
        }

        // Метод, който проверява дали и двата CheckBox-а са отбелязани и актуализира състоянието на бутона
        private void UpdateRegistrationButton()
        {
            // Присвояване на булевите стойности според състоянието на CheckBox-овете
            bool conditionsAccepted = checkBoxConditions.Checked;
            bool ageConfirmed = checkBoxAge.Checked;

            // Булевата променлива registrationAllowed ще бъде true само ако и двете са true
            bool registrationAllowed = conditionsAccepted && ageConfirmed;

            // Активиране или деактивиране на бутона за регистрация според условието
            btnRegistration.Enabled = registrationAllowed;
        }
    }
}
