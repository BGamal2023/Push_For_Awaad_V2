using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes
{
    internal interface I_Creating_Car
    {
        public List<C_Item> creat_Car(
            int car_Part_Width,
            int car_Part_Height,
            int x0_Pos, 
            int y0_Pos, 
            Brush car_Part_Color,
            int no_Of_Car_Parts
            );
    }
}
