namespace Avg_St
{
    public partial class MainSt : Form
    {
        private Student[] students = new Student[26];
        public MainSt()
        {
            InitializeComponent();
        }

        // === Бутон "Изчисти" ===
        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxClass.Clear();
            textBoxId.Clear();
            textBoxName.Clear();

            textBoxBEL.Clear();
            textBoxForeign.Clear();
            textBoxMath.Clear();
            textBoxPhys.Clear();
            textBoxChem.Clear();
            textBoxBio.Clear();

            labelAverage.Text = "Среден успех";
        }

        // === Бутон "Запази" ===
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 1) Четем и проверяваме клас и номер
            if (!int.TryParse(textBoxClass.Text, out int cls))
            {
                MessageBox.Show("Въведи валиден клас (цяло число).");
                return;
            }

            if (!int.TryParse(textBoxId.Text, out int number))
            {
                MessageBox.Show("Въведи валиден номер (цяло число).");
                return;
            }

            if (number < 1 || number > 26)
            {
                MessageBox.Show("Номерът трябва да е от 1 до 26.");
                return;
            }

            string name = textBoxName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Въведи име на ученика.");
                return;
            }

            // 2) Четем оценките
            if (!double.TryParse(textBoxBEL.Text, out double bel) ||
                !double.TryParse(textBoxForeign.Text, out double foreign) ||
                !double.TryParse(textBoxMath.Text, out double math) ||
                !double.TryParse(textBoxPhys.Text, out double phys) ||
                !double.TryParse(textBoxChem.Text, out double chem) ||
                !double.TryParse(textBoxBio.Text, out double bio))
            {
                MessageBox.Show("Въведи валидни оценки (числа) за всички предмети.");
                return;
            }

            // 3) Създаваме обект Student
            Student st = new Student(cls, number, name,
                                     bel, foreign, math,
                                     phys, chem, bio);

            // 4) Записваме го в масива – позиция number - 1
            int index = number - 1;
            students[index] = st;

            // 5) Показваме средния успех
            labelAverage.Text = "Среден успех: " + st.Average.ToString("F2");

            MessageBox.Show("Ученикът е записан успешно.");
        }

        // === Бутон "Търси" ===
        private void buttonFind_Click(object sender, EventArgs e)
        {
            // Търсим по номер (по-лесно за учениците)
            if (!int.TryParse(textBoxId.Text, out int number))
            {
                MessageBox.Show("Въведи номер за търсене.");
                return;
            }

            if (number < 1 || number > 26)
            {
                MessageBox.Show("Номерът трябва да е от 1 до 26.");
                return;
            }

            int index = number - 1;
            Student st = students[index];

            if (st == null)
            {
                MessageBox.Show("Няма запис за този номер.");
                return;
            }

            // Попълваме полетата от намерения ученик
            textBoxClass.Text = st.Class.ToString();
            textBoxId.Text = st.Number.ToString();
            textBoxName.Text = st.Name;

            textBoxBEL.Text = st.Bel.ToString();
            textBoxForeign.Text = st.Foreign.ToString();
            textBoxMath.Text = st.Math.ToString();
            textBoxPhys.Text = st.Physics.ToString();
            textBoxChem.Text = st.Chemistry.ToString();
            textBoxBio.Text = st.Biology.ToString();

            labelAverage.Text = "Среден успех: " + st.Average.ToString("F2");
        }

        
    }
}
