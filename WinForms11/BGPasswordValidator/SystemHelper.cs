

namespace BGPasswordValidator
{
    public class SystemHelper
    {
        /// <summary>
        /// Статичен метод със switch-case – връща текстовото съобщение според score.
        /// </summary>
        public static string GetSecurityMessage(int score)
        {
            switch (score) // ЗАДЪЛЖИТЕЛЕН switch-case
            {
                case 1:
                    return "Много слаба защита";

                case 2:
                    return "Средна защита";

                case 3:
                    return "Отлична защита";

                default:
                    return "Непознато ниво на защита";
            }
        }
    }
}
