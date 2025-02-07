namespace LightToggleBulb
{
    public partial class ToggleBulb : Form
    {
        public ToggleBulb()
        {
            InitializeComponent();
            // Инициализиране на PictureBox-а с началното състояние
            UpdateLightStatus();
        }

        // Булевата променлива lightOn, първоначално зададена на false (светлината е изключена)
        private bool lightOn = false;

        // Метод за обновяване на изображението в PictureBox-а според текущото състояние на светлината
        private void UpdateLightStatus()
        {
            if (lightOn)
            {
                // Ако светлината е включена, показваме изображението за включена крушка
                pictureBoxBulb.Image = Properties.Resources.BulbOn;
            }
            else
            {
                // Ако светлината е изключена, показваме изображението за изключена крушка
                pictureBoxBulb.Image = Properties.Resources.BulbOff;
            }
        }

        // Обработчик за събитието Click на бутона buttonToggle
        private void buttonToggle_Click(object sender, EventArgs e)
        {
            // Превключване на стойността на lightOn: ако е false, става true и обратно
            lightOn = !lightOn;

            // Актуализиране на изображението в PictureBox-а според новото състояние
            UpdateLightStatus();
        }
    }
}
