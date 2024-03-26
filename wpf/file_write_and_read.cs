using System;
using System.IO;

namespace course_project
{
    public class file_write_and_read
    {
        public static void file_write(string text)
        {
            try
            {
                string filePath = "user.txt";

                File.WriteAllText(filePath, text);

                
            }
            catch (Exception e)
            {
                
            }
        }


        public static string file_read()
        {
            try
            {
                string filePath = "user.txt";
                string data = File.ReadAllText(filePath);
                return data;
            }
            catch (Exception e)
            {
                return "Ошибка при чтении данных из файла: " + e.Message;
            }
        }
    }
}
