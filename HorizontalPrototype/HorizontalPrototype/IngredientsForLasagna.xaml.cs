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
    /// Interaction logic for IngredientsForLasagna.xaml
    /// </summary>
    public partial class IngredientsForLasagna : UserControl
    {
        public IngredientsForLasagna()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PastaCheck.IsChecked= true;
            TamotoCheck.IsChecked = true;
            MushroomCheck.IsChecked = true;
            MeatCheck.IsChecked = true;
            CheeseCheck.IsChecked = true;
            BasilCheck.IsChecked = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MoreInfoLasagna());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new GroceryList2());
        }
    }
}
