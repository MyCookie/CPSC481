﻿using System;
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
        public static bool checkStatus = false;
        public static bool todoStatus = false;
        public static int favColumn = -1; //Not in list
        public static int todoColumn = -1; //Not in list


        // 0 = Favourite; 1 = Todo; 2 = Home; 3 = Search
        public static MacCheese[] instanceArray = new MacCheese[4];
        
        //Sorting variables
        public static int time = 44;
        public static int difficulty = 6;
        public static int ingredients = 4;

        public static string[] attributes = new string[4]; //UNFINISHED
        public MacCheese()
        {
            InitializeComponent();
            attributes[0] = "macaroni";
            attributes[1] = "milk";
            attributes[2] = "cheese";
            attributes[3] = "mac and cheese";
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
                    Favourite.favouriteStack.Children.Add(Favourite.mc1);
                    favColumn = 0; //Left side
                }
                else //Right side
                {
                    Favourite.favouriteStack1.Children.Add(Favourite.mc1);
                    favColumn = 1; //Right side
                }
                Favourite.check++;
            }
            checkRefresh();
        }

        private void dislike_Click(object sender, RoutedEventArgs e)
        {
            if(checkStatus)
            {
                if (favColumn == 1)
                {
                    Favourite.favouriteStack1.Children.Remove(Favourite.mc1);
                }
                if (favColumn == 0)
                {
                    Favourite.favouriteStack.Children.Remove(Favourite.mc1);
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
                    ToDo.todoLeftStack.Children.Add(ToDo.mc1);
                    todoColumn = 0; //Left side
                }
                else //Right side
                {
                    ToDo.todoRightStack.Children.Add(ToDo.mc1);
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
                    ToDo.todoRightStack.Children.Remove(ToDo.mc1);
                }
                if (todoColumn == 0) //Left column
                {
                    ToDo.todoLeftStack.Children.Remove(ToDo.mc1);
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

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
