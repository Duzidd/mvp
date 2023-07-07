using mvp.Views;
using System;
using System.Collections.Generic;
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

namespace WPF_LoginForm.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MessageBox.Show("połączono");

                    // Wykonaj operacje na bazie danych


                }
                catch (Exception ex)
                {

                    MessageBox.Show("błąd");
                }
            }
        }

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            string f = txtUser.Text.Trim();
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
    }
}