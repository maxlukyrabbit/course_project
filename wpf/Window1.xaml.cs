using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
        private course_projectEntities4 db = new course_projectEntities4();

        public static List<logs> list;

        public Window1()
        {
            InitializeComponent();
            list = db.logs.ToList();
            logsG.ItemsSource = db.logs.ToList();
            find_name.ItemsSource = db.user.Select(x => x.firstname).ToList();
            stage.ItemsSource = db.stage_deal.Select(x => x.name_stage).ToList();
            stage_fin.ItemsSource = db.stage_deal.Select(x => x.name_stage).ToList();
        }

        private void comeback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            var list2 = db.logs.ToList();
            string value = stage.Text;
            var id_arr = db.stage_deal.FirstOrDefault(x => x.name_stage == value);

            if (id.Text.Trim() != null)
            {
                var f = list2.Where(x => x.id_panel.Contains(id.Text)).ToList();
                list2 = f;
            }
            
            if (id_arr != null)
            {
                var f = list2.Where(x => x.initial_stage == id_arr.id_deal).ToList();
                list2 = f;
            }

            string value1 = stage_fin.Text;

            var id_arr1 = db.stage_deal.FirstOrDefault(x => x.name_stage == value1);
           
            if (id_arr1 != null)
            {
                var f = list2.Where(x => x.final_stage == id_arr1.id_deal).ToList();
                list2 = f;
            }

            string value2 = find_name.Text;
            var id_arr2 = db.user.FirstOrDefault(x => x.firstname == value2);
            if (id_arr2 != null)
            {
                var f = list2.Where(x => x.user_id == id_arr2.id_user).ToList();
                list2 = f;

            }

            if (error.IsChecked == true)
            {
                var f = list2.Where(x => x.result == false).ToList();
                list2 = f;
            }

            if (successful.IsChecked == true)
            {
                var f = list2.Where(x => x.result == true).ToList();
                list2 = f;
            }




            if (earlier.IsChecked == true)
            {
                var f = list2.Where(x => x.date.Date > Convert.ToDateTime(date.Text).Date).ToList();
                list2 = f;
            }

            if (matches.IsChecked == true)
            {
                var f = list2.Where(x => x.date.Date == Convert.ToDateTime(date.Text).Date).ToList();
                list2 = f;
            }

            if (later.IsChecked == true)
            {
                var f = list2.Where(x => x.date.Date < Convert.ToDateTime(date.Text).Date).ToList();
                list2 = f;
            }
            logsG.ItemsSource = list2;
        }

        private void rest_Click(object sender, RoutedEventArgs e)
        {
            find_name.Text = "";
            stage_fin.Text = "";
            stage.Text = "";
            
            logsG.ItemsSource = list;
            error.IsChecked = false;
            successful.IsChecked = false;
            later.IsChecked = false;
            matches.IsChecked = false;
            earlier.IsChecked = false;
            date.Text = "";
            id.Text = "";
        }

        private void DatePicker_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }


    }
}