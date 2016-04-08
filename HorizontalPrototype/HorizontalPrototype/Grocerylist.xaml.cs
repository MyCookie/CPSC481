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
    /// Interaction logic for Grocerylist.xaml
    /// </summary>
    public partial class Grocerylist : UserControl
    {
        public Grocerylist()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainScreen());
        }

        private void PastaCheck_Checked(object sender, RoutedEventArgs e)
        {
            PastaCheck.Opacity = 0;
        }

        private void TamotoCheck_Checked(object sender, RoutedEventArgs e)
        {
            TamotoCheck.Opacity = 0;
        }

        private void MeatCheck_Checked(object sender, RoutedEventArgs e)
        {
            MeatCheck.Opacity = 0;
        }

        private void MushroomCheck_Checked(object sender, RoutedEventArgs e)
        {
            MushroomCheck.Opacity = 0;
        }

        private void CheeseCheck_Checked(object sender, RoutedEventArgs e)
        {
            CheeseCheck.Opacity = 0;
        }

        private void BasilCheck_Checked(object sender, RoutedEventArgs e)
        {
            BasilCheck.Opacity = 0;
        }
    }
}
