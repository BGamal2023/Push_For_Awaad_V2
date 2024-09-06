using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box
{
    internal class Score_Box_Creator
    {

        public static TextBlock obj_TextBlock = new TextBlock();
        public static TextBox obj_TextBox = new TextBox();

        //---------------------------------------------------------------------------------------------
        public void create_Score_Box()
        {
           

            obj_TextBlock.Text = Globals.progress_TextBlock_Text;
            obj_TextBlock.Width = Globals.progress_TextBlock_Width;
            obj_TextBlock.Height= Globals.progress_TextBlock_Height;
            obj_TextBlock.Background = Globals.progress_TextBlock_Bkground_Color ;
            obj_TextBlock.TextAlignment = TextAlignment.Center;
            obj_TextBlock.FontSize = 20;
            obj_TextBlock.FontWeight= FontWeights.Bold;



            obj_TextBox.Width = Globals.progress_TextBox_Width;
            obj_TextBox.Height = Globals.progress_TextBox_Height;
            obj_TextBox.Background = Globals.progress_TextBox_Bkground_Color;
            obj_TextBox.Text = Globals.player_Score.ToString();
            obj_TextBox.TextAlignment= TextAlignment.Center;
            obj_TextBox.FontSize = 15;
            obj_TextBox.FontWeight= FontWeights.Bold;
            obj_TextBox.BorderBrush=Globals.progress_TextBox_Bkground_Color;



            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Centered and Bold Text";
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.FontSize = 20;
            textBlock.FontWeight = FontWeights.Bold;

        }

       

    }
}
