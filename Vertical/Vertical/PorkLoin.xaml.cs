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
    /// Interaction logic for PorkLoin.xaml
    /// </summary>
    public partial class PorkLoin : UserControl
    {
        public Boolean checkStatus = false;
        public int pos = 0;
        public static int Porktime = 30;
        public static string[] Porkattributes = new string[8];
        public PorkLoin()
        {
            InitializeComponent();
            Porkattributes[0] = "pork";
            Porkattributes[1] = "olive oil";
            Porkattributes[2] = "salt";
            Porkattributes[3] = "loin";
            Porkattributes[4] = "chop";
            Porkattributes[5] = "apple";
            Porkattributes[6] = "cidar";
            Porkattributes[7] = "apple cidar sauce and pork loin chops";
        }

        private void like_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.check % 2 == 0)
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack.Children.Add(Favourite.pl1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;

                }
                Favourite.pl1.pos = -1;
            }
            else
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.pl1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                }
                Favourite.pl1.pos = 1;
            }

            Favourite.check++;

        }

        private void dislike_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.pl1.pos == 1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.pl1);
                    ScrollViewer1.pl.checkStatus = false;
                    ScrollViewer1.pl.like.Opacity = 100;
                    ScrollViewer1.pl.dislike.Opacity = 0;
                    Favourite.pl1.pos = 0;
                    if (Favourite.check % 2 == 0)
                    {
                        Favourite.check--;
                    }
                }
            }
            else if (Favourite.pl1.pos == -1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.pl1);
                    ScrollViewer1.pl.checkStatus = false;
                    ScrollViewer1.pl.like.Opacity = 100;
                    ScrollViewer1.pl.dislike.Opacity = 0;
                    Favourite.pl1.pos = 0;

                    if (Favourite.check % 2 != 0)
                    {
                        Favourite.check--;
                    }
                }
            }
        }
    }
}
