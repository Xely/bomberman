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
using wpfBomberman.entities;

namespace wpfBomberman.views.usercontrols
{
    /// <summary>
    /// Interaction logic for MapUserControl.xaml
    /// </summary>
    public partial class MapUserControl : UserControlBase
    {
        private Map map;

        public Map Map
        {
            get { return map; }
            set
            {
                map = value;
                base.OnPropertyChanged("Map");
            }
        }

        public MapUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
