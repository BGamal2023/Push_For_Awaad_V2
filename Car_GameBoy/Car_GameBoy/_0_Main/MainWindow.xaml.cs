using Car_GameBoy._0_Main;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Car_GameBoy
{

    public partial class MainWindow : Window
    {


        private General_Manager_V1 obj_GM_V1 = new General_Manager_V1();


        public MainWindow()
        {
            InitializeComponent();
            obj_GM_V1.start_And_Handle_The_App(this);

            KeyDown += (sender, e) => obj_GM_V1.onclick_Keydown(sender, e);

            KeyUp += obj_GM_V1.onClick_Keyup;
        }
    }
}