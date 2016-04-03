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

        public SearchPage()
        {
            string[] str = new string[] {"Time", "Difficulty", "Rating"};
            InitializeComponent();
            mc.like.Opacity = 100;
            bb.like.Opacity = 100;
            ce.like.Opacity = 100;
            sweet.like.Opacity = 100;
            pl.like.Opacity = 100;
            mash.like.Opacity = 100;
            hummus.like.Opacity = 100;
            butter.like.Opacity = 100;

            mc.dislike.Opacity = 0;
            bb.dislike.Opacity = 0;
            ce.dislike.Opacity = 0;
            pl.dislike.Opacity = 0;
            mash.dislike.Opacity = 0;
            sweet.dislike.Opacity = 0;
            hummus.dislike.Opacity = 0;
            butter.dislike.Opacity = 0;
            resultl.Opacity = 0;
            box.ItemsSource = str;
            box.Text = "Sort by";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            results.Clear();
            statsR.Clear();
            searchPagePanel.Children.Clear();
            stat.Children.Clear();
            size = 0;
            no_results = 0;
            for (int i = 0; i < MacCheese.Macattributes.Length; i++){
                 if(searchBox.Text.ToString().Contains(MacCheese.Macattributes[i])){
                     results.Add(mc);
                     statsR.Add(new MacStats());
                     size++;
                     no_results = 1;
                     break;
                 }
            } for (int i = 0; i < BlackBean.Beanattributes.Length; i++)
            {
                if (searchBox.Text.ToString().Contains(BlackBean.Beanattributes[i]))
                {
                    results.Add(bb);
                    statsR.Add(new BeanStat());
                    size++;
                    no_results = 1;
                    break;
                }
            } for (int i = 0; i < Enchiladas.Enchiladasattributes.Length; i++)
            {
                if (searchBox.Text.ToString().Contains(Enchiladas.Enchiladasattributes[i]))
                {
                    results.Add(ce);
                    statsR.Add(new EnchiladasStat());

                    size++;
                    no_results = 1;
                    break;
                }
            } for (int i = 0; i < SweetPotato.Sweetattributes.Length; i++)
            {
                if (searchBox.Text.ToString().Contains(SweetPotato.Sweetattributes[i]))
                {
                    results.Add(sweet);
                    statsR.Add(new SweetStat());

                    size++;
                    no_results = 1;
                    break;
                }
            } for (int i = 0; i < PorkLoin.Porkattributes.Length; i++)
            {
                if (searchBox.Text.ToString().Contains(PorkLoin.Porkattributes[i]))
                {
                    results.Add(pl);
                    statsR.Add(new PorkStat());

                    size++;
                    no_results = 1;
                    break;
                }
            } for (int i = 0; i < Mashed.Mashattributes.Length; i++)
            {
                if (searchBox.Text.ToString().Contains(Mashed.Mashattributes[i]))
                {
                    results.Add(mash);
                    statsR.Add(new MashStat());

                    size++;
                    no_results = 1;
                    break;
                }
            } for (int i = 0; i < Hummus.Hummusattributes.Length; i++)
            {
                if (searchBox.Text.ToString().Contains(Hummus.Hummusattributes[i]))
                {
                    results.Add(hummus);
                    statsR.Add(new HummusStat());

                    size++;
                    no_results = 1;
                    break;
                }
            } for (int i = 0; i < ButterChicken.Butterattributes.Length; i++)
            {
                if (searchBox.Text.ToString().Contains(ButterChicken.Butterattributes[i]))
                {
                    results.Add(butter);
                    statsR.Add(new ButterStat());

                    size++;
                    no_results = 1;
                    break;
                }
            }
            for (int i = 0; i < size; i++)
            {
                UserControl uc = (UserControl) results[i];
                UserControl uc1 = (UserControl) statsR[i];
                searchPagePanel.Children.Add(uc);
                stat.Children.Add(uc1);
            } 
            if (no_results == 1)
            {
                resultl.Content = "Your search results";
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

            if (box.SelectedIndex > -1)
            {
                if (((String) box.SelectedItem) == "Time")
                {
                    searchPagePanel.Children.Clear();
                    stat.Children.Clear();
                    if ((size == 3) &&(results[0] == mc && results[1] == bb && results[2] == mash))
                    {
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
        }
    }
}
