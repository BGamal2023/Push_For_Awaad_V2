using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_Blocks_In_Side_Way
{
    internal class Creating_Blocks_For_The_Left_Sideway_Of_The_Racing_Area
    {
        C_Creating_Multible_Segement_Items_GC obj_Creat_item=new C_Creating_Multible_Segement_Items_GC();
        //-------------------------------------------------------------------------------
        
        public void create_Left_Sideway_Blocks()
        {
            obj_Creat_item.creat_Multible_Item(
                Globals.no_Of_Left_SideWay_Blocks,
                Globals.left_Sideway_Blocks_Segment_No,
                Globals.left_Sideway_Blocks_Width,
                Globals.left_Sideway_Blocks_Height,
                Globals.racing_Area_Bkground_Line_Segment_Height,
                Globals.left_Sideway_Blocks_BKground_Color,
                Globals.left_Sideway_Blocks_X_Pos,
                Globals.left_Sideway_Blocks_Y_Pos,
                Globals.li_Of_The_Left_Sideway_Blocks_New,
                Globals.left_Sideway_Blocks_Dis_Bet_Blocks
                );
        }
    }
}
