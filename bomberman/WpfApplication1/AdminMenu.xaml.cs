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
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnBonus_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new BonusAdmin();
            window.Show();
        }

        private void btnBonusType_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new BonusTypeAdmin();
            window.Show();
        }

        private void btnCharacter_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new CharacterAdmin();
            window.Show();
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new ColorAdmin();
            window.Show();
        }

        private void btnMap_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new MapAdmin();
            window.Show();
        }

        private void btnNpc_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new NpcAdmin();
            window.Show();
        }

        private void btnTheme_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new ThemeAdmin();
            window.Show();
        }

        private void btnWall_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Content = new WallAdmin();
            window.Show();
        }

    }
}
