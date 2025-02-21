namespace WinFormsApp_Textbook
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // 1. Опитваме се да прочетем (парснем) въведените числа от TextBox-овете.
            //    Ако не може да се парсне някое поле, нека приемем, че е 0 (или да покажем съобщение за грешка).

            int boysA = ParseIntOrZero(txtBoysA.Text);
            int girlsA = ParseIntOrZero(txtGirlsA.Text);

            int boysB = ParseIntOrZero(txtBoysB.Text);
            int girlsB = ParseIntOrZero(txtGirlsB.Text);

            int boysV = ParseIntOrZero(txtBoysV.Text);
            int girlsV = ParseIntOrZero(txtGirlsV.Text);

            // 2. Определяме какво ще сумираме (Момчета, Момичета, или Общо).
            bool sumBoys = rdbBoys.Checked;      // Радио бутон "Момчета"
            bool sumGirls = rdbGirls.Checked;    // Радио бутон "Момичета"
            bool sumAll = rdbAll.Checked;        // Радио бутон "Общо"

            // 3. Създаваме променлива за резултата
            int total = 0;

            // 4. Проверяваме кои CheckBox-и са маркирани и събираме стойностите

            // --- 8 А клас ---
            if (chkClassA.Checked)
            {
                if (sumBoys)
                {
                    total += boysA;
                }
                else if (sumGirls)
                {
                    total += girlsA;
                }
                else if (sumAll)
                {
                    total += (boysA + girlsA);
                }
            }

            // --- 8 Б клас ---
            if (chkClassB.Checked)
            {
                if (sumBoys)
                {
                    total += boysB;
                }
                else if (sumGirls)
                {
                    total += girlsB;
                }
                else if (sumAll)
                {
                    total += (boysB + girlsB);
                }
            }

            // --- 8 В клас ---
            if (chkClassV.Checked)
            {
                if (sumBoys)
                {
                    total += boysV;
                }
                else if (sumGirls)
                {
                    total += girlsV;
                }
                else if (sumAll)
                {
                    total += (boysV + girlsV);
                }
            }

            // 5. Показваме резултата
            lblResult.Text = "Брой: " + total;
        }

        // Помощен метод: опитва да превърне стринг в int. Ако не успее, връща 0.
        private int ParseIntOrZero(string text)
        {
            int number;
            bool success = int.TryParse(text, out number);
            if (!success)
            {  
              number = 0; 
            }
            return number;
        }
    }
}
