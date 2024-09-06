using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_Lines_In_Racing_Area
{
    internal class Creating_Racing_Area_Bkg_Lines
    {
        private C_Creating_Multible_Segement_Items_GC obj_Creating=new C_Creating_Multible_Segement_Items_GC();
        //----------------------------------------------------------------------------------------
        public void create_Lines_Of_Racing_Area()
        {
            obj_Creating.creat_Multible_Item(
                Globals.no_Of_Lines_In_racing_Area,
                Globals.no_Of_Segement_In_Every_Racing_Area_Lines,
                Globals.racing_Area_Background_Line_Width,
                Globals.racing_Area_Background_Line_Height,
                Globals.racing_Area_Bkground_Line_Segment_Height,
                Globals.racing_Area_Background_Line_Color,
                Globals.racing_Area_Background_Line_X_Pos,
                Globals.racing_Area_Background_Line_Y_Pos,
                Globals.li_Lines_In_Racing_Area_New,
                Globals.racing_Area_Dist_Bet_Lines

                );
        }
    }
}
