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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace course_project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fix_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(text_panel.Text == "")
                {
                    MessageBox.Show("Введите номер панели");
                }

                else
                {
                    string id_deal = SearchDeal.SearchDealMethod(text_panel.Text);
                    string result = DealManager.сhangeStage_fix(id_deal);
                    MessageBox.Show(result);
                }
                
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void warehouse_Click(object sender, RoutedEventArgs e)
        {
            string id_deal = SearchDeal.SearchDealMethod(text_panel.Text);
            string result = DealManager.сhangeStage_accepted_warehouse(id_deal);
            MessageBox.Show(result);
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            

            try
            {
                if (text_panel.Text == "")
                {
                    MessageBox.Show("Введите номер панели");
                }

                else
                {
                    string id_deal = SearchDeal.SearchDealMethod(text_panel.Text);
                    string result = DealManager.сhangeStage_test(id_deal);
                    MessageBox.Show(result);
                }

            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }


        }

        private void sending_Click(object sender, RoutedEventArgs e)
        {
            
            string id_deal = SearchDeal.SearchDealMethod(text_panel.Text);
            string result = DealManager.сhangeStage_ready_ship(id_deal);
            MessageBox.Show(result);
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }
    }
}
