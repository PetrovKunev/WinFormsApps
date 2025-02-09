namespace DayNight
{
    public partial class Form1 : Form
    {
        //bool isDay;
        //public Form1()
        //{
        //    InitializeComponent();
        //}

        //private void Checked_Status(object sender, EventArgs e)
        //{
        //    isDay = radioBtnDay.Checked;

        //    if (isDay)
        //    {
        //        this.BackColor = Color.White;
        //        this.ForeColor = Color.Black;
        //    }
        //    else
        //    {
        //        this.BackColor = Color.Black;
        //        this.ForeColor = Color.White;
        //    }
        //}

        
          // Деклариране на булевата променлива isDay
        private bool isDay = true; // по подразбиране избираме дневен режим

        public Form1()
        {
            InitializeComponent();
            // Задаване на началното състояние: избран е режим "Ден"
            radioBtnDay.Checked = true;
            UpdateTheme();
        }

        // Обработчик за събитието CheckedChanged на radioButtonDay
        private void radioButtonDay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnDay.Checked)
            {
                isDay = true;
                UpdateTheme();
            }
        }

        // Обработчик за събитието CheckedChanged на radioButtonNight
        private void radioButtonNight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNight.Checked)
            {
                isDay = false;
                UpdateTheme();
            }
        }

        // Метод, който обновява външния вид на формата според избрания режим
        private void UpdateTheme()
        {
            if (isDay)
            {
                // За дневен режим: светъл фон
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
            else
            {
                // За нощен режим: тъмен фон
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.White;
            }
        }
    }
}
