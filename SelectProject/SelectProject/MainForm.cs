namespace SelectProject
{
    public partial class MainForm : Form
    {
        // Списък с налични проекти
        private List<string> availableProjects = new List<string>();
        // Списък с избрани проекти, асоциирани с екип
        private List<AssociatedProject> selectedProjects = new List<AssociatedProject>();
        // Генератор на случайни числа
        private Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
            InitializeProjects();
            InitializeTeams();
        }

        // Метод за инициализиране на проектите
        private void InitializeProjects()
        {
            availableProjects = new List<string>
                {
                    "Calculator",
                    "Unit Converter",
                    "Quiz Game",
                    "To-Do List",
                    "Timer",
                    "Traffic light",
                    "GPA calculator",
                    "Rock-Paper-Scissors",
                    "Picture Viewer",
                    "Math Practice"
                };

            selectedProjects = new List<AssociatedProject>();

            // Зареждаме наличните проекти в ListBox-а
            UpdateAvailableProjectsListBox();
        }

        // Инициализация на контролата за избор на екип
        private void InitializeTeams()
        {
            cmbTeams.Items.Clear();
            cmbTeams.Items.Add("Екип 1");
            cmbTeams.Items.Add("Екип 2");
            cmbTeams.Items.Add("Екип 3");
            cmbTeams.Items.Add("Екип 4");
            cmbTeams.Items.Add("Екип 5");
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
            foreach (AssociatedProject assoc in selectedProjects)
            {
                lstSelectedProjects.Items.Add(assoc.ToString());
            }
        }


        // Събитието при натискане на бутона "Избери проект"
        private void btnSelectProject_Click(object sender, EventArgs e)
        {
            // Проверка дали има налични проекти
            if (availableProjects.Count == 0)
            {
                MessageBox.Show("Няма повече проекти за избор.");
                return;
            }

            // Проверка дали е избран екип
            if (cmbTeams.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете екип.");
                return;
            }

            // Избира случаен проект от наличните
            int index = rnd.Next(availableProjects.Count);
            string selectedProject = availableProjects[index];
            string selectedTeam = cmbTeams.SelectedItem?.ToString() ?? string.Empty;

            // Създаване на асоцииран проект и добавянето му в списъка с избрани проекти
            AssociatedProject assocProject = new AssociatedProject
            {
                Name = selectedProject,
                Team = selectedTeam
            };
            selectedProjects.Add(assocProject);
            // Премахване на избрания проект от наличните
            availableProjects.RemoveAt(index);

            // Обновяване на визуализацията на двата ListBox-а
            UpdateAvailableProjectsListBox();
            UpdateSelectedProjectsListBox();

            // Показване на избрания проект с асоцииран екип в етикета
            lblSelectedProject.Text = $"Избран проект: {selectedProject} ({selectedTeam})";
        }

        // Събитие за изтриване на избран проект от списъка с асоциирани проекти
        private void btnRemoveProject_Click(object sender, EventArgs e)
        {
            // Проверка дали потребителят е избрал проект от ListBox-а с избрани проекти
            if (lstSelectedProjects.SelectedIndex < 0)
            {
                MessageBox.Show("Моля, изберете проект за изтриване.");
                return;
            }

            // Вземане на индекса на избрания елемент
            int selectedIndex = lstSelectedProjects.SelectedIndex;
            // Вземане на асоциирания проект от списъка с избрани проекти
            AssociatedProject projectToRemove = selectedProjects[selectedIndex];

            // Премахване на проекта от списъка с избрани проекти
            selectedProjects.RemoveAt(selectedIndex);

            // (Опционално) Добавяне на името на проекта обратно в списъка с налични проекти,
            // за да може проектът да бъде избран отново
            availableProjects.Add(projectToRemove.Name);

            // Обновяване на визуализацията на двата ListBox-а
            UpdateSelectedProjectsListBox();
            UpdateAvailableProjectsListBox();

            // (Опционално) Можеш да актуализираш и другите елементи от интерфейса, ако е необходимо.
        }
        // Събитие за редактиране на избран проект от списъка с налични проекти
        private void btnEditAvailableProject_Click(object sender, EventArgs e)
        {
            if (lstAvailableProjects.SelectedIndex < 0)
            {
                MessageBox.Show("Моля, изберете проект за редактиране от наличните проекти.");
                return;
            }
            int selectedIndex = lstAvailableProjects.SelectedIndex;
            string currentProjectName = availableProjects[selectedIndex];

            // Използваме InputBox за въвеждане на ново име.
            // За да използвате InputBox, добавете препратка към Microsoft.VisualBasic.
            string newProjectName = Microsoft.VisualBasic.Interaction.InputBox(
                "Въведете ново име за проекта:",
                "Редактиране на проект",
                currentProjectName);

            if (!string.IsNullOrWhiteSpace(newProjectName) && newProjectName != currentProjectName)
            {
                availableProjects[selectedIndex] = newProjectName;
                UpdateAvailableProjectsListBox();
            }
        }
        // Събитие за изтриване на избран проект от списъка с налични проекти
        private void btnDeleteAvailableProject_Click(object sender, EventArgs e)
        {
            if (lstAvailableProjects.SelectedIndex < 0)
            {
                MessageBox.Show("Моля, изберете проект за изтриване от наличните проекти.");
                return;
            }
            int selectedIndex = lstAvailableProjects.SelectedIndex;
            availableProjects.RemoveAt(selectedIndex);
            UpdateAvailableProjectsListBox();
        }
        // Клас за съхранение на информация за асоцииран проект и екип
        public class AssociatedProject
        {
            public string Name { get; set; } = string.Empty;
            public string Team { get; set; } = string.Empty;
            public override string ToString() => $"{Name} ({Team})";
        }
    }
}
