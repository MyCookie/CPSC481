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
    /// Interaction logic for SearchResultResult.xaml
    /// </summary>
    public partial class SearchResultResult : UserControl
    {
        public SearchResultResult()
        {
            InitializeComponent();
        }

        public SearchResultResult(String inputString)
        {
            InitializeComponent();
            ResultTextBox.Text = inputString;
        }

        public void Rewrite(String textToBe)
        {
            ResultTextBox.Text = "";
            ResultTextBox.Text = textToBe;
        }

    }
}
