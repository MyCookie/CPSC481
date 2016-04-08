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
    /// Interaction logic for SearchResult_Page.xaml
    /// </summary>
    public partial class SearchResultPage : UserControl
    {
        SearchResultResult srResult0 = new SearchResultResult();
        SearchResultResult srResult1 = new SearchResultResult();
        SearchResultResult srResult2 = new SearchResultResult();
        SearchResultResult srResult3 = new SearchResultResult();
        SearchResultResult srResult4 = new SearchResultResult();
        SearchResultResult srResult5 = new SearchResultResult();
        SearchResultResult srResult6 = new SearchResultResult();
        SearchResultResult srResult7 = new SearchResultResult();
        SearchResultResult srResult8 = new SearchResultResult();
        SearchResultResult srResult9 = new SearchResultResult();

        public SearchResultPage()
        {
            InitializeComponent();
            SearchResultResult srResult0 = new SearchResultResult("This is the default result page, which should be empty right now");
            SearchResultPanel0.Children.Add(srResult0);
            SearchResultResult srResult1 = new SearchResultResult("So this is an example:");
            SearchResultPanel1.Children.Add(srResult1);
            SearchResultResult srResult2 = new SearchResultResult("");
            SearchResultPanel2.Children.Add(srResult2);
            SearchResultResult srResult3 = new SearchResultResult("This is the default result page, which should be empty right now");
            SearchResultPanel3.Children.Add(srResult3);
            SearchResultResult srResult4 = new SearchResultResult("This is the default result page, which should be empty right now");
            SearchResultPanel4.Children.Add(srResult4);
            SearchResultResult srResult5 = new SearchResultResult("This is the default result page, which should be empty right now");
            SearchResultPanel5.Children.Add(srResult5);
            SearchResultResult srResult6 = new SearchResultResult("This is the default result page, which should be empty right now");
            SearchResultPanel6.Children.Add(srResult6);
            SearchResultResult srResult7 = new SearchResultResult("This is the default result page, which should be empty right now");
            SearchResultPanel7.Children.Add(srResult7);
            SearchResultResult srResult8 = new SearchResultResult("This is the default result page, which should be empty right now");
            SearchResultPanel8.Children.Add(srResult8);
            SearchResultResult srResult9 = new SearchResultResult("This is the default result page, which should be empty right now");
            SearchResultPanel9.Children.Add(srResult9);
        }


        public void ChangeAllStrings(String resultString) //TODO: Fix this hack job
        {
            srResult0.Rewrite(resultString);
            SearchResultPanel0.Children.Clear();
            SearchResultPanel0.Children.Add(srResult0);
            srResult1.Rewrite(resultString);
            SearchResultPanel1.Children.Clear();
            SearchResultPanel1.Children.Add(srResult1);
            srResult2.Rewrite(resultString);
            SearchResultPanel2.Children.Clear();
            SearchResultPanel2.Children.Add(srResult2);
            srResult3.Rewrite(resultString);
            SearchResultPanel3.Children.Clear();
            SearchResultPanel3.Children.Add(srResult3);
            srResult4.Rewrite(resultString);
            SearchResultPanel4.Children.Clear();
            SearchResultPanel4.Children.Add(srResult4);
            srResult5.Rewrite(resultString);
            SearchResultPanel5.Children.Clear();
            SearchResultPanel5.Children.Add(srResult5);
            srResult6.Rewrite(resultString);
            SearchResultPanel6.Children.Clear();
            SearchResultPanel6.Children.Add(srResult6);
            srResult7.Rewrite(resultString);
            SearchResultPanel7.Children.Clear();
            SearchResultPanel7.Children.Add(srResult7);
            srResult8.Rewrite(resultString);
            SearchResultPanel8.Children.Clear();
            SearchResultPanel8.Children.Add(srResult8);
            srResult9.Rewrite(resultString);
            SearchResultPanel9.Children.Clear();
            SearchResultPanel9.Children.Add(srResult9);

        }
    }
}
