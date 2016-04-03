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
    /// Interaction logic for BlackBean.xaml
    /// </summary>
    public partial class BlackBean : UserControl
    {
        public static string[] Beanattributes = new string[8];
        public Boolean checkStatus = false;
        public static int Beantime = 10;
        public int pos = 0;
        public BlackBean()
        {
            InitializeComponent();
            Beanattributes[0] = "beans";
            Beanattributes[1] = "black";
            Beanattributes[2] = "chili";
            Beanattributes[3] = "cheese";
            Beanattributes[4] = "crumbs";
            Beanattributes[5] = "garlic";
            Beanattributes[6] = "eggs";
            Beanattributes[7] = "black bean veggie burger";


        }
        private void like_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.check % 2 == 0)
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack.Children.Add(Favourite.blackbean1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;

                }
                Favourite.blackbean1.pos = -1;
            }
            else
            {
                if (checkStatus == false)
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.blackbean1);
                    like.Opacity = 0;
                    dislike.Opacity = 100;
                    checkStatus = true;
                }
                Favourite.blackbean1.pos = 1;
            }

            Favourite.check++;

        }

        private void dislike_Click(object sender, RoutedEventArgs e)
        {
            if (Favourite.blackbean1.pos == 1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.blackbean1);
                    ScrollViewer1.bb.checkStatus = false;
                    ScrollViewer1.bb.like.Opacity = 100;
                    ScrollViewer1.bb.dislike.Opacity = 0;
                    Favourite.blackbean1.pos = 0;
                    if (Favourite.check % 2 == 0)
                    {
                        Favourite.check--;
                    }
                }
            }
            else if (Favourite.blackbean1.pos == -1)
            {
                if (checkStatus == true)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.blackbean1);
                    ScrollViewer1.bb.checkStatus = false;
                    ScrollViewer1.bb.like.Opacity = 100;
                    ScrollViewer1.bb.dislike.Opacity = 0;
                    Favourite.blackbean1.pos = 0;

                    if (Favourite.check % 2 != 0)
                    {
                        Favourite.check--;
                    }
                }
            }
        }
    }
}
