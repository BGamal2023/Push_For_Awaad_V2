using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Drawing_The_Bkground_Lines_In_The_Racing_Area
{
    internal class Drawing_Bkground_Lines_In_The_Racing_Area
    {
        private C_Drawing_Any_Item_GC obj_Drawing = new C_Drawing_Any_Item_GC();
        //--------------------------------------------------------------------------------------
        public void draw_The_Bkground_Lines_In_The_Racing_Area(Canvas gameArea)
        {
            obj_Drawing.draw_Item(Globals.li_Lines_In_Racing_Area_New, gameArea);
        }
    }
}
