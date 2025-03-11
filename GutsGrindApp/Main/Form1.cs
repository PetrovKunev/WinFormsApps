namespace Main
{
    public partial class Form1 : Form
    {

        private List<Food> foodDatabase = new List<Food>
        {
            new Food("Apple", 52, 0.3, 0.2, 14),
            new Food("Banana", 96, 1.3, 0.3, 27),
            new Food("Chicken Breast", 165, 31, 3.6, 0),
            // Добавете още храни по ваше желание
        };
        public Form1()
        {
            InitializeComponent();

            // Зареждане на базата с храни в ComboBox-а
            cmbFoodList.DataSource = foodDatabase;
            cmbFoodList.DisplayMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Изчистваме всички колони, ако има такива
            dgvMealSummary.Columns.Clear();

            // Създаваме колона за името на храната
            DataGridViewTextBoxColumn colFoodName = new DataGridViewTextBoxColumn();
            colFoodName.Name = "FoodName";
            colFoodName.HeaderText = "Food Name";
            dgvMealSummary.Columns.Add(colFoodName);

            // Създаваме колона за порцията (в грамове)
            DataGridViewTextBoxColumn colPortion = new DataGridViewTextBoxColumn();
            colPortion.Name = "Portion";
            colPortion.HeaderText = "Portion (g)";
            dgvMealSummary.Columns.Add(colPortion);

            // Колона за калории
            DataGridViewTextBoxColumn colCalories = new DataGridViewTextBoxColumn();
            colCalories.Name = "Calories";
            colCalories.HeaderText = "Calories";
            dgvMealSummary.Columns.Add(colCalories);

            // Колона за протеини
            DataGridViewTextBoxColumn colProtein = new DataGridViewTextBoxColumn();
            colProtein.Name = "Protein";
            colProtein.HeaderText = "Protein (g)";
            dgvMealSummary.Columns.Add(colProtein);

            // Колона за мазнини
            DataGridViewTextBoxColumn colFat = new DataGridViewTextBoxColumn();
            colFat.Name = "Fat";
            colFat.HeaderText = "Fat (g)";
            dgvMealSummary.Columns.Add(colFat);

            // Колона за въглехидрати
            DataGridViewTextBoxColumn colCarbs = new DataGridViewTextBoxColumn();
            colCarbs.Name = "Carbs";
            colCarbs.HeaderText = "Carbs (g)";
            dgvMealSummary.Columns.Add(colCarbs);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // 1. Вземаме избраната храна от ComboBox-а
            if (cmbFoodList.SelectedItem is not Food selectedFood)
            {
                MessageBox.Show("Моля, изберете храна от списъка.");
                return;
            }

            // 2. Четем въведеното количество в грамове
            if (!double.TryParse(txtPortion.Text, out double portion))
            {
                MessageBox.Show("Моля, въведете валидна стойност за количеството (в грамове).");
                return;
            }

            // 3. Изчисляваме реалните стойности спрямо въведените грамове
            double multiplier = portion / 100.0;
            double calories = selectedFood.Calories * multiplier;
            double protein = selectedFood.Protein * multiplier;
            double fat = selectedFood.Fat * multiplier;
            double carbs = selectedFood.Carbs * multiplier;

            // 4. Добавяме нов ред в DataGridView
            // Редът на параметрите трябва да съответства на реда на колоните,
            // който сте създали в Form1_Load
            dgvMealSummary.Rows.Add(
                selectedFood.Name,   // FoodName
                portion,             // Portion (грамове)
                calories,            // Calories
                protein,             // Protein
                fat,                 // Fat
                carbs                // Carbs
            );

            // 5. Обновяваме общите стойности
            UpdateTotals();
        }

        /// <summary>
        /// Обхожда всички редове в DataGridView и сумира стойностите,
        /// след което ги показва в съответните Label-и.
        /// </summary>
        private void UpdateTotals()
        {
            double totalCalories = 0;
            double totalProtein = 0;
            double totalFat = 0;
            double totalCarbs = 0;

            // Обхождаме всички редове
            foreach (DataGridViewRow row in dgvMealSummary.Rows)
            {
                // Вземаме стойностите от клетките, ако не са null
                if (row.Cells["Calories"].Value != null)
                    totalCalories += Convert.ToDouble(row.Cells["Calories"].Value);

                if (row.Cells["Protein"].Value != null)
                    totalProtein += Convert.ToDouble(row.Cells["Protein"].Value);

                if (row.Cells["Fat"].Value != null)
                    totalFat += Convert.ToDouble(row.Cells["Fat"].Value);

                if (row.Cells["Carbs"].Value != null)
                    totalCarbs += Convert.ToDouble(row.Cells["Carbs"].Value);
            }

            // Обновяваме текстовете на етикетите
            lblTotalCalories.Text = $"{totalCalories}";
            lblTotalProtein.Text = $"{totalProtein}";
            lblTotalFat.Text = $"{totalFat}";
            lblTotalCarbs.Text = $"{totalCarbs}";
        }
    }
    public class Food
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }

        public Food(string name, double calories, double protein, double fat, double carbs)
        {
            Name = name;
            Calories = calories;
            Protein = protein;
            Fat = fat;
            Carbs = carbs;
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
