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

namespace Vertical
{
    /// <summary>
    /// Interaction logic for MashInstructions.xaml
    /// </summary>
    public partial class MashInstructions : UserControl
    {
        public MashInstructions()
        {
            InitializeComponent();
            video.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MashStat.holder == true)
                Switcher.Switch(new MashIng());
            else
                Switcher.Switch(MainWindow.home);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MashInstructions2());
        }
    }
}
