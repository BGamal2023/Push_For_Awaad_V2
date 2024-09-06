using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_SideWay_Of_The_Racing_Area
{
    internal class Creating_The_Two_Sideway_Of_The_Racing_Area
    {
        private C_Creating_One_Segement_Items_GC obj_Creating=new C_Creating_One_Segement_Items_GC();
        //---------------------------------------------------------------------------------------------------------
        public void create_The_Left_Sideway_Of_The_Racing_Area()
        {
            obj_Creating.creat_One_Segement_Item(
                Globals.left_Side_Of_The_Racing_Area_Width,
                Globals.left_Side_Of_The_Racing_Area_Height,
                Globals.left_Side_Of_The_Racing_Area_X_Pos,
                Globals.left_Side_Of_The_Racing_Area_Y_Pos,
                Globals.left_Side_Of_The_Racing_Area_BKground_Color,
                Globals.li_The_Left_Side_Of_The_Racing_Area);

        }
        //----------------------------------------------------------------------------------------------------------
        public void create_The_Right_Sideway_Of_The_Racing_Area()
        {
            obj_Creating.creat_One_Segement_Item(
              Globals.right_Side_Of_The_Racing_Area_Width,
              Globals.right_Side_Of_The_Racing_Area_Height,
              Globals.right_Side_Of_The_Racing_Area_X_Pos,
              Globals.right_Side_Of_The_Racing_Area_Y_Pos,
              Globals.right_Side_Of_The_Racing_Area_BKground_Color,
              Globals.li_The_Right_Side_Of_The_Racing_Area);
        }
    }
}
