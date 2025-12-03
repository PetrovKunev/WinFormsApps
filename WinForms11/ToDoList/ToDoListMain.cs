namespace ToDoList
{
    public partial class ToDoListMain : Form
    {
        public ToDoListMain()
        {
            InitializeComponent();
        }

        // Бутон "Добави"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtNewTask.Text.Trim();

            if (!string.IsNullOrEmpty(task))
            {
                lstTasks.Items.Add(task);
                txtNewTask.Clear();
                txtNewTask.Focus();
            }
            else
            {
                MessageBox.Show("Моля, въведете задача.", "Грешка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Бутон "Изтрий избраната"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex >= 0)
            {
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Моля, изберете задача за изтриване.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Бутон "Маркирай като готова"
        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex >= 0)
            {
                string task = lstTasks.SelectedItem.ToString();

                // Ако още не е маркирана като готова
                if (!task.StartsWith("[Готово] "))
                {
                    int index = lstTasks.SelectedIndex;
                    task = "[Готово] " + task;
                    lstTasks.Items[index] = task;
                }
                else
                {
                    MessageBox.Show("Тази задача вече е маркирана като готова.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Моля, изберете задача за маркиране.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
