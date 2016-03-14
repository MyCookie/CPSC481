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

namespace HorizPrototype
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : UserControl
    {
        public static RecipieButton lasagnaB;
        public static RecipieButton spaghettiB;

        public MainScreen()
        {
            InitializeComponent();
            lasagnaB = new RecipieButton();
            lasagnaB.RecipeName.Content = "Lasagna";
            lasagnaB.RecipeTime.Content = "25";
            spaghettiB = new RecipieButton();
            spaghettiB.RecipeName.Content = "Spaghetti";
            spaghettiB.RecipeTime.Content = "15";
            RecipeListPanel.Children.Add(lasagnaB);
            RecipeListPanel.Children.Add(spaghettiB);
            UserControl quickInfo = new LasangaQuickInfo();
            QuickInfoPanel.Children.Add(quickInfo);
            try
            {
                RecipeListPanel.Children.Add(lasagnaB);
                RecipeListPanel.Children.Add(spaghettiB);
            } catch (Exception e)
            {
                System.Console.WriteLine("erooor");
            }
        }
    }
}
