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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        course_projectEntities4 db = new course_projectEntities4();
        public Window1()
        {
            InitializeComponent();
            logsG.ItemsSource = db.logs.ToList();
            find_name.ItemsSource = db.user.Select(x => x.firstname).ToList();
            stage.ItemsSource = db.stage_deal.Select(x => x.name_stage).ToList();
        }

        private void comeback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}