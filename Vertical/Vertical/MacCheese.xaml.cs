using System;
using System.Collections;
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
    /// Interaction logic for MacCheese.xaml
    /// </summary>
    public partial class MacCheese : UserControl
    {
        public Boolean checkStatus = false;
        private int pos = 0;
        public static int Mactime = 5;
        public static string[] Macattributes = new string[4];
        public MacCheese()
        {
            InitializeComponent();
            Macattributes[0] = "macaroni";
            Macattributes[1] = "milk";
            Macattributes[2] = "cheese";
            Macattributes[3] = "mac and cheese";

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.check%2 == 0)
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack.Children.Add(Favourite.mc1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;

                }
                Favourite.mc1.pos = -1;
            }
            else
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.mc1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                }
                Favourite.mc1.pos = 1;
            }

            Favourite.check++;

        }

        private void mcbutton1_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.mc1.pos == 1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.mc1);
                    ScrollViewer1.mc.checkStatus = false;
                    ScrollViewer1.mc.like.Opacity = 100;
                    ScrollViewer1.mc.dislike.Opacity = 0;
                    Favourite.mc1.pos = 0;
                    if (Favourite.check % 2 == 0)
                    {
                        Favourite.check--;
                    }
                }
            }
            else if (Favourite.mc1.pos == -1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.mc1);
                    ScrollViewer1.mc.checkStatus = false;
                    ScrollViewer1.mc.like.Opacity = 100;
                    ScrollViewer1.mc.dislike.Opacity = 0;
                    Favourite.mc1.pos = 0;

                    if (Favourite.check % 2 != 0)
                    {
                        Favourite.check--;
                    }
                }
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
