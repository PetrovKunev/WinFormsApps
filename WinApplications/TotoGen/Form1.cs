namespace TotoGen
{
    public partial class Form1 : Form
    {

        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[6];
            int count = 0;

            // Генерираме 6 различни числа от 1 до 49
            while (count < 6)
            {
                int candidate = random.Next(1, 50); // горната граница е 50 -> 1..49
                bool alreadyExists = false;

                // проверка дали вече имаме това число
                for (int i = 0; i < count; i++)
                {
                    if (numbers[i] == candidate)
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                // ако не се повтаря – добавяме го
                if (!alreadyExists)
                {
                    numbers[count] = candidate;
                    count++;
                }
            }

            // показваме ги в етикетите
            label1.Text = numbers[0].ToString();
            label2.Text = numbers[1].ToString();
            label3.Text = numbers[2].ToString();
            label4.Text = numbers[3].ToString();
            label5.Text = numbers[4].ToString();
            label6.Text = numbers[5].ToString();
        }
    }
}
