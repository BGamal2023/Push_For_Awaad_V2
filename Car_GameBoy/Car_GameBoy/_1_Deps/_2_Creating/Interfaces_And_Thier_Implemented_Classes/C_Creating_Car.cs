using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes
{
    internal class C_Creating_Car : I_Creating_Car
    {
        int[] x_Arr = new int[9];
        int[] y_Arr = new int[9];
        //---------------------------------------------------------------------------------------------------
        public List<C_Item> creat_Car
            (int car_Part_Width,
            int car_Part_Height, 
            int x0_Pos, int y0_Pos,
            Brush car_Part_Color,
            int no_Of_Car_Parts)
        {
            List<C_Item> li_Car_Parts = new List<C_Item>();

            get_X_And_Y_For_Car_Parts(x0_Pos, y0_Pos, car_Part_Width, car_Part_Height);

            for (int i = 0; i < no_Of_Car_Parts; i++)
            {

                Rectangle i_car_Part = new Rectangle()
                {
                    Width = car_Part_Width,
                    Height = car_Part_Height,
                    Fill = car_Part_Color

                };
                C_Item i_Item = new C_Item();
                i_Item.rect = i_car_Part;
                i_Item.left_Pos = x_Arr[i];
                i_Item.top_Pos = y_Arr[i];
                i_Item.color = car_Part_Color;
                li_Car_Parts.Add(i_Item);


            }

            return li_Car_Parts;
        }
        //---------------------------------------------------------------------------------------------------
        public List<C_Item> creat_Car
            (int car_Part_Width,
            int car_Part_Height,
            int x0_Pos, int y0_Pos,
            Brush[]car_Colors,
            int no_Of_Car_Parts)
        {
            List<C_Item> li_Car_Parts = new List<C_Item>();

            get_X_And_Y_For_Car_Parts(x0_Pos, y0_Pos, car_Part_Width, car_Part_Height);

            for (int i = 0; i < no_Of_Car_Parts; i++)
            {

                Rectangle i_car_Part = new Rectangle()
                {
                    Width = car_Part_Width,
                    Height = car_Part_Height,
                    Fill = car_Colors[i],

                };
                C_Item i_Item = new C_Item();
                i_Item.rect = i_car_Part;
                i_Item.left_Pos = x_Arr[i];
                i_Item.top_Pos = y_Arr[i];
                i_Item.color = car_Colors[i];
                li_Car_Parts.Add(i_Item);


            }

            return li_Car_Parts;
        }
        //---------------------------------------------------------------------------------------------------
        private void get_X_And_Y_For_Car_Parts(int x0_Pos, int y0_Pos, int car_Part_Width, int car_Part_Height)
        {
            x_Arr[0] = x0_Pos;
            x_Arr[1] = x_Arr[0];
            x_Arr[2] = x_Arr[0];
            x_Arr[3] = x_Arr[0];
            x_Arr[4] = x_Arr[0];
            x_Arr[5] = x_Arr[0] - car_Part_Width;
            x_Arr[6] = x_Arr[0] + car_Part_Width;
            x_Arr[7] = x_Arr[5];
            x_Arr[8] = x_Arr[6];

            y_Arr[0] = y0_Pos;
            y_Arr[1] = y_Arr[0] + car_Part_Height;
            y_Arr[2] = y_Arr[1] + car_Part_Height;
            y_Arr[3] = y_Arr[2] + car_Part_Height;
            y_Arr[4] = y_Arr[3] + car_Part_Height;
            y_Arr[5] = y_Arr[1];
            y_Arr[6] = y_Arr[1];
            y_Arr[7] = y_Arr[4];
            y_Arr[8] = y_Arr[4];


        }





    }
}
