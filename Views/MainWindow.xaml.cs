using System.Data.SqlClient;
using mvp.Views;
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

namespace mvp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            // string f=login.Text.Trim();



        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string f = login.Text.Trim();
            if (f == "Admin")
            {
                Window1 win2 = new Window1();
                win2.Show();
                this.Close(); //only if you want to close the current form.
            }
            else if (f == "User")
            {
                user_page new44 = new user_page();
                new44.Show();
                this.Close();



            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
            /*Window1 win2 = new Window1();
            win2.Show();
            this.Close(); //only if you want to close the current form.*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {


            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Połączono z bazą danych.");
                    MessageBox.Show("połączono");

                    // Wykonaj operacje na bazie danych

                   /* connection.Close();
                    Console.WriteLine("Połączenie z bazą danych zamknięte.");
                    MessageBox.Show("close");*/
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Błąd połączenia z bazą danych: " + ex.Message);
                    MessageBox.Show("błąd");
                }
            }

        }
    }
}
