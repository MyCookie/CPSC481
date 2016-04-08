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

namespace HorizontalPrototype
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : UserControl
    {

        public SearchResultPage srPage = new SearchResultPage();
        public SearchPageFilterTags sftPage = new SearchPageFilterTags();


        public SearchPage()
        {
            InitializeComponent();
            try
            {

                SearchMainStackPanel.Children.Add(srPage);
            }
            catch (Exception searchPageError)
            {
                searchPageError.StackTrace.ToString(); // TODO: Printout later
            }
        }

        private void SearchResultsButton_Click(object sender, RoutedEventArgs e)
        {
            SearchResultsButton.Opacity = 0.3;
            SearchResultsButton.IsEnabled = false;
            SearchFiltersButton.Opacity = 1;
            SearchFiltersButton.IsEnabled = true;
            try
            {
                SearchMainStackPanel.Children.Clear();
                SearchMainStackPanel.Children.Add(srPage);
            }
            catch (Exception searchPageError)
            {
                searchPageError.StackTrace.ToString(); //TODO: Printout later
            }
        }


        private void SearchFiltersButton_Click(object sender, RoutedEventArgs e)
        {
            SearchResultsButton.Opacity = 1;
            SearchResultsButton.IsEnabled = true;
            SearchFiltersButton.Opacity = 0.3;
            SearchFiltersButton.IsEnabled = false;
            try
            {
                SearchMainStackPanel.Children.Clear();
                SearchMainStackPanel.Children.Add(sftPage);
            }
            catch (Exception searchPageError)
            {
                searchPageError.StackTrace.ToString(); //TODO: Printout later
            }

        }
        private void SearchSortByButton_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SearchSortByButton.SelectedItem.ToString().Contains("Ingredient"))
            {
                try
                {
                    srPage.ChangeAllStrings("This is now listed in order of number of ingredients");
                    SearchResultsButton.Opacity = 0.3;
                    SearchResultsButton.IsEnabled = false;
                    SearchFiltersButton.Opacity = 1;
                    SearchFiltersButton.IsEnabled = true;
                    SearchMainStackPanel.Children.Clear();
                    SearchMainStackPanel.Children.Add(srPage);
                }
                catch (Exception err)
                { }
            }
            else if (SearchSortByButton.SelectedItem.ToString().Contains("Time"))
            {
                try
                {
                    srPage.ChangeAllStrings("This is now listed in order of time it takes to make the dish.");
                    SearchResultsButton.Opacity = 0.3;
                    SearchResultsButton.IsEnabled = false;
                    SearchFiltersButton.Opacity = 1;
                    SearchFiltersButton.IsEnabled = true;
                    SearchMainStackPanel.Children.Clear();
                    SearchMainStackPanel.Children.Add(srPage);
                }
                catch (Exception err)
                { }
            }
            else if (SearchSortByButton.SelectedItem.ToString().Contains("Difficulty"))
            {
                try
                {
                    srPage.ChangeAllStrings("This is now listed in order of dish difficulty");
                    SearchResultsButton.Opacity = 0.3;
                    SearchResultsButton.IsEnabled = false;
                    SearchFiltersButton.Opacity = 1;
                    SearchFiltersButton.IsEnabled = true;
                    SearchMainStackPanel.Children.Clear();
                    SearchMainStackPanel.Children.Add(srPage);
                }
                catch (Exception err)
                { }
            }
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AfterLogin());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                srPage.ChangeAllStrings("Your search results...");
                SearchResultsButton.Opacity = 0.3;
                SearchResultsButton.IsEnabled = false;
                SearchFiltersButton.Opacity = 1;
                SearchFiltersButton.IsEnabled = true;
                SearchMainStackPanel.Children.Clear();
                SearchMainStackPanel.Children.Add(srPage);
            }
            catch (Exception err)
            { }
        }

   
    }
}
