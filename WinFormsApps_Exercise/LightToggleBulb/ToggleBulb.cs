namespace LightToggleBulb
{
    public partial class ToggleBulb : Form
    {
        public ToggleBulb()
        {
            InitializeComponent();
            // �������������� �� PictureBox-� � ��������� ���������
            UpdateLightStatus();
        }

        // �������� ���������� lightOn, ������������ �������� �� false (���������� � ���������)
        private bool lightOn = false;

        // ����� �� ���������� �� ������������� � PictureBox-� ������ �������� ��������� �� ����������
        private void UpdateLightStatus()
        {
            if (lightOn)
            {
                // ��� ���������� � ��������, ��������� ������������� �� �������� ������
                pictureBoxBulb.Image = Properties.Resources.BulbOn;
            }
            else
            {
                // ��� ���������� � ���������, ��������� ������������� �� ��������� ������
                pictureBoxBulb.Image = Properties.Resources.BulbOff;
            }
        }

        // ���������� �� ��������� Click �� ������ buttonToggle
        private void buttonToggle_Click(object sender, EventArgs e)
        {
            // ������������ �� ���������� �� lightOn: ��� � false, ����� true � �������
            lightOn = !lightOn;

            // ������������� �� ������������� � PictureBox-� ������ ������ ���������
            UpdateLightStatus();
        }
    }
}
