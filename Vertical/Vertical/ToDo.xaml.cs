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
    /// Interaction logic for ToDo.xaml
    /// </summary>
    public partial class ToDo : UserControl
    {
        public static StackPanel todoLeftStack;
        public static StackPanel todoRightStack;
        public static MacCheese mc1 = new MacCheese();
        public static Mashed mash1 = new Mashed();
        public static ButterChicken butterchicken1 = new ButterChicken();
        public static BlackBean blackbean1 = new BlackBean();
        public static Enchiladas ce1 = new Enchiladas();
        public static Hummus hummus1 = new Hummus();
        public static PorkLoin pl1 = new PorkLoin();
        public static SweetPotato sweet1 = new SweetPotato();

        public static int check = 0;
        public ToDo()
        {
            InitializeComponent();
            todoLeftStack = todoLeftStackX;
            todoRightStack = todoRightStackX;

            //Initalizing instance arrays
            MacCheese.instanceArray[1] = mc1;
            BlackBean.instanceArray[1] = blackbean1;
            ButterChicken.instanceArray[1] = butterchicken1;
            Enchiladas.instanceArray[1] = ce1;
            Hummus.instanceArray[1] = hummus1;
            Mashed.instanceArray[1] = mash1;
            PorkLoin.instanceArray[1] = pl1;
            SweetPotato.instanceArray[1] = sweet1;
        }
    }
}
