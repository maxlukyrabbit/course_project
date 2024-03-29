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
        private course_projectEntities4 db = new course_projectEntities4();

        public static List<logs> list;

        public Window1()
        {
            InitializeComponent();
            list = db.logs.ToList();
            logsG.ItemsSource = list;
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
            logsG.ItemsSource = list;
        }

        private void find_name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void stage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void stage_fin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var filteredList = list;

            string nameValue = find_name.Text;
            var nameIdArr = db.user.FirstOrDefault(x => x.firstname == nameValue);
            if (nameIdArr != null)
            {
                filteredList = filteredList.Where(x => x.user_id == nameIdArr.id_user).ToList();
            }

            string stageValue = stage.Text;
            var stageIdArr = db.stage_deal.FirstOrDefault(x => x.id_deal == stageValue);
            if (stageIdArr != null)
            {
                filteredList = filteredList.Where(x => x.initial_stage == stageIdArr.id_deal).ToList();
            }

            string stageFinValue = stage_fin.Text;
            var stageFinIdArr = db.stage_deal.FirstOrDefault(x => x.id_deal == stageFinValue);
            if (stageFinIdArr != null)
            {
                filteredList = filteredList.Where(x => x.final_stage == stageFinIdArr.id_deal).ToList();
            }

            logsG.ItemsSource = filteredList;
        }
    }
}
