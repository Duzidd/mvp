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

namespace mvp.Views
{
    /// <summary>
    /// Logika interakcji dla klasy user_page.xaml
    /// </summary>
    public partial class user_page : Window
    {
        public user_page()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            add_product win3 = new add_product();
            win3.Show();
            this.Close(); //only if you want to close the current form.
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

            Move_product win4 = new Move_product();
            win4.Show();
            this.Close(); //only if you want to close the current form.
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Edit_product win4 = new Edit_product();
            win4.Show();
            this.Close(); //only if you want to close the current form.
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Window win2 = new MainWindow();
            win2.Show();
            this.Close(); //only if you want to close the current form.
        }
    }
}
