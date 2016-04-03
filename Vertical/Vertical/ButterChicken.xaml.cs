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
    /// Interaction logic for ButterChicken.xaml
    /// </summary>
    public partial class ButterChicken : UserControl
    {
        public static string[] Butterattributes = new string[3];
        public Boolean checkStatus = false;
        public static int Buttertime = 35;
        public int pos = 0;
        public ButterChicken()
        {
            InitializeComponent();
            Butterattributes[0] = "butter";
            Butterattributes[1] = "chicken";
            Butterattributes[2] = "butter chicken";

        }

        private void like_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.check%2 == 0)
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack.Children.Add(Favourite.butterchicken1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;

                }
                Favourite.butterchicken1.pos = -1;
            }
            else
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.butterchicken1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                }
                Favourite.butterchicken1.pos = 1;
            }

            Favourite.check++;

        }

        private void dislike_Click(object sender, RoutedEventArgs e)
        {
                        if (Favourite.butterchicken1.pos == 1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.butterchicken1);
                    ScrollViewer1.bc.checkStatus = false;
                    ScrollViewer1.bc.like.Opacity = 100;
                    ScrollViewer1.bc.dislike.Opacity = 0;
                    Favourite.butterchicken1.pos = 0;
                    if (Favourite.check % 2 == 0)
                    {
                        Favourite.check--;
                    }
                }
            }
            else if (Favourite.butterchicken1.pos == -1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.butterchicken1);
                    ScrollViewer1.bc.checkStatus = false;
                    ScrollViewer1.bc.like.Opacity = 100;
                    ScrollViewer1.bc.dislike.Opacity = 0;
                    Favourite.butterchicken1.pos = 0;

                    if (Favourite.check % 2 != 0)
                    {
                        Favourite.check--;
                    }
                }
            }
        }
        }
    }

