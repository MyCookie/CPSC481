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
    /// Interaction logic for LogInScreen.xaml
    /// </summary>
    public partial class LogInScreen : UserControl
    {
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void Username_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Username.Clear();
        }

        private void Password_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Password.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AfterLogin());
        }
    }
}
