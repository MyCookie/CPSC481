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
        public static bool checkStatus = false;
        public static bool todoStatus = false;
        public static int favColumn = -1; //Not in list
        public static int todoColumn = -1; //Not in list


        // 0 = Favourite; 1 = Todo; 2 = Home; 3 = Search
        public static BlackBean[] instanceArray = new BlackBean[4];

       

    

        //Sorting variables
        public static int time = 35;
        public static int difficulty = 72; 
        public static int ingredients = 9; 

        public static string[] attributes = new string[9];//pseudofinish
        public BlackBean()
        {

            InitializeComponent();
            attributes[0] = "beans";
            attributes[1] = "black";
            attributes[2] = "chili";
            attributes[3] = "cheese";
            attributes[4] = "crumbs";
            attributes[5] = "garlic";
            attributes[6] = "eggs";
            attributes[7] = "veggie";
            attributes[8] = "burger";
            //UNFINISHED

        }


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
                    Favourite.favouriteStack.Children.Add(Favourite.blackbean1);
                    favColumn = 0; //Left side
                }
                else //Right side
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.blackbean1);
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
                    Favourite.favouriteStack1.Children.Remove(Favourite.blackbean1);
                }
                if (favColumn == 0)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.blackbean1);
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
                    ToDo.todoLeftStack.Children.Add(ToDo.blackbean1);
                    todoColumn= 0; //Left side
                }
                else //Right side
                {
                    ToDo.todoRightStack.Children.Add(ToDo.blackbean1);
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
                    ToDo.todoRightStack.Children.Remove(ToDo.blackbean1);
                }
                if (todoColumn == 0) //Left column
                {
                    ToDo.todoLeftStack.Children.Remove(ToDo.blackbean1);
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
/*
     public static string[] attributes = new string[8];
        public static int Beantime = 10;
        public int pos = 0;
        public BlackBean()

            InitializeComponent();
            attributes[0] = "beans";
            attributes[1] = "black";
            attributes[2] = "chili";
            attributes[3] = "cheese";
            attributes[4] = "crumbs";
            attributes[5] = "garlic";
            attributes[6] = "eggs";
            attributes[7] = "black bean veggie burger";
*/
