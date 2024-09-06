using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes
{
    internal interface I_Drawing
    {
        public void draw_Item(List<C_Item> list, Canvas gameArea);
    }
}
