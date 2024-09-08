using Car_GameBoy._0_Main;
using Car_GameBoy._1_Deps.Levels;
using System.Reflection;
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
        private level obj_Level = new level();
        private Label gameOver_Label = new Label();



        public MainWindow()
        {
            InitializeComponent();

            Canvas gameArea = obj_GM_V1.start_And_Handle_The_App(this, gameOver_Label);
            set_The_Lable_Proberities(gameArea);

            KeyDown += (sender, e) => obj_GM_V1.onclick_Keydown(sender, e,gameArea);

            KeyUp += (sender, e) => obj_Level.onClick_Keyup(sender, e, gameOver_Label, gameArea, this);
        }





        private void set_The_Lable_Proberities(Canvas gameArea)
        {

            gameOver_Label.Content = "Game Over!";
            gameOver_Label.FontSize = 30;
            gameOver_Label.FontFamily = new FontFamily("Segoe UI");
            gameOver_Label.FontStyle = FontStyles.Normal;
            gameOver_Label.Foreground = Brushes.Red;
            gameOver_Label.Width = 200;
            gameOver_Label.Height = 50;
            gameOver_Label.Margin = new Thickness(10);
            gameOver_Label.HorizontalAlignment = HorizontalAlignment.Center;
            gameOver_Label.VerticalAlignment = VerticalAlignment.Center;
            gameOver_Label.Background = Brushes.LightGray;
            gameOver_Label.BorderBrush = Brushes.Black;
            gameOver_Label.BorderThickness = new Thickness(1);
            gameOver_Label.Padding = new Thickness(5);
            gameOver_Label.HorizontalAlignment = HorizontalAlignment.Center;
            gameOver_Label.VerticalAlignment = VerticalAlignment.Center;

            Canvas.SetTop(gameOver_Label, gameArea.Height / 2 - gameOver_Label.Height / 2);
            Canvas.SetLeft(gameOver_Label, gameArea.Width / 2 - gameOver_Label.Width / 2);
            Canvas.SetZIndex(gameOver_Label, 300);
        }

    }
     
}