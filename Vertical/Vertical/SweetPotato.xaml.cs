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
    /// Interaction logic for SweetPotato.xaml
    /// </summary>
    public partial class SweetPotato : UserControl
    {
        public Boolean checkStatus = false;
        public int pos = 0;
        public static int Sweettime = 5;
        public static string[] Sweetattributes = new string[6];
        public SweetPotato()
        {
            InitializeComponent();
            Sweetattributes[0] = "mashed";
            Sweetattributes[1] = "milk";
            Sweetattributes[2] = "butter";
            Sweetattributes[3] = "sugar";
            Sweetattributes[4] = "sweet potato";
            Sweetattributes[5] = "flour";

        }

        private void like_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.check % 2 == 0)
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack.Children.Add(Favourite.sweet1);
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
                    Favourite.favouriteStack1.Children.Add(Favourite.sweet1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                }
                Favourite.sweet1.pos = 1;
            }

            Favourite.check++;

        }

        private void dislike_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.sweet1.pos == 1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.sweet1);
                    ScrollViewer1.sweet.checkStatus = false;
                    ScrollViewer1.sweet.like.Opacity = 100;
                    ScrollViewer1.sweet.dislike.Opacity = 0;
                    Favourite.sweet1.pos = 0;
                    if (Favourite.check % 2 == 0)
                    {
                        Favourite.check--;
                    }
                }
            }
            else if (Favourite.sweet1.pos == -1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.sweet1);
                    ScrollViewer1.sweet.checkStatus = false;
                    ScrollViewer1.sweet.like.Opacity = 100;
                    ScrollViewer1.sweet.dislike.Opacity = 0;
                    Favourite.sweet1.pos = 0;

                    if (Favourite.check % 2 != 0)
                    {
                        Favourite.check--;
                    }
                }
            }
        }
    }
}
