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
    /// Interaction logic for Enchiladas.xaml
    /// </summary>
    public partial class Enchiladas : UserControl
    {
        public static string[] Enchiladasattributes = new string[9];
        public Boolean checkStatus = false;
        public static int Enchtime = 15;
        public int pos = 0;
        public Enchiladas()
        {
            InitializeComponent();
            Enchiladasattributes[0] = "butter";
            Enchiladasattributes[1] = "sour cream";
            Enchiladasattributes[2] = "green onions";
            Enchiladasattributes[3] = "onions";
            Enchiladasattributes[4] = "garlic";
            Enchiladasattributes[5] = "tortillas";
            Enchiladasattributes[6] = "milk";
            Enchiladasattributes[7] = "enchiladas";
            Enchiladasattributes[8] = "chicken";



        }
        private void like_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.check % 2 == 0)
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack.Children.Add(Favourite.ce1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;

                }
                Favourite.ce1.pos = -1;
            }
            else
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.ce1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                }
                Favourite.ce1.pos = 1;
            }

            Favourite.check++;

        }

        private void dislike_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.ce1.pos == 1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.ce1);
                    ScrollViewer1.ce.checkStatus = false;
                    ScrollViewer1.ce.like.Opacity = 100;
                    ScrollViewer1.ce.dislike.Opacity = 0;
                    Favourite.ce1.pos = 0;
                    if (Favourite.check % 2 == 0)
                    {
                        Favourite.check--;
                    }
                }
            }
            else if (Favourite.ce1.pos == -1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.ce1);
                    ScrollViewer1.ce.checkStatus = false;
                    ScrollViewer1.ce.like.Opacity = 100;
                    ScrollViewer1.ce.dislike.Opacity = 0;
                    Favourite.ce1.pos = 0;

                    if (Favourite.check % 2 != 0)
                    {
                        Favourite.check--;
                    }
                }
            }
        }
    }
}
