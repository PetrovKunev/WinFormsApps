namespace Main
{
    public partial class Form1 : Form
    {

        private List<Food> foodDatabase = new List<Food>
        {
            new Food("Apple", 52, 0.3, 0.2, 14),
            new Food("Banana", 96, 1.3, 0.3, 27),
            new Food("Chicken Breast", 165, 31, 3.6, 0),
            // �������� ��� ����� �� ���� �������
        };
        public Form1()
        {
            InitializeComponent();

            // ��������� �� ������ � ����� � ComboBox-�
            cmbFoodList.DataSource = foodDatabase;
            cmbFoodList.DisplayMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ���������� ������ ������, ��� ��� ������
            dgvMealSummary.Columns.Clear();

            // ��������� ������ �� ����� �� �������
            DataGridViewTextBoxColumn colFoodName = new DataGridViewTextBoxColumn();
            colFoodName.Name = "FoodName";
            colFoodName.HeaderText = "Food Name";
            dgvMealSummary.Columns.Add(colFoodName);

            // ��������� ������ �� �������� (� �������)
            DataGridViewTextBoxColumn colPortion = new DataGridViewTextBoxColumn();
            colPortion.Name = "Portion";
            colPortion.HeaderText = "Portion (g)";
            dgvMealSummary.Columns.Add(colPortion);

            // ������ �� �������
            DataGridViewTextBoxColumn colCalories = new DataGridViewTextBoxColumn();
            colCalories.Name = "Calories";
            colCalories.HeaderText = "Calories";
            dgvMealSummary.Columns.Add(colCalories);

            // ������ �� ��������
            DataGridViewTextBoxColumn colProtein = new DataGridViewTextBoxColumn();
            colProtein.Name = "Protein";
            colProtein.HeaderText = "Protein (g)";
            dgvMealSummary.Columns.Add(colProtein);

            // ������ �� �������
            DataGridViewTextBoxColumn colFat = new DataGridViewTextBoxColumn();
            colFat.Name = "Fat";
            colFat.HeaderText = "Fat (g)";
            dgvMealSummary.Columns.Add(colFat);

            // ������ �� ������������
            DataGridViewTextBoxColumn colCarbs = new DataGridViewTextBoxColumn();
            colCarbs.Name = "Carbs";
            colCarbs.HeaderText = "Carbs (g)";
            dgvMealSummary.Columns.Add(colCarbs);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // 1. ������� ��������� ����� �� ComboBox-�
            if (cmbFoodList.SelectedItem is not Food selectedFood)
            {
                MessageBox.Show("����, �������� ����� �� �������.");
                return;
            }

            // 2. ����� ���������� ���������� � �������
            if (!double.TryParse(txtPortion.Text, out double portion))
            {
                MessageBox.Show("����, �������� ������� �������� �� ������������ (� �������).");
                return;
            }

            // 3. ����������� �������� ��������� ������ ���������� �������
            double multiplier = portion / 100.0;
            double calories = selectedFood.Calories * multiplier;
            double protein = selectedFood.Protein * multiplier;
            double fat = selectedFood.Fat * multiplier;
            double carbs = selectedFood.Carbs * multiplier;

            // 4. �������� ��� ��� � DataGridView
            // ����� �� ����������� ������ �� ����������� �� ���� �� ��������,
            // ����� ��� ������� � Form1_Load
            dgvMealSummary.Rows.Add(
                selectedFood.Name,   // FoodName
                portion,             // Portion (�������)
                calories,            // Calories
                protein,             // Protein
                fat,                 // Fat
                carbs                // Carbs
            );

            // 5. ���������� ������ ���������
            UpdateTotals();
        }

        /// <summary>
        /// ������� ������ ������ � DataGridView � ������ �����������,
        /// ���� ����� �� ������� � ����������� Label-�.
        /// </summary>
        private void UpdateTotals()
        {
            double totalCalories = 0;
            double totalProtein = 0;
            double totalFat = 0;
            double totalCarbs = 0;

            // ��������� ������ ������
            foreach (DataGridViewRow row in dgvMealSummary.Rows)
            {
                // ������� ����������� �� ��������, ��� �� �� null
                if (row.Cells["Calories"].Value != null)
                    totalCalories += Convert.ToDouble(row.Cells["Calories"].Value);

                if (row.Cells["Protein"].Value != null)
                    totalProtein += Convert.ToDouble(row.Cells["Protein"].Value);

                if (row.Cells["Fat"].Value != null)
                    totalFat += Convert.ToDouble(row.Cells["Fat"].Value);

                if (row.Cells["Carbs"].Value != null)
                    totalCarbs += Convert.ToDouble(row.Cells["Carbs"].Value);
            }

            // ���������� ���������� �� ���������
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
