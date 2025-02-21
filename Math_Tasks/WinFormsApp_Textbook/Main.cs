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
            // 1. �������� �� �� �������� (�������) ���������� ����� �� TextBox-�����.
            //    ��� �� ���� �� �� ������ ����� ����, ���� �������, �� � 0 (��� �� ������� ��������� �� ������).

            int boysA = ParseIntOrZero(txtBoysA.Text);
            int girlsA = ParseIntOrZero(txtGirlsA.Text);

            int boysB = ParseIntOrZero(txtBoysB.Text);
            int girlsB = ParseIntOrZero(txtGirlsB.Text);

            int boysV = ParseIntOrZero(txtBoysV.Text);
            int girlsV = ParseIntOrZero(txtGirlsV.Text);

            // 2. ���������� ����� �� �������� (�������, ��������, ��� ����).
            bool sumBoys = rdbBoys.Checked;      // ����� ����� "�������"
            bool sumGirls = rdbGirls.Checked;    // ����� ����� "��������"
            bool sumAll = rdbAll.Checked;        // ����� ����� "����"

            // 3. ��������� ���������� �� ���������
            int total = 0;

            // 4. ����������� ��� CheckBox-� �� ��������� � �������� �����������

            // --- 8 � ���� ---
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

            // --- 8 � ���� ---
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

            // --- 8 � ���� ---
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

            // 5. ��������� ���������
            lblResult.Text = "����: " + total;
        }

        // ������� �����: ������ �� �������� ������ � int. ��� �� �����, ����� 0.
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
