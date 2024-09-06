using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_High_Score_Box;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Drawing_Hi_Score_Box
{
    internal class Hi_Score_Box_Drawer
    {

        private C_Drawing_Any_Item_GC obj_Drawing = new C_Drawing_Any_Item_GC();
        //-----------------------------------------------------------------------------------------------------------------
        public void draw_The_Hi_Score_Box(Canvas gameArea)
        {

            gameArea.Children.Add(Hight_Score_Box_Creator.Hi_Score_TBlock);
            gameArea.Children.Add(Hight_Score_Box_Creator.Hi_Score_T_Box);

            Canvas.SetLeft(Hight_Score_Box_Creator.Hi_Score_TBlock, Globals.hi_Score_TBlock_Left_Pos);
            Canvas.SetTop(Hight_Score_Box_Creator.Hi_Score_TBlock, Globals.hi_Score_TBlock_Top_Pos);

            Canvas.SetLeft(Hight_Score_Box_Creator.Hi_Score_T_Box, Globals.hi_Score_TBox_Left_Pos);
            Canvas.SetTop(Hight_Score_Box_Creator.Hi_Score_T_Box, Globals.hi_Score_TBox_Top_Pos);

        }

    }
}
