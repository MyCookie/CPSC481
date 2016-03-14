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

namespace HorizPrototype
{
    /// <summary>
    /// Interaction logic for SpaghettiQuickInfo.xaml
    /// </summary>
    public partial class SpaghettiQuickInfo : UserControl
    {
        public string[] spaghetti_image = { "images/spaghetti/spaghetti.jpg", "images/spaghetti/spaghetti1.jpg", "images/spaghetti/spaghetti1.jpg" };
        public int spaghetti_image_i;
        public SpaghettiQuickInfo()
        {
            InitializeComponent();
            spaghetti_image_i = 0;
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            if (spaghetti_image_i >= 3) spaghetti_image_i = 0;
            else spaghetti_image_i++;
            SpaghettiQuickInfoImage.Source = new BitmapImage(new Uri(spaghetti_image[spaghetti_image_i], UriKind.Relative));
        }
    }
}
