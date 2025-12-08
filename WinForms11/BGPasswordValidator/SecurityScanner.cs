

using System.Text;

namespace BGPasswordValidator
{
    public class SecurityScanner
    {
        // Анализира паролата и връща оценка 1, 2 или 3
        public int AnalyzePassword(string password)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasMinLength = false;

            if (!string.IsNullOrEmpty(password) && password.Length >= 8)
            {
                hasMinLength = true;
            }

            // for цикълът минава през всеки символ на паролата
            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];

                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
            }

            int score = 1; // по подразбиране – много слаба защита

            if (hasMinLength && (hasDigit || hasUpper))
            {
                score = 2; // средна защита
            }

            if (hasMinLength && hasDigit && hasUpper)
            {
                score = 3; // отлична защита
            }

            return score;
        }

        // Проверка на потребителското име с if/else
        public bool CheckUsernameValid(string name, out string message)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                message = "Името не може да бъде празно.";
                return false;
            }
            else if (name.Length < 3)
            {
                message = "Името е твърде кратко (минимум 3 символа).";
                return false;
            }
            else
            {
                message = "Името е валидно.";
                return true;
            }
        }
    }
}
