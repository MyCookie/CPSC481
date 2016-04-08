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
    /// Interaction logic for MoreInfoLasagna.xaml
    /// </summary>
    public partial class MoreInfoLasagna : UserControl
    {
        public int lasagna_images_i;
        string[] lasagna_images = { "images/lasagna/lasagna.jpg", "images/lasagna/lasagna1.jpg", "images/lasagna/lasagna2.jpg", "images/lasagna/lasagna3.jpg" };
        public MoreInfoLasagna()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightArrow_Click(object sender, RoutedEventArgs e)
        {
            lasagna_images_i++;
            if (lasagna_images_i >= 4) lasagna_images_i = 0;
            lasImage.Source = new BitmapImage(new Uri(lasagna_images[lasagna_images_i], UriKind.Relative));
        }

        private void LeftArrow_Click(object sender, RoutedEventArgs e)
        {
            if (lasagna_images_i == 0) lasagna_images_i = 3;
            else lasagna_images_i--;
            lasImage.Source = new BitmapImage(new Uri(lasagna_images[lasagna_images_i], UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainScreen());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new IngredientsForLasagna());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Instruction());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new FilterPage2());
        }



    }
}
