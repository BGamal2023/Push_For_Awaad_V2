using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;
using Car_GameBoy.__Globals;
using System.ComponentModel;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._0_MainWindow_Handler
{
    internal class MainWindow_Handler
    {
        //----------------------------------------------------------------------------
        public void customize_mainWindow(MainWindow mWindow)
        {
            //--
            show_The_Main_Window_In_The_Middle_Of_Screen(mWindow);
            //--
            set_The_Main_Window_Dimensions(mWindow);
            //--
         
        }
        //----------------------------------------------------------------------------
        private void set_mainWindow_Background_Color(MainWindow mWindow)
        {
            mWindow.Background=Brushes.Black;
        /*    string imagePath = "E:\\Programming\\12_C#\\Csharp_Projects\\Resources\\Background.png";
            ImageSource imageSource = new BitmapImage(new Uri(imagePath, UriKind.Absolute));

            // Set the window background
            mWindow.Background = new ImageBrush(imageSource);*/
        }
        //----------------------------------------------------------------------------
        private void show_The_Main_Window_In_The_Middle_Of_Screen(MainWindow mWindow)
        {
            mWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
           
        }
        //----------------------------------------------------------------------------
        private void set_The_Main_Window_Dimensions(MainWindow mWindow)
        {
            mWindow.Width = Globals.mWindow_Width;
            mWindow.Height = Globals.mWindow_Height;
        }
    
    }
}
