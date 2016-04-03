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
    /// Interaction logic for Hummus.xaml
    /// </summary>
    public partial class Hummus : UserControl
    {
        public Boolean checkStatus = false;
        public int pos = 0;
        public static int Humtime = 25;
        public static string[] Hummusattributes = new string[8];
        public Hummus()
        {
            InitializeComponent();
            Hummusattributes[0] = "hummus";
            Hummusattributes[1] = "pita";
            Hummusattributes[2] = "olive oil";
            Hummusattributes[3] = "lemon";
            Hummusattributes[4] = "salt";
            Hummusattributes[5] = "garbanzo beans";
            Hummusattributes[6] = "paprika";
            Hummusattributes[7] = "tahini";
        }

        private void like_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.check % 2 == 0)
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack.Children.Add(Favourite.hummus1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                    Favourite.hummus1.pos = -1;
                }
                Favourite.check++;
            }
            else
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.hummus1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                    Favourite.hummus1.pos = 1;
                }
                Favourite.check++;
            }
        }

        private void dislike_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.hummus1.pos == 1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.hummus1);
                    ScrollViewer1.hummus.checkStatus = false;
                    ScrollViewer1.hummus.like.Opacity = 100;
                    ScrollViewer1.hummus.dislike.Opacity = 0;
                    if (Favourite.check % 2 == 0)
                    {
                        Favourite.check--;
                    }
                }
            }
            else if (Favourite.hummus1.pos == -1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.hummus1);
                    ScrollViewer1.hummus.checkStatus = false;
                    ScrollViewer1.hummus.like.Opacity = 100;
                    ScrollViewer1.hummus.dislike.Opacity = 0;
                    if (Favourite.check % 2 != 0)
                    {
                        Favourite.check--;
                    }
                }
            }
        }


    }
}
