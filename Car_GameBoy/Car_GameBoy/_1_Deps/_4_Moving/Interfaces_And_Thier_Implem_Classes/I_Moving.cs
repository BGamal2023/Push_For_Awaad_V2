using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes
{
    internal interface I_Moving
    {
        
        public void move_Item_Vertical_Down_At_Fixed_Left_Pos(List<C_Item> list, Canvas gameArea, int increment_Value, int limit_Value);
        public void move_Item_Vertical_Down_With_Changing_Left_Pos(List<C_Item> list, Canvas gameArea, int increment_Value, int limit_Value);
        public void move_Item_Horizontal_Right(List<C_Item> list, Canvas gameArea, int increment_Value, int limit_Value);
        public void move_Item_Horizontal_Left(List<C_Item> list, Canvas gameArea, int increment_Value, int limit_Value);
        public void clear_Item_From_The_GameArea(List<C_Item> list, Canvas gameArea);
        public void change_Position_Value_Vertically(List<C_Item> list, int increment_Value, int limit_Value);
        public void redraw_The_Item(List<C_Item> list, Canvas gameArea);

    }
}
