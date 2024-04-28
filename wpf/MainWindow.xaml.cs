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
        public static string id_panel;
        public MainWindow()
        {
            InitializeComponent();
            if (Window2.flag == true)
            {
                log.IsEnabled = false;
            }
        }

        private void fix_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string result1 = ID_verification.CheckString(text_panel.Text);


                if(result1 != "Успех")
                {
                    MessageBox.Show(result1);
                }

                else
                {
                    id_panel = text_panel.Text;
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



            try
            {
                string result1 = ID_verification.CheckString(text_panel.Text);


                if (result1 != "Успех")
                {
                    MessageBox.Show(result1);
                }

                else
                {
                    id_panel = text_panel.Text;
                    string id_deal = SearchDeal.SearchDealMethod(text_panel.Text);
                    string result = DealManager.сhangeStage_accepted_warehouse(id_deal);
                    MessageBox.Show(result);
                }

            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }


        }

        private void check_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                string result1 = ID_verification.CheckString(text_panel.Text);


                if (result1 != "Успех")
                {
                    MessageBox.Show(result1);
                }

                else
                {
                    id_panel = text_panel.Text;
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



            try
            {
                string result1 = ID_verification.CheckString(text_panel.Text);


                if (result1 != "Успех")
                {
                    MessageBox.Show(result1);
                }

                else
                {
                    id_panel = text_panel.Text;
                    string id_deal = SearchDeal.SearchDealMethod(text_panel.Text);
                    string result = DealManager.сhangeStage_ready_ship(id_deal);
                    MessageBox.Show(result);
                }

            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }



        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void out_Click(object sender, RoutedEventArgs e)
        {
            file_write_and_read.file_write(" ");
            Window2 window = new Window2();
            window.Show();
            this.Close();
        }
    }
}
