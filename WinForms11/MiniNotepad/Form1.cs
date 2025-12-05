namespace MiniNotepad
{
    public partial class Form1 : Form
    {
        // Текущ път до файла (ако има отворен/записан)
        private string currentFilePath = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Меню Файл -> Нов
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            currentFilePath = null;
            this.Text = "Mini Notepad - New document";
        }

        // Меню Файл -> Отвори...
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.Title = "Отвори текстов файл";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string text = File.ReadAllText(ofd.FileName);
                    txtContent.Text = text;
                    currentFilePath = ofd.FileName;
                    this.Text = "Mini Notepad - " + Path.GetFileName(currentFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка при отваряне на файла:\n" + ex.Message,
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Меню Файл -> Запиши
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                // Няма текущ файл -> Запиши като...
                SaveAs();
            }
            else
            {
                // Има текущ файл -> запис директно
                SaveToFile(currentFilePath);
            }
        }

        // Меню Файл -> Запиши като...
        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.Title = "Запиши текста в файл";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(sfd.FileName);
                currentFilePath = sfd.FileName;
                this.Text = "Mini Notepad - " + Path.GetFileName(currentFilePath);
            }
        }

        private void SaveToFile(string filePath)
        {
            try
            {
                File.WriteAllText(filePath, txtContent.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при запис във файла:\n" + ex.Message,
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Меню Файл -> Изход
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
