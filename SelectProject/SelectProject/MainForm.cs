namespace SelectProject
{
    public partial class MainForm : Form
    {
        // Списък с налични проекти
        private List<string> availableProjects;
        // Списък с избрани проекти
        private List<string> selectedProjects;
        // Генератор на случайни числа
        private Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
            InitializeProjects();
        }

        // Метод за инициализиране на проектите
        private void InitializeProjects()
        {
            availableProjects = new List<string>
            {
                "Проект 1",
                "Проект 2",
                "Проект 3",
                "Проект 4",
                "Проект 5",
                "Проект 6",
                "Проект 7",
                "Проект 8",
                "Проект 9",
                "Проект 10",
                "Проект 11"

                    
                // Добави още проекти по желание
            };

            selectedProjects = new List<string>();

            // Зареждаме наличните проекти в ListBox-а
            UpdateAvailableProjectsListBox();
        }

        // Обновява ListBox-а с налични проекти
        private void UpdateAvailableProjectsListBox()
        {
            lstAvailableProjects.Items.Clear();
            foreach (string project in availableProjects)
            {
                lstAvailableProjects.Items.Add(project);
            }
        }

        // Обновява ListBox-а с избрани проекти
        private void UpdateSelectedProjectsListBox()
        {
            lstSelectedProjects.Items.Clear();
            foreach (string project in selectedProjects)
            {
                lstSelectedProjects.Items.Add(project);
            }
        }

        // Събитието при натискане на бутона "Избери проект"
        private void btnSelectProject_Click(object sender, EventArgs e)
        {
            if (availableProjects.Count == 0)
            {
                MessageBox.Show("Няма повече проекти за избор.");
                return;
            }

            // Избира случаен проект от наличните
            int index = rnd.Next(availableProjects.Count);
            string selectedProject = availableProjects[index];

            // Добави избрания проект към списъка с избрани проекти
            selectedProjects.Add(selectedProject);
            // Премахни го от наличните проекти
            availableProjects.RemoveAt(index);

            // Обнови визуализацията на двата ListBox-а
            UpdateAvailableProjectsListBox();
            UpdateSelectedProjectsListBox();

            // Показване на избрания проект в етикета
            lblSelectedProject.Text = $"Избран проект: {selectedProject}";
        }
    }
}
