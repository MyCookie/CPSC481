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
    /// Interaction logic for Favourite.xaml
    /// </summary>
    public partial class Favourite : UserControl
    {
        public static StackPanel favouriteStack;
        public static StackPanel favouriteStack1;
        public static MacCheese mc1 = new MacCheese();
        public static Mashed mash1 = new Mashed();
        public static ButterChicken butterchicken1 = new ButterChicken();
        public static BlackBean blackbean1 = new BlackBean();
        public static Enchiladas ce1 = new Enchiladas();
        public static Hummus hummus1 = new Hummus();
        public static PorkLoin pl1 = new PorkLoin();
        public static SweetPotato sweet1 = new SweetPotato();

        public static int check = 0;
        public Favourite()
        {
            InitializeComponent();
            favouriteStack = favouritesp;
            favouriteStack1 = favouritesp1;
            mc1.checkStatus = true;
            mc1.like.Opacity = 0;
            mash1.checkStatus = true;
            mash1.like.Opacity = 0;
            butterchicken1.like.Opacity = 0;
            butterchicken1.checkStatus = true;
            blackbean1.like.Opacity = 0;
            blackbean1.checkStatus = true;
            ce1.like.Opacity = 0;
            ce1.checkStatus = true;
            hummus1.like.Opacity = 0;
            hummus1.checkStatus = true;
            pl1.like.Opacity = 0;
            pl1.checkStatus = true;
            sweet1.like.Opacity = 0;
            sweet1.checkStatus = true;
        }
    }
}
