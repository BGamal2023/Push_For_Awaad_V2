using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_Fuel_Indicator
{
    internal class Fuel_Indicator_Creator
    {
        public static TextBlock fuel_Indic_TBlock = new TextBlock();
        public static TextBox fuel_Indic_TBox = new TextBox();

        //---------------------------------------------------------------------------------------------
        public void create_Fuel_Indicator_Box()
        {


            fuel_Indic_TBlock.Text = Globals.fuel_Indic_TBlock_Text;
            fuel_Indic_TBlock.Width = Globals.fuel_Indic_TBlock_W;
            fuel_Indic_TBlock.Height = Globals.fuel_Indic_TBlock_H;
            fuel_Indic_TBlock.Background = Globals.fuel_Indic_TBlock_Bkground_Color;
            fuel_Indic_TBlock.TextAlignment = TextAlignment.Center;
            fuel_Indic_TBlock.FontSize = 20;
            fuel_Indic_TBlock.FontWeight = FontWeights.Bold;



            fuel_Indic_TBox.Width = Globals.fuel_Indic_TBox_W;
            fuel_Indic_TBox.Height = Globals.fuel_Indic_TBox_H;
            fuel_Indic_TBox.Background = Globals.fuel_Indic_TBox_Bkground_Color;
            fuel_Indic_TBox.Text = Globals.player_Fuel.ToString();   
            fuel_Indic_TBox.TextAlignment = TextAlignment.Center;
            fuel_Indic_TBox.FontSize = 15;
            fuel_Indic_TBox.FontWeight = FontWeights.Bold;
            fuel_Indic_TBox.BorderBrush = Globals.fuel_Indic_TBox_Bkground_Color; 




        }



    }
}
