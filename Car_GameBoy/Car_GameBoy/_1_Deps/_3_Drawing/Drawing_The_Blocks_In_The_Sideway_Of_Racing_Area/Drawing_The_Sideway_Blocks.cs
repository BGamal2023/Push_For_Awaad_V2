using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Drawing_The_Blocks_In_The_Sideway_Of_Racing_Area
{
    internal class Drawing_The_Sideway_Blocks
    {
        C_Drawing_Any_Item_GC obj_Drawing = new C_Drawing_Any_Item_GC();
        //----------------------------------------------------------------------------------------------------
        public void draw_Left_Sideway_Blocks(Canvas gameArea)
        {
            obj_Drawing.draw_Item(Globals.li_Of_The_Left_Sideway_Blocks_New, gameArea);
        }
        //----------------------------------------------------------------------------------------------------
        public void draw_Right_Sideway_Blocks(Canvas gameArea)
        
        {
            obj_Drawing.draw_Item(Globals.li_Of_The_Right_Sideway_Blocks_New,gameArea);
        }
    }
}
