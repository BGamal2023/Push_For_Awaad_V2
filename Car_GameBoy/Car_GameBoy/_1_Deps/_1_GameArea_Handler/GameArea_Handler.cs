using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Car_GameBoy._1_Deps._1_GameArea_Handler
{
    internal class GameArea_Handler
    {
        private Canvas gameArea = new Canvas();
        //-------------------------------------------------------------------------------
        public Canvas handle_And_Give_Me_The_GameArea(MainWindow mWindow)
        {
            set_GameArea_Dimensions();
            set_GameArea_Background_Color();
            add_The_GameArea_To_The_Mainwindow(mWindow);
            return gameArea;
        }
        //-------------------------------------------------------------------------------
        private void set_GameArea_Dimensions()
        {
            gameArea.Width = Globals.gameArea_Width;
            gameArea.Height = Globals.gameArea_Height;
        }
        //----------------------------------------------------------------------------
        private void set_GameArea_Background_Color()
        {
            gameArea.Background = Globals.gameArea_Bkground_Color;

            // image background

            /*    string imagePath = "E:\\Programming\\12_C#\\Csharp_Projects\\Resources\\Background.png";
                ImageSource imageSource = new BitmapImage(new Uri(imagePath, UriKind.Absolute));

                // Set the window background
                mWindow.Background = new ImageBrush(imageSource);*/
        }
     
        //----------------------------------------------------------------------------
        private void add_The_GameArea_To_The_Mainwindow(MainWindow mWindow)
        {
            mWindow.Content = gameArea;

        }

    }
    }
