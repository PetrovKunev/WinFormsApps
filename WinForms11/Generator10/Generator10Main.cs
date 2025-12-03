namespace Generator10
{
    public partial class Generator10Main : Form
    {
        public Generator10Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1.Изчистваме списъка от предишни числа, за да не се трупат
            listBox1.Items.Clear();

            // 2. Създаваме обект от класа Random за генериране на случайни числа
            Random r = new Random();

            // 3. Инициализираме променлива за минималното число. 
            // Задаваме ѝ възможно най-голямата стойност (int.MaxValue), 
            // за да сме сигурни, че първото генерирано число ще бъде по-малко от нея.
            int minN = int.MaxValue;

            // 4. Завъртаме цикъл, който ще се изпълни 10 пъти
            for (int i = 1; i <= 10; i++)
            {
                // Генерираме случайно число в интервала [1, 100]
                // Методът Next(1, 101) връща число >= 1 и < 101
                int number = r.Next(1, 101);

                // Добавяме числото в ListBox-а
                listBox1.Items.Add(number);

                // Проверяваме дали текущото число е по-малко от текущия минимум
                if (number < minN)
                {
                    minN = number; // Ако е по-малко, то става новият минимум
                }
            }

            // 5. Показваме резултата за минималното число
            MessageBox.Show("Минимално число: " + minN, "Минимум", MessageBoxButtons.OK);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LimeGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
        }

    }
}
