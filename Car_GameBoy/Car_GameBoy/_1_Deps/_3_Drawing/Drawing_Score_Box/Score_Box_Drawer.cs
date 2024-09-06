using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Drawing_Score_Box
{
    internal class Score_Box_Drawer
    {
        private C_Drawing_Any_Item_GC obj_Drawing=new C_Drawing_Any_Item_GC();
        //-----------------------------------------------------------------------------------------------------------------
        public void draw_The_Score_Box(Canvas gameArea)
        {
        
            gameArea.Children.Add(Score_Box_Creator.obj_TextBox);
            gameArea.Children.Add(Score_Box_Creator.obj_TextBlock);

            Canvas.SetLeft(Score_Box_Creator.obj_TextBox, Globals.progress_TextBox_Left_Pos);
            Canvas.SetTop(Score_Box_Creator.obj_TextBox, Globals.progress_TextBox_Top_Pos);

            Canvas.SetLeft(Score_Box_Creator.obj_TextBlock, Globals.progress_TextBlock_Left_Pos);
            Canvas.SetTop(Score_Box_Creator.obj_TextBlock, Globals.progress_TextBlock_Top_Pos);
            
        }
    }
}
