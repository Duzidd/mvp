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
    /// Logika interakcji dla klasy add_product.xaml
    /// </summary>
    public partial class add_product : Window
    {
        public add_product()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            user_page new44 = new user_page();
            new44.Show();
            this.Close();
        }
    }
}
