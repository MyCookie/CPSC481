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
    /// Interaction logic for Mashed.xaml
    /// </summary>
    public partial class Mashed : UserControl
    {
        public Boolean checkStatus = false;
        public int pos = 0;
        public static int Mashtime = 3;
        public static string[] Mashattributes = new string[6];
        public Mashed()
        {
            InitializeComponent();
            Mashattributes[0] = "mashed";
            Mashattributes[1] = "mash";
            Mashattributes[2] = "potato";
            Mashattributes[3] = "garlic";
            Mashattributes[4] = "cheese";
            Mashattributes[5] = "mashed potatoes";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.check%2 == 0)
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack.Children.Add(Favourite.mash1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                    Favourite.mash1.pos = -1;
                }
                Favourite.check++;
            }
            else
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.mash1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                    Favourite.mash1.pos = 1;
                }
                Favourite.check++;
            }
        }

        private void mash1_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.mash1.pos == 1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.mash1);
                    ScrollViewer1.mash.checkStatus = false;
                    ScrollViewer1.mash.like.Opacity = 100;
                    ScrollViewer1.mash.dislike.Opacity = 0;
                    if (Favourite.check % 2 == 0)
                    {
                        Favourite.check--;
                    }
                }
            }
            else if (Favourite.mash1.pos == -1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.mash1);
                    ScrollViewer1.mash.checkStatus = false;
                    ScrollViewer1.mash.like.Opacity = 100;
                    ScrollViewer1.mash.dislike.Opacity = 0;
                    if (Favourite.check % 2 != 0)
                    {
                        Favourite.check--;
                    }
                }
            }
        }
    }
}
