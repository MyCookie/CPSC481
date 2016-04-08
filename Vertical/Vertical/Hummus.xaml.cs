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
        public static bool checkStatus = false;
        public static bool todoStatus = false;
        public static int favColumn = -1; //Not in list
        public static int todoColumn = -1; //Not in list


        // 0 = Favourite; 1 = Todo; 2 = Home; 3 = Search
        public static Hummus[] instanceArray = new Hummus[4];

        //Sorting variables
        public static int time = 10;
        public static int difficulty = 8;
        public static int ingredients = 77;

   
        public static string[] attributes = new string[8];
        public Hummus()
        {
            InitializeComponent();
            attributes[0] = "hummus";
            attributes[1] = "pita";
            attributes[2] = "olive oil";
            attributes[3] = "lemon";
            attributes[4] = "salt";
            attributes[5] = "garbanzo beans";
            attributes[6] = "paprika";
            attributes[7] = "tahini";
        }
            //UNFINISHED
            


        private void checkRefresh()
        {
            for (int i = 0; i < 4; i++)
            {
                if (checkStatus)
                {
                    instanceArray[i].like.Opacity = 0;
                    instanceArray[i].dislike.Opacity = 100;
                }
                else
                {
                    instanceArray[i].like.Opacity = 100;
                    instanceArray[i].dislike.Opacity = 0;
                }
                if (todoStatus)
                {
                    instanceArray[i].todoAdd.Opacity = 0;
                    instanceArray[i].todoRemove.Opacity = 100;
                }
                else
                {
                    instanceArray[i].todoAdd.Opacity = 100;
                    instanceArray[i].todoRemove.Opacity = 0;

                }
            }
        }

        private void like_Click(object sender, RoutedEventArgs e)
        {
            if (!checkStatus)
            {
                checkStatus = true;
                if (Favourite.check % 2 == 0) //Left side
                {
                    Favourite.favouriteStack.Children.Add(Favourite.hummus1);
                    favColumn = 0; //Left side
                }
                else //Right side
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.hummus1);
                    favColumn = 1; //Right side
                }
                Favourite.check++;
            }
            checkRefresh();
        }

        private void dislike_Click(object sender, RoutedEventArgs e)
        {
            if (checkStatus)
            {
                if (favColumn == 1)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.hummus1);
                }
                if (favColumn == 0)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.hummus1);
                }
                checkStatus = false;
                if (favColumn == 1 && Favourite.check % 2 == 0) //Right side
                {
                    Favourite.check--;
                }
                else if (favColumn == 0 && Favourite.check % 2 != 0) //Left side
                {
                    Favourite.check--;
                }
                favColumn = -1; //Removed
            }
            checkRefresh();
        }

        private void todoAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!todoStatus)
            {
                todoStatus = true;
                if (ToDo.check % 2 == 0) //Left side
                {
                    ToDo.todoLeftStack.Children.Add(ToDo.hummus1);
                    todoColumn = 0; //Left side
                }
                else //Right side
                {
                    ToDo.todoRightStack.Children.Add(ToDo.hummus1);
                    todoColumn = 1; //Right side
                }
                ToDo.check++;
            }
            checkRefresh();
        }

        private void todoRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (todoStatus)
            {
                todoStatus = false;
                if (todoColumn == 1) //Right column
                {
                    ToDo.todoRightStack.Children.Remove(ToDo.hummus1);
                }
                if (todoColumn == 0) //Left column
                {
                    ToDo.todoLeftStack.Children.Remove(ToDo.hummus1);
                }
                todoStatus = false;
                if (todoColumn == 1 && ToDo.check % 2 == 0) //Right side
                {
                    ToDo.check--;
                }
                else if (todoColumn == 0 && ToDo.check % 2 != 0) //Left side
                {
                    ToDo.check--;
                }
                todoColumn = -1; //Removed
            }
            checkRefresh();
        }
    }
}
