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

namespace HorizontalPrototype
{
    /// <summary>
    /// Interaction logic for FilterPage2.xaml
    /// </summary>
    public partial class FilterPage2 : UserControl
    {
        FilterList fl = new FilterList();

        public FilterPage2()
        {
            InitializeComponent();
            sp.Children.Add(fl);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MoreInfoLasagna());
        }
    }
}
