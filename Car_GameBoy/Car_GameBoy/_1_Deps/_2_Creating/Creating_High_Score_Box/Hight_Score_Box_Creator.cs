using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_High_Score_Box
{
    internal class Hight_Score_Box_Creator
    {

        public static TextBlock Hi_Score_TBlock = new TextBlock();
        public static TextBox Hi_Score_T_Box = new TextBox();

        //---------------------------------------------------------------------------------------------
        public void create_Hi_Score_Box()
        {


            Hi_Score_TBlock.Text = Globals.hi_Score_TBlock_Text;
            Hi_Score_TBlock.Width = Globals.hi_Score_TBlock_W;
            Hi_Score_TBlock.Height = Globals.hi_Score_TBlock_H;
            Hi_Score_TBlock.Background = Globals.hi_Score_TBlock_Bkground_Color;
            Hi_Score_TBlock.TextAlignment = TextAlignment.Center;
            Hi_Score_TBlock.FontSize = 20;
            Hi_Score_TBlock.FontWeight = FontWeights.Bold;



            Hi_Score_T_Box.Width = Globals.hi_Score_TBox_W;
            Hi_Score_T_Box.Height = Globals.hi_Score_TBox_H;
            Hi_Score_T_Box.Background = Globals.hi_Score_TBox_Bkground_Color;
            Hi_Score_T_Box.Text = Globals.player_Hi_Score.ToString();
            Hi_Score_T_Box.TextAlignment = TextAlignment.Center;
            Hi_Score_T_Box.FontSize = 15;
            Hi_Score_T_Box.FontWeight = FontWeights.Bold;
            Hi_Score_T_Box.BorderBrush = Globals.hi_Score_TBox_Bkground_Color;



          

        }

    }
}
