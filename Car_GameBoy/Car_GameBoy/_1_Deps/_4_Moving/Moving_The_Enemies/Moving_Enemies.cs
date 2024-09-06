using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_The_Enemyes;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Car_GameBoy._1_Deps._4_Moving.Moving_The_Enemies
{
    internal class Moving_Enemies
    {
        private C_Moving obj_Moving = new C_Moving();
        private C_Creating_Car obj_Creating_Car = new C_Creating_Car();
        private int list_Count = 0;
        //----------------------------------------------------------------------------------------------------
        public void move_Enemies(Canvas gameArea)
        {
         
            
                move_Item_Vertical_Down_With_Changing_Left_Pos(Globals.li_Enemy_Cars, gameArea, Globals.moving_Increment, Globals.gameArea_Height);

            


        }
      
        //------------------------------------------------------------------------------------------------------------

        public void move_Item_Vertical_Down_With_Changing_Left_Pos(List<List<C_Item>> list, Canvas gameArea, int increment_Value, int limit_Value)
        {
            cleare_The_GameArea_From_Enemies(list, gameArea);
            change_Position_Value_Vertically(list, increment_Value, limit_Value);
            list_Count=Globals.li_Enemy_Cars.Count;
            check_Top_Pos_Limit_With_Changing_X_Pos(list, limit_Value, gameArea);
            redraw_The_Enemies(list,gameArea );
        }

        //------------------------------------------------------------------------------------------------------------

        private void cleare_The_GameArea_From_Enemies(List<List<C_Item>> list, Canvas gameArea)
        {
            foreach (List<C_Item> list_items in list)
            {
                foreach (C_Item item in list_items)
                {
                    gameArea.Children.Remove(item.rect);
                }
            }
        }


        private void change_Position_Value_Vertically(List<List<C_Item>> list, int increment_Value, int limit_Value)
        {
            foreach (List<C_Item> list_item in list)
            {
                foreach (C_Item item in list_item)
                {
                    item.top_Pos += increment_Value;
                }
            }
        }

        private void check_Top_Pos_Limit_With_Changing_X_Pos(List<List<C_Item>> list, int limit_Value, Canvas gameArea)
        {


            for (int i = 0; i < list_Count; i++)
            {
                List < C_Item> i_Car= list[i];

                if (i_Car[0].top_Pos >= limit_Value)
                {
                    list.Remove(i_Car);
                    int x = generate_Randome_X_Pos_For_Enemey();
                    int color_Number = generate_Randome_Number_For_Car_Color();

                    List<C_Item> li_Car_Parts = obj_Creating_Car.creat_Car(
                Globals.enemy_One_Block_Width,
                Globals.enemy_One_Block_Height,
                x,
                0,
                Globals.li_Car_Colors[color_Number],
                Globals.no_Of_Blocks_in_enemy_Body);

                    Globals.li_Enemy_Cars.Add(li_Car_Parts);
                }
            }









            foreach (List<C_Item> list_items in list)
            {
                if (list_items[0].top_Pos >= limit_Value)
                {
                    

                }
            }
        }

        private int generate_Randome_X_Pos_For_Enemey()
        {
            Random random = new Random();
            int randomNumberInRange = random.Next(Globals.racing_Area_X_Pos+Globals.enemy_One_Block_Width, Globals.right_Sideway_Blocks_X_Pos- 2*Globals.enemy_One_Block_Width);
            return randomNumberInRange;
        }
        private int generate_Randome_Number_For_Car_Color()
        {
            Random random = new Random();
            int randomNumberInRange = random.Next(0, Globals.li_Car_Colors.Count);
            return randomNumberInRange;
        }

        private void redraw_The_Enemies(List<List<C_Item>> list,Canvas gameArea)
        {
            foreach(List<C_Item> car_Parts_List in list) 
            { 
                foreach(C_Item car_Part in car_Parts_List)
                {
                    gameArea.Children.Add(car_Part.rect);
                    Canvas.SetLeft(car_Part.rect, car_Part.left_Pos);
                    Canvas.SetTop(car_Part.rect,car_Part.top_Pos);  
                }
            }
        }

    }
}
