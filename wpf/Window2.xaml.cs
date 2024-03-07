using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace course_project
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public static int id_user = 0;
        course_projectEntities1 db = new course_projectEntities1();
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = db.user.Where(x => x.token == tokenT.Text);
            int? level = 1;
            

            if (list != null)
            {
                foreach (var item in list)
                {
                    level = item.access_level;
                    id_user = item.id_user;
                }
                
                if (level > 1)
                {
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Нет прав!");
                }
                
            }
        }
    }
}
