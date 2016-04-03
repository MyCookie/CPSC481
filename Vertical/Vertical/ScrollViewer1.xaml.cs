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
    /// Interaction logic for ScrollViewer1.xaml
    /// </summary>
    public partial class ScrollViewer1 : UserControl
    {
        public static PorkLoin pl = new PorkLoin();
        public static MacCheese mc = new MacCheese();
        public static BlackBean bb = new BlackBean();
        public static Enchiladas ce = new Enchiladas(); 
        public static SweetPotato sweet = new SweetPotato();
        public static Mashed mash = new Mashed();
        public static ButterChicken bc = new ButterChicken();
        public static Hummus hummus = new Hummus();
        public ScrollViewer1()
        {
            mc.dislike.Opacity = 0;
            mash.dislike.Opacity = 0;
            bc.dislike.Opacity = 0;
            bb.dislike.Opacity = 0;
            sweet.dislike.Opacity = 0;
            hummus.dislike.Opacity = 0;
            ce.dislike.Opacity = 0;
            pl.dislike.Opacity = 0;
            InitializeComponent();
            stack.Children.Add(pl);
            stack.Children.Add(mc);
            stack.Children.Add(sweet);
            stack.Children.Add(hummus);
            stack1.Children.Add(bb);
            stack1.Children.Add(ce);
            stack1.Children.Add(mash);
            stack1.Children.Add(bc);
        }
    }
}
