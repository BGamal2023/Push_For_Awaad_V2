using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_The_Player
{
    internal class Creating_Player_Container
    {
        private C_Creating_One_Segement_Items_GC obj_Creating=new C_Creating_One_Segement_Items_GC();
        //---------------------------------------------------------------------------------------------------
        public void creat_Player_Container()
        {
            obj_Creating.creat_One_Segement_Item(
                Globals.player_Container_Width,
                Globals.player_Container_Height,
                Globals.player_Container_X_Pos,
                Globals.player_Container_Y_Pos,
                Globals.player_Continer_Color,
                Globals.li_Player_Container
                );
        }
    }
}
