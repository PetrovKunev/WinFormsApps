namespace CalculateHypotenuse
{
    public partial class Main : Form
    {
        double cadetA;
        double cadetB;
        double hypotenuseC;
        public Main()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Проверка за празни стойности
            if (string.IsNullOrWhiteSpace(txtCadetA.Text) ||
                string.IsNullOrWhiteSpace(txtCadetB.Text))
            {
                MessageBox.Show("Моля, въведете стойности и за двата катета.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Опит за парсване към double
            if (!double.TryParse(txtCadetA.Text, out double cadetA) ||
                !double.TryParse(txtCadetB.Text, out double cadetB))
            {
                MessageBox.Show("Моля, въведете валидни числови стойности.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Проверка двата катета да са > 0
            if (cadetA <= 0 || cadetB <= 0)
            {
                MessageBox.Show("Катетите трябва да са по-големи от нула.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Изчисление
            double hypotenuseC = Math.Sqrt(Math.Pow(cadetA, 2) + Math.Pow(cadetB, 2));
            lblResult.Text = $"Hypotenuse C = {hypotenuseC:F2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCadetA.Text = "";
            txtCadetB.Text = "";
            lblResult.Text = "_________";
        }
    }
}
