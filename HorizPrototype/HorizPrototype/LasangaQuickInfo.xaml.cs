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
    /// Interaction logic for LasangaQuickInfo.xaml
    /// <Image x:Name="LasangaQuickInfoImage" Height="158" Margin="70,10,60,106" Width="320" Source="images/lasagna/lasagna.jpg"/>
    /// </summary>
    public partial class LasangaQuickInfo : UserControl
    {
        public static int lasagna_images_i;
        string[] lasagna_images = { "images/lasagna/lasagna.jpg", "images/lasagna/lasagna1.jpg", "images/lasagna/lasagna2.jpg", "images/lasagna/lasagna3.jpg" };

        public LasangaQuickInfo()
        {
            InitializeComponent();
            lasagna_images_i = 0;
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            lasagna_images_i++;
            if (lasagna_images_i >= 4) lasagna_images_i = 0;
            LasangaQuickInfoImage.Source = new BitmapImage(new Uri(lasagna_images[lasagna_images_i], UriKind.Relative));
        }
    }
}
