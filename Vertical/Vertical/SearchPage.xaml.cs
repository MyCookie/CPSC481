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
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : UserControl
    {
        public ArrayList results = new ArrayList();
        public ArrayList statsR = new ArrayList();
        public ArrayList sortList = new ArrayList();
        public ArrayList sortListR = new ArrayList();


        


        public PorkLoin pl = new PorkLoin();
        public MacCheese mc = new MacCheese();
        public BlackBean bb = new BlackBean();
        public Enchiladas ce = new Enchiladas();
        public SweetPotato sweet = new SweetPotato();
        public Mashed mash = new Mashed();
        public ButterChicken butter = new ButterChicken();
        public Hummus hummus = new Hummus();
        public int size = 0;
        public int no_results = 0;

        private string searching; //STRING FOR SEARCHING ATTRIBUTES WITH
        private ArrayList resultStorage = new ArrayList();
        private UserControl[] trueStorage = new UserControl[8];

        public SearchPage()
        {
            string[] str = new string[] { "Time", "Difficulty", "Rating" };
            InitializeComponent();

            //Initialize Array
            MacCheese.instanceArray[3] = mc;
            BlackBean.instanceArray[3] = bb;
            ButterChicken.instanceArray[3] = butter;
            Enchiladas.instanceArray[3] = ce;
            Hummus.instanceArray[3] = hummus;
            Mashed.instanceArray[3] = mash;
            PorkLoin.instanceArray[3] = pl;
            SweetPotato.instanceArray[3] = sweet;

            //Make dislike invisible
            mc.dislike.Opacity = 0;
            bb.dislike.Opacity = 0;
            butter.dislike.Opacity = 0;
            ce.dislike.Opacity = 0;
            hummus.dislike.Opacity = 0;
            mash.dislike.Opacity = 0;
            pl.dislike.Opacity = 0;
            sweet.dislike.Opacity = 0;

            //Make todoRemove invisible
            mc.todoRemove.Opacity = 0;
            bb.todoRemove.Opacity = 0;
            butter.todoRemove.Opacity = 0;
            ce.todoRemove.Opacity = 0;
            hummus.todoRemove.Opacity = 0;
            mash.todoRemove.Opacity = 0;
            pl.todoRemove.Opacity = 0;
            sweet.todoRemove.Opacity = 0;

            resultl.Opacity = 0;
            box.ItemsSource = str;
            box.Text = "Sort by";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            results.Clear();
            statsR.Clear();
            searchPagePanel.Children.Clear();
            stat.Children.Clear();
            no_results = 0;


            size = 0;
            resultStorage.Clear();
            resultLeft.Children.Clear();
            resultRight.Children.Clear();
            searching = searchBox.Text.ToString(); //UPDATE SEARCHING STRING
            if (((String)box.SelectedItem) == "Time")
            {
                timeSort();
            }
            else if (((String)box.SelectedItem) == "Difficulty")
            {
                difficultySort();
            }
            else if (((String)box.SelectedItem) == "Rating")
            {
                ratingSort();
            }
            else
            {
                alphaSort();
            }
            

            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    resultLeft.Children.Add(trueStorage[i]);
                }
                else
                {
                    resultRight.Children.Add(trueStorage[i]);
                }
            }
            if (size > 0)
            {
                resultl.Content = "Your search results for";
                resultl.Opacity = 100;
            }
            else
            {
                resultl.Content = "No search results found";
                resultl.Opacity = 100;
            }

        }

        private void searchBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            searchBox.Clear();
        }


        private void box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            results.Clear();
            statsR.Clear();
            searchPagePanel.Children.Clear();
            stat.Children.Clear();
            no_results = 0;


            size = 0;
            resultStorage.Clear();
            resultLeft.Children.Clear();
            resultRight.Children.Clear();
            searching = searchBox.Text.ToString(); //UPDATE SEARCHING STRING
            if (((String)box.SelectedItem) == "Time")
            {
                timeSort();
            }
            else if (((String)box.SelectedItem) == "Difficulty")
            {
                difficultySort();
            }
            else if (((String)box.SelectedItem) == "Rating")
            {
                ratingSort();
            }
            else
            {
                alphaSort();
            }


            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    resultLeft.Children.Add(trueStorage[i]);
                }
                else
                {
                    resultRight.Children.Add(trueStorage[i]);
                }
            }
            if (size > 0)
            {
                resultl.Content = "Your search results for";
                resultl.Opacity = 100;
            }
            else
            {
                resultl.Content = "No search results found";
                resultl.Opacity = 100;
            }
        }

        private void searchBox_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void timeSort()
        {
            //1(Time)
            for (int i = 0; i < Hummus.attributes.Length; i++)
            {
                if (searching.Contains(Hummus.attributes[i]))
                {
                    trueStorage[size] = hummus;
                    //resultStorage.Add(4);
                    size++;
                    break;
                }
            }
            //2(Time)
            for (int i = 0; i < BlackBean.attributes.Length; i++)
            {
                if (searching.Contains(BlackBean.attributes[i]))
                {
                    trueStorage[size] = bb;
                    //resultStorage.Add(1);
                    size++;
                    break;
                }
            }
            //3(Time)
            for (int i = 0; i < MacCheese.attributes.Length; i++)
            {
                if (searching.Contains(MacCheese.attributes[i]))
                {
                    trueStorage[size] = mc;
                    //resultStorage.Add(5);
                    size++;
                    break;
                }
            }
            //4(Time)
            for (int i = 0; i < Enchiladas.attributes.Length; i++)
            {
                if (searching.Contains(Enchiladas.attributes[i]))
                {
                    trueStorage[size] = ce;
                    //resultStorage.Add(3);
                    size++;
                    break;
                }
            }
            //5(Time)
            for (int i = 0; i < SweetPotato.attributes.Length; i++)
            {
                if (searching.Contains(SweetPotato.attributes[i]))
                {
                    trueStorage[size] = sweet;
                    //resultStorage.Add(8);
                    size++;
                    break;
                }
            }
            //6(Time)
            for (int i = 0; i < PorkLoin.attributes.Length; i++)
            {
                if (searching.Contains(PorkLoin.attributes[i]))
                {
                    trueStorage[size] = pl;
                    //resultStorage.Add(7);
                    size++;
                    break;
                }
            }
            //7(Time)
            for (int i = 0; i < ButterChicken.attributes.Length; i++)
            {
                if (searching.Contains(ButterChicken.attributes[i]))
                {
                    trueStorage[size] = butter;
                    //resultStorage.Add(2);
                    size++;
                    break;
                }
            }
            //8(Time)
            for (int i = 0; i < Mashed.attributes.Length; i++)
            {
                if (searching.Contains(Mashed.attributes[i]))
                {
                    trueStorage[size] = mash;
                    //resultStorage.Add(6);
                    size++;
                    break;
                }
            }
        }

        private void ratingSort()
        {
            //1(Rating)
            for (int i = 0; i < MacCheese.attributes.Length; i++)
            {
                if (searching.Contains(MacCheese.attributes[i]))
                {
                    trueStorage[size] = mc;
                    //resultStorage.Add(5);
                    size++;
                    break;
                }
            }
            //2(Rating)
            for (int i = 0; i < Mashed.attributes.Length; i++)
            {
                if (searching.Contains(Mashed.attributes[i]))
                {
                    trueStorage[size] = mash;
                    //resultStorage.Add(6);
                    size++;
                    break;
                }
            }
            //3(Rating)
            for (int i = 0; i < PorkLoin.attributes.Length; i++)
            {
                if (searching.Contains(PorkLoin.attributes[i]))
                {
                    trueStorage[size] = pl;
                    //resultStorage.Add(7);
                    size++;
                    break;
                }
            }
            //4(Rating)
            for (int i = 0; i < Hummus.attributes.Length; i++)
            {
                if (searching.Contains(Hummus.attributes[i]))
                {
                    trueStorage[size] = hummus;
                    //resultStorage.Add(4);
                    size++;
                    break;
                }
            }
            //5(Rating)
            for (int i = 0; i < BlackBean.attributes.Length; i++)
            {
                if (searching.Contains(BlackBean.attributes[i]))
                {
                    trueStorage[size] = bb;
                    //resultStorage.Add(1);
                    size++;
                    break;
                }
            }
            //6(Rating)
            for (int i = 0; i < Enchiladas.attributes.Length; i++)
            {
                if (searching.Contains(Enchiladas.attributes[i]))
                {
                    trueStorage[size] = ce;
                    //resultStorage.Add(3);
                    size++;
                    break;
                }
            }
            //7(Rating)
            for (int i = 0; i < ButterChicken.attributes.Length; i++)
            {
                if (searching.Contains(ButterChicken.attributes[i]))
                {
                    trueStorage[size] = butter;
                    //resultStorage.Add(2);
                    size++;
                    break;
                }
            }
            //8(Rating)
            for (int i = 0; i < SweetPotato.attributes.Length; i++)
            {
                if (searching.Contains(SweetPotato.attributes[i]))
                {
                    trueStorage[size] = sweet;
                    //resultStorage.Add(8);
                    size++;
                    break;
                }
            }
        }


        private void difficultySort()
        {            
            //1(Difficulty)
            for (int i = 0; i < MacCheese.attributes.Length; i++)
            {
                if (searching.Contains(MacCheese.attributes[i]))
                {
                    trueStorage[size] = mc;
                    //resultStorage.Add(5);
                    size++;
                    break;
                }
            }
            //2(Difficulty)
            for (int i = 0; i < Mashed.attributes.Length; i++)
            {
                if (searching.Contains(Mashed.attributes[i]))
                {
                    trueStorage[size] = mash;
                    //resultStorage.Add(6);
                    size++;
                    break;
                }
            }
            //3(Difficulty)
            for (int i = 0; i < SweetPotato.attributes.Length; i++)
            {
                if (searching.Contains(SweetPotato.attributes[i]))
                {
                    trueStorage[size] = sweet;
                    //resultStorage.Add(8);
                    size++;
                    break;
                }
            }
            //4(Difficulty)
            for (int i = 0; i < Enchiladas.attributes.Length; i++)
            {
                if (searching.Contains(Enchiladas.attributes[i]))
                {
                    trueStorage[size] = ce;
                    //resultStorage.Add(3);
                    size++;
                    break;
                }
            }            
            //5(Difficulty)
            for (int i = 0; i < PorkLoin.attributes.Length; i++)
            {
                if (searching.Contains(PorkLoin.attributes[i]))
                {
                    trueStorage[size] = pl;
                    //resultStorage.Add(7);
                    size++;
                    break;
                }
            }            
            //6(Difficulty)
            for (int i = 0; i < ButterChicken.attributes.Length; i++)
            {
                if (searching.Contains(ButterChicken.attributes[i]))
                {
                    trueStorage[size] = butter;
                    //resultStorage.Add(2);
                    size++;
                    break;
                }
            }
            //7(Difficulty)
            for (int i = 0; i < BlackBean.attributes.Length; i++)
            {
                if (searching.Contains(BlackBean.attributes[i]))
                {
                    trueStorage[size] = bb;
                    //resultStorage.Add(1);
                    size++;
                    break;
                }
            }            
            //8(Difficulty)
            for (int i = 0; i < Hummus.attributes.Length; i++)
            {
                if (searching.Contains(Hummus.attributes[i]))
                {
                    trueStorage[size] = hummus;
                    //resultStorage.Add(4);
                    size++;
                    break;
                }
            }
        }
        

        private void alphaSort()
        {
            //1(Alpha)
            for (int i = 0; i < BlackBean.attributes.Length; i++)
            {
                if (searching.Contains(BlackBean.attributes[i]))
                {
                    trueStorage[size] = bb;
                    //resultStorage.Add(1);
                    size++;
                    break;
                }
            }
            //2(Alpha)
            for (int i = 0; i < ButterChicken.attributes.Length; i++)
            {
                if (searching.Contains(ButterChicken.attributes[i]))
                {
                    trueStorage[size] = butter;
                    //resultStorage.Add(2);
                    size++;
                    break;
                }
            }
            //3(Alpha)
            for (int i = 0; i < Enchiladas.attributes.Length; i++)
            {
                if (searching.Contains(Enchiladas.attributes[i]))
                {
                    trueStorage[size] = ce;
                    //resultStorage.Add(3);
                    size++;
                    break;
                }
            }
            //4(Alpha)
            for (int i = 0; i < Hummus.attributes.Length; i++)
            {
                if (searching.Contains(Hummus.attributes[i]))
                {
                    trueStorage[size] = hummus;
                    //resultStorage.Add(4);
                    size++;
                    break;
                }
            }
            //5(Alpha)
            for (int i = 0; i < MacCheese.attributes.Length; i++)
            {
                if (searching.Contains(MacCheese.attributes[i]))
                {
                    trueStorage[size] = mc;
                    //resultStorage.Add(5);
                    size++;
                    break;
                }
            }
            //6(Alpha)
            for (int i = 0; i < Mashed.attributes.Length; i++)
            {
                if (searching.Contains(Mashed.attributes[i]))
                {
                    trueStorage[size] = mash;
                    //resultStorage.Add(6);
                    size++;
                    break;
                }
            }
            //7(Alpha)
            for (int i = 0; i < PorkLoin.attributes.Length; i++)
            {
                if (searching.Contains(PorkLoin.attributes[i]))
                {
                    trueStorage[size] = pl;
                    //resultStorage.Add(7);
                    size++;
                    break;
                }
            }
            //8(Alpha)
            for (int i = 0; i < SweetPotato.attributes.Length; i++)
            {
                if (searching.Contains(SweetPotato.attributes[i]))
                {
                    trueStorage[size] = sweet;
                    //resultStorage.Add(8);
                    size++;
                    break;
                }
            }
        }
    }
}



