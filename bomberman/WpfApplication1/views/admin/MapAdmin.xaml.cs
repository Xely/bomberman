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
using wpfBomberman.viewmodel;

namespace wpfBomberman.views.admin
{
    /// <summary>
    /// Interaction logic for MapAdmin.xaml
    /// </summary>
    public partial class MapAdmin : Page
    {
        public MapAdmin()
        {
            InitializeComponent();
            this.DataContext = new MapAdminVM(this);
        }
    }
}
