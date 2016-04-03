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

namespace Vertical
{
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : UserControl
    {
        public static ScrollViewer1 sv1 = new ScrollViewer1();
        public static SearchPage sp = new SearchPage();
        public static Favourite favourite = new Favourite();
        public static ToDo todo = new ToDo();
        public static double originalHeight;
        public HomeScreen()
        {
            InitializeComponent();
            sph.Children.Add(sv1);
            originalHeight = sph.Height;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sph.Children.Clear();
            sph.Children.Add(sv1);
            sph.Height = originalHeight;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            sph.Children.Clear();
            sv.ScrollToTop();
            sph.Children.Add(sp);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            sph.Children.Clear();
            sv.ScrollToTop();
            sph.Children.Add(favourite);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sph.Children.Clear();
            sv.ScrollToTop();
            sph.Height = 615;
            sph.Children.Add(todo);
        }
    }
}
