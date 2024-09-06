using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Drawing_Enemies
{
    internal class Drawing_The_Enemies
    {
        private C_Drawing_Any_Item_GC obj_Drawing=new C_Drawing_Any_Item_GC();
        //------------------------------------------------------------------------------------------------
        public void draw_The_Enemies(Canvas gameArea)
        {
            for(int i=0;i<Globals.li_Enemy_Cars.Count;i++)
            {
                obj_Drawing.draw_Item(Globals.li_Enemy_Cars[i], gameArea);

            }
        }
    }
}
