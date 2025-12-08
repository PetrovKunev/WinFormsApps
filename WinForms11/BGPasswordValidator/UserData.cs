

namespace BGPasswordValidator
{
    public class UserData
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }

        // Изчистване на данните (подготовка за нов вход)
        public void ClearData()
        {
            Username = string.Empty;
            Password = string.Empty;
            AccountType = string.Empty;
        }

        // Кратко резюме за отчета
        public string GetSummary()
        {
            return $"Потребител: {Username} | Роля: {AccountType}";
        }
    }
}
