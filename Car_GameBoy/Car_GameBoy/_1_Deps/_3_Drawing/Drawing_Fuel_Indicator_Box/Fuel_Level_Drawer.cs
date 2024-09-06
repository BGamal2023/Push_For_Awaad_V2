using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Fuel_Indicator;
using Car_GameBoy._1_Deps._2_Creating.Creating_High_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Drawing_Fuel_Indicator_Box
{
    internal class Fuel_Level_Drawer
    {
        //-----------------------------------------------------------------------------------------------------------------
        public void draw_Fuel_Level_Box(Canvas gameArea)
        {

            gameArea.Children.Add(Fuel_Indicator_Creator.fuel_Indic_TBlock);
            gameArea.Children.Add(Fuel_Indicator_Creator.fuel_Indic_TBox);

            Canvas.SetLeft(Fuel_Indicator_Creator.fuel_Indic_TBlock,Globals.fuel_Indic_TBlock_Left_Pos );
            Canvas.SetTop(Fuel_Indicator_Creator.fuel_Indic_TBlock,Globals.fuel_Indic_TBlock_Top_Pos);

            Canvas.SetLeft(Fuel_Indicator_Creator.fuel_Indic_TBox,Globals.fuel_Indic_TBox_Left_Pos );
            Canvas.SetTop(Fuel_Indicator_Creator.fuel_Indic_TBox, Globals.fuel_Indic_TBox_Top_Pos);

        }
    }
}
