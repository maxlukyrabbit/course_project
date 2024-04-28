using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace course_project
{
    public class ID_verification
    {
        public static string CheckString(string str)
        {
            if (str.Length > 10)
            {
                return "Строка содержит больше 10 цифр.";
            }

            if (!str.All(char.IsDigit))
            {
                return "Строка содержит недопустимые символы.";
            }

            if (str.Length < 10)
            {
                return "Строка содержит меньше 10 цифр.";
            }

            return "Успех";
        }
    }
}
