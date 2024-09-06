using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using Car_GameBoy._1_Deps._3_Drawing.Interfaces_And_Thier_Imple_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes
{
    internal class C_Moving : I_Moving
    {
        private C_Drawing_Any_Item_GC obj_Drawing = new C_Drawing_Any_Item_GC();
        //------------------------------------------------------------------------------------------------------------
        public void move_Item_Vertical_Down_At_Fixed_Left_Pos(List<C_Item> list, Canvas gameArea, int increment_Value, int limit_Value)
        {
            clear_Item_From_The_GameArea(list, gameArea);
            change_Position_Value_Vertically(list, increment_Value, limit_Value);
            check_Top_Pos_Limit(list, limit_Value);
            redraw_The_Item(list, gameArea);

        }
        public void move_Item_Vertical_Down_At_Fixed_Left_Pos_With_Delay_Value
            (List<C_Item> list, Canvas gameArea, int increment_Value, int limit_Value,int delay_Value)
        {
            clear_Item_From_The_GameArea(list, gameArea);
            change_Position_Value_Vertically(list, increment_Value, limit_Value);
            check_Top_Pos_Limit_With_Delay_Value(list, limit_Value,delay_Value);
            redraw_The_Item(list, gameArea);

        }
        //------------------------------------------------------------------------------------------------------------

        public void move_Item_Vertical_Down_With_Changing_Left_Pos(List<C_Item> list, Canvas gameArea, int increment_Value, int limit_Value)
        {
            clear_Item_From_The_GameArea(list, gameArea);
            change_Position_Value_Vertically(list, increment_Value, limit_Value);
            check_Top_Pos_Limit_With_Changing_X_Pos(list, limit_Value, gameArea);
            redraw_The_Item(list, gameArea);
        }
        //------------------------------------------------------------------------------------------------------------
        public void move_Item_Horizontal_Right(List<C_Item> list, Canvas gameArea, int increment_Value, int limit_Value)
        {

            clear_Item_From_The_GameArea(list, gameArea);

            redraw_The_Item(list, gameArea);

        }
        //----------------------------------------------------------------------------------------------------
        public void clear_Item_From_The_GameArea(List<C_Item> list, Canvas gameArea)
        {
            for (int i = 0; i < list.Count; i++)
            {
                gameArea.Children.Remove(list[i].rect);
            }
        }
        //----------------------------------------------------------------------------------------------------
        public void change_Position_Value_Vertically(List<C_Item> list, int increment_Value, int limit_Value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].top_Pos += increment_Value;

            }
        }
        //----------------------------------------------------------------------------------------------------
        public void change_X_Pos_Randomly(List<C_Item> list, int limit_Value)
        {
            int increment_Value = generate_Randome_X_Pos_For_Enemey();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].top_Pos += increment_Value;

            }
        }
        //----------------------------------------------------------------------------------------------------
        public void change_Position_Value_Horizo(List<C_Item> list, int increment_Value, int limit_Value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].top_Pos += increment_Value;

            }
        }
        //----------------------------------------------------------------------------------------------------
        public void redraw_The_Item(List<C_Item> list, Canvas gameArea)
        {
            obj_Drawing.draw_Item(list, gameArea);

        }
        //----------------------------------------------------------------------------------------------------
        public void redraw_The_Item(List<C_Item> list, Canvas gameArea, int zIndex)
        {
            obj_Drawing.draw_Item(list, gameArea, zIndex);

        }
        //----------------------------------------------------------------------------------------------------
        public void check_Top_Pos_Limit_With_Delay_Value(List<C_Item> list, int limit_Value,int delay_Value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].top_Pos >= limit_Value+delay_Value)
                {
                    list[i].top_Pos = list[i].top_Pos - limit_Value;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------
        public void check_Top_Pos_Limit(List<C_Item> list, int limit_Value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].top_Pos >= limit_Value)
                {
                    list[i].top_Pos = list[i].top_Pos - limit_Value;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------
        public void check_Top_Pos_Limit_With_Changing_X_Pos(List<C_Item> list, int limit_Value, Canvas gameArea)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].top_Pos >= limit_Value)
                {

                    list[i].top_Pos = list[i].top_Pos - limit_Value;
                   

                }


            }
        }

     

    public void move_Item_Horizontal_Left(List<C_Item> list, Canvas gameArea, int increment_Value, int limit_Value)
        {
           
        }
        //--------------------------------------------------------------------------------
        private int generate_Randome_X_Pos_For_Enemey()
        {
            Random random = new Random();



            // Generate a random integer between 5 (inclusive) and 15 (exclusive)
            int randomNumberInRange = random.Next(Globals.racing_Area_X_Pos, Globals.right_Sideway_Blocks_X_Pos);

            return randomNumberInRange;
        }



    }

}
