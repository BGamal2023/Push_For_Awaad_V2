using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._4_Moving.Moving_The_Lines_In_Racing_Area
{
    internal class Moving_The_Racing_Area_Lines
    {
        private C_Moving obj_Moving = new C_Moving();
        //--------------------------------------------------------------------------------
        public void move_The_Racing_Area_Lines(Canvas gameArea)
        {
            obj_Moving.move_Item_Vertical_Down_At_Fixed_Left_Pos(
                Globals.li_Lines_In_Racing_Area_New,
                gameArea,
                Globals.moving_Increment,
                Globals.gameArea_Height);

        }
    }
}
