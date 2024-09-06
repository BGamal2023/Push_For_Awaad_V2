using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes
{
    internal class C_Creating_Multible_Segement_Items_GC : I_Creating_Multible_Segement_itemes
    {

        //--------------------------------------------------------------------------------------------
        public void creat_Item(
            int no_Of_Segment_By_Every_Rect,
            int rectangle_Object_Width,
            int Segment_Height,
            Brush Segment_BKground_Color,
            int object_X_Pos,
            int object_Y_Pos,
            List<C_Item> li_Of_Object_Segments)
        {
            for (int j = 0; j < no_Of_Segment_By_Every_Rect; j++)
            {
                Rectangle i_rect = new Rectangle()
                {
                    Width = rectangle_Object_Width,
                    Height = Segment_Height,
                    Fill = Segment_BKground_Color
                };

                C_Item i_Rectangle_Segment = new C_Item();

                i_Rectangle_Segment.rect = i_rect;
                i_Rectangle_Segment.left_Pos = object_X_Pos;
                i_Rectangle_Segment.top_Pos = object_Y_Pos;
                li_Of_Object_Segments.Add(i_Rectangle_Segment);

                object_Y_Pos += Segment_Height;



            }
        }
        //--------------------------------------------------------------------------------------------
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
            int dist_Bet_Items)
        {
            for (int i = 0; i < no_Of_Req_Rects; i++)
            {
                creat_Item(no_Of_Segment_By_Every_Rect, rectangle_Object_Width, Segment_Height, Segment_BKground_Color, object_X_Pos, object_Y_Pos, li_Of_Object_Segments);
                object_Y_Pos += rectangle_Object_Height + dist_Bet_Items;


            }
        }
        //--------------------------------------------------------------------------------------------

    }
}
