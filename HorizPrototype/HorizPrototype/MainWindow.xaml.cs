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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static LoginScreen lgs;
        public static MainScreen msn;

        public MainWindow()
        {
            InitializeComponent();
            lgs = new LoginScreen();
            msn = new MainScreen();
            LasangaQuickInfo l = new LasangaQuickInfo();

            MainStackPanel.Children.Add(msn);
        }
    }
}
