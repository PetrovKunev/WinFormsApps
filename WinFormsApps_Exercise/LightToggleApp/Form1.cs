namespace LightToggleApp
{
    public partial class LightToggle : Form
    {
        private bool lightOn = false;

        public LightToggle()
        {
            InitializeComponent();
            UpdateLightStatus();
        }

        private void LightToggle_Load(object sender, EventArgs e)
        {

        }

        // Метод за актуализиране на текста в Label-а според текущото състояние на светлината
        private void UpdateLightStatus()
        {
            if (lightOn)
            {
                lblStatus.Text = "Светлината е включена";
            }
            else
            {
                lblStatus.Text = "Светлината е изключена";
            }
        }

        // Метод за събитието Click на бутона buttonToggle
        private void btnToggle_Click(object sender, EventArgs e)
        {
            // Превключване на стойността на lightOn: ако е false, става true, и обратно
            lightOn = !lightOn;

            // Актуализиране на Label-а според новото състояние
            UpdateLightStatus();
        }


    }
}
