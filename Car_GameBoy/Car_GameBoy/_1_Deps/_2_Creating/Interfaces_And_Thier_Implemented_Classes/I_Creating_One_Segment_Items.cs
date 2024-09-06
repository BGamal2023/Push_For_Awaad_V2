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
    internal interface I_Creating_One_Segment_Items
    {
        public void creat_One_Segement_Item(
           int width,
           int height,
           int Left_Pos,
           int top_Pos,
           Brush fill_Color,
           List<C_Item> list);
      
    }
}
