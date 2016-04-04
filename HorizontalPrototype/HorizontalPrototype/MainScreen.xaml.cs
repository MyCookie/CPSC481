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
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : UserControl
    {
        public static RecipieButton lasagnaB;
        public static RecipieButton spaghettiB;
        public static UserControl quickInfo;

        public MainScreen()
        {
            InitializeComponent();
            quickInfo = new LasangaQuickInfo();
            QuickInfoPanel.Children.Add(quickInfo);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            QuickInfoPanel.Children.Clear();
            quickInfo = new LasangaQuickInfo();
            QuickInfoPanel.Children.Add(quickInfo);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            QuickInfoPanel.Children.Clear();
            quickInfo = new SpaghettiQuickInfo();
            QuickInfoPanel.Children.Add(quickInfo);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AfterLogin());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Grocerylist());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AfterLogin());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new SearchPage());
        }

    }
}
