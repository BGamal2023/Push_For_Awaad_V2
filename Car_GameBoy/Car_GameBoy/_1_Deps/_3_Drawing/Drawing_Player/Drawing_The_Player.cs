using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Drawing_Player
{
    internal class Drawing_The_Player
    {
        private C_Drawing_Any_Item_GC obj_Drawing=new C_Drawing_Any_Item_GC();
        //------------------------------------------------------------------------------------------------------------------
        public void draw_The_Player(Canvas gameArea)
        {
            obj_Drawing.draw_Item(Globals.li_player, gameArea,10);
        }
    }
}
