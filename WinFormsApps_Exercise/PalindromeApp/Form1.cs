namespace PalindromeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ���������� �� ��������� Click �� ������ "�������".
        /// </summary>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // ���������� ������ ��������
            lblResult.Text = "";

            // ������� ��������� ����� � ���������� ��������� ���������.
            string input = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("����, �������� �����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // �������� �� �� ������������� ����� � ���� �����.
            if (!int.TryParse(input, out int num))
            {
                MessageBox.Show("����, �������� ������� ���� �����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ���������� �������� �����, ����� �������� / � % �� ��������.
            if (IsPalindrome(num))
            {
                lblResult.Text = "������� � ���������!";
            }
            else
            {
                lblResult.Text = "������� �� � ���������!";
            }
        }

        /// <summary>
        /// �����, ����� ��������� ���� ���������� ����� � ���������,
        /// ����������� ����������� �������� �� ��������� �� �����.
        /// </summary>
        /// <param name="number">�������, ����� ������ �� �� �������.</param>
        /// <returns>����� true, ��� ������� � ���������, � �������� ������ false.</returns>
        private bool IsPalindrome(int number)
        {
            // �� �� ������� � ������������� �����, ������� ����������� ��������.
            int original = Math.Abs(number);
            int reversed = 0;
            int temp = original;

            // ������ temp � ��-������ �� 0
            while (temp > 0)
            {
                // ��������� ���������� ����� � ������� �� %
                int digit = temp % 10;

                // �������� ������� ��� ��������� �����.
                reversed = reversed * 10 + digit;

                // ���������� ���������� ����� ���� ������� �� 10
                temp /= 10;
            }

            // ��� ������������ ����� � ����� �� ���������, �� � ���������.
            return original == reversed;
        }
    }
}
