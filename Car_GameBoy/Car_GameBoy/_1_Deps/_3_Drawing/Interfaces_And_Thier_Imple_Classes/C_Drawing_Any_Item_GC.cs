using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes
{
    internal class C_Drawing_Any_Item_GC : I_Drawing
    {
        public void draw_Item(List<C_Item> list, Canvas gameArea)
        {
            if (list != null )
            {

                for (int i = 0; i < list.Count; i++)
                {
                    gameArea.Children.Add(list[i].rect);
                    Canvas.SetLeft(list[i].rect, list[i].left_Pos);
                    Canvas.SetTop(list[i].rect, list[i].top_Pos);
                   
                }

            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public void draw_Item(List<C_Item> list, Canvas gameArea,int ZIndex)
        {
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    gameArea.Children.Add(list[i].rect);
                    Canvas.SetLeft(list[i].rect, list[i].left_Pos);
                    Canvas.SetTop(list[i].rect, list[i].top_Pos);
                    Canvas.SetZIndex(list[i].rect, ZIndex);
                }

            }
        }
    }
}
