using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_Racing_Area
{
    internal class Creating_The_Racing_Area
    {
        private C_Creating_One_Segement_Items_GC obj_Creating=new C_Creating_One_Segement_Items_GC();
        //--------------------------------------------------------------------------------
        public void creat_The_Racing_Area()
        {
            obj_Creating.creat_One_Segement_Item(
                Globals.racing_Area_Width,
                Globals.racing_Area_Height,
                Globals.racing_Area_X_Pos,
                Globals.racing_Area_Y_Pos,
                Globals.racing_Area_bGround_Color,
                Globals.li_The_Racing_Area);
        }
    }
}
