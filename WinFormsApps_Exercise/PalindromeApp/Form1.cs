namespace PalindromeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик на събитието Click за бутона "Провери".
        /// </summary>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Изчистваме стария резултат
            lblResult.Text = "";

            // Вземаме въведения текст и премахваме излишните интервали.
            string input = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Моля, въведете число!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Опитваме се да преобразуваме входа в цяло число.
            if (!int.TryParse(input, out int num))
            {
                MessageBox.Show("Моля, въведете валидно цяло число!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Използваме отделния метод, който използва / и % за проверка.
            if (IsPalindrome(num))
            {
                lblResult.Text = "Числото е палиндром!";
            }
            else
            {
                lblResult.Text = "Числото не е палиндром!";
            }
        }

        /// <summary>
        /// Метод, който проверява дали подаденото число е палиндром,
        /// използвайки аритметични операции за извличане на цифри.
        /// </summary>
        /// <param name="number">Числото, което трябва да се провери.</param>
        /// <returns>Връща true, ако числото е палиндром, в противен случай false.</returns>
        private bool IsPalindrome(int number)
        {
            // За да работим с неотрицателни числа, вземаме абсолютната стойност.
            int original = Math.Abs(number);
            int reversed = 0;
            int temp = original;

            // Докато temp е по-голямо от 0
            while (temp > 0)
            {
                // Извличаме последната цифра с помощта на %
                int digit = temp % 10;

                // Добавяме цифрата към обратното число.
                reversed = reversed * 10 + digit;

                // Премахваме последната цифра чрез деление на 10
                temp /= 10;
            }

            // Ако оригиналното число е равно на обратното, то е палиндром.
            return original == reversed;
        }
    }
}
