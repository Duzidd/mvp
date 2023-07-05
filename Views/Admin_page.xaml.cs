using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace mvp.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window win2 = new MainWindow();
            win2.Show();
            this.Close(); //only if you want to close the current form.
        }
        /*
                private void Button_Click_1(object sender, RoutedEventArgs e)
                {

                    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqll = "select * from [DbTest].[dbo].[Products]";
                        xyzz.ItemsSource= SqlCommand(sql)

                    }

                }*/
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM [DbTest].[dbo].[Products]";

                // Tworzenie obiektu SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                // Tworzenie obiektu DataTable
                DataTable dataTable = new DataTable();

                // Wypełnianie DataTable danymi z bazy danych
                adapter.Fill(dataTable);

                // Przypisanie DataTable do DataGrida
                xyzz.ItemsSource = dataTable.DefaultView;
            }
        }

    }

}