/* OLD Sorting code

    

            if (box.SelectedIndex > -1)
            {
                if (((String)box.SelectedItem) == "Time")
                {
                    searchPagePanel.Children.Clear();
                    stat.Children.Clear();
                    if ((size == 3) && ((results[0] == mc && results[1] == bb && results[2] == mash) || (results[0] == mc && results[1] == mash && results[2] == bb) || (results[0] == bb && results[1] == mc && results[2] == mash)))
                    {

                        sortListR.Clear();
                        sortList.Clear();
                        sortListR.Add(new MashStat());
                        sortListR.Add(new MacStats());
                        sortListR.Add(new BeanStat());
                        sortList.Add(mash);
                        sortList.Add(mc);
                        sortList.Add(bb);
                        for (int i = 0; i < size; i++)
                        {
                            UserControl uc = (UserControl)sortList[i];
                            UserControl uc1 = (UserControl)sortListR[i];
                            searchPagePanel.Children.Add(uc);
                            stat.Children.Add(uc1);
                        }
                    }
                }
                else if (((String)box.SelectedItem) == "Difficulty")
                {
                    searchPagePanel.Children.Clear();
                    stat.Children.Clear();
                    if ((size == 3) && (sortList[0] == mash && sortList[1] == mc && sortList[2] == bb))
                    {

                        sortListR.Clear();
                        sortList.Clear();
                        sortListR.Add(new MacStats());
                        sortListR.Add(new MashStat());
                        sortListR.Add(new BeanStat());
                        sortList.Clear();
                        sortList.Add(mc);
                        sortList.Add(mash);
                        sortList.Add(bb);
                        for (int i = 0; i < size; i++)
                        {
                            UserControl uc = (UserControl)sortList[i];
                            UserControl uc1 = (UserControl)sortListR[i];
                            searchPagePanel.Children.Add(uc);
                            stat.Children.Add(uc1);
                        }
                    }
                }
                else if (((String)box.SelectedItem) == "Rating")
                {
                    searchPagePanel.Children.Clear();
                    stat.Children.Clear();
                    if ((size == 3) && (sortList[0] == mc && sortList[1] == mash && sortList[2] == bb))
                    {

                        sortListR.Clear();
                        sortList.Clear();
                        sortListR.Add(new BeanStat());
                        sortListR.Add(new MacStats());
                        sortListR.Add(new MashStat());
                        sortList.Clear();
                        sortList.Add(bb);
                        sortList.Add(mc);
                        sortList.Add(mash);
                        for (int i = 0; i < size; i++)
                        {
                            UserControl uc = (UserControl)sortList[i];
                            UserControl uc1 = (UserControl)sortListR[i];
                            searchPagePanel.Children.Add(uc);
                            stat.Children.Add(uc1);
                        }
                    }
                }
            }


    */
