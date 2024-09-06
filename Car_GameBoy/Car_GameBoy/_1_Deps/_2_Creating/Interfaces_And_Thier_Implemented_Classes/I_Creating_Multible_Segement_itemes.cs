using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes
{
    internal interface I_Creating_Multible_Segement_itemes
    {
        public void creat_Item(
            int no_Of_Segment_By_Every_Rect,
            int rectangle_Object_Width,
            int Segment_Height,
            Brush Segment_BKground_Color,
            int object_X_Pos,
            int object_Y_Pos,
            List<C_Item> li_Of_Object_Segments);
        //-------------------------------------------------------------------------------------------------------------
        public void creat_Multible_Item(
           int no_Of_Req_Rects,
           int no_Of_Segment_By_Every_Rect,
           int rectangle_Object_Width,
           int rectangle_Object_Height,
           int Segment_Height,
           Brush Segment_BKground_Color,
           int object_X_Pos,
           int object_Y_Pos,
           List<C_Item> li_Of_Object_Segments,
           int dist_Bet_Items);

    }
}
