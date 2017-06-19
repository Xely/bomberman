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
using wpfBomberman.views.admin;

namespace wpfBomberman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WelcomeMenu : Window
    {
        public WelcomeMenu()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            //this.Content = new AdminMenu();
            Window window = new Window();
            window = new AdminMenu();
            window.Show();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window = new Board();
            window.Show();
        }

    }
}
