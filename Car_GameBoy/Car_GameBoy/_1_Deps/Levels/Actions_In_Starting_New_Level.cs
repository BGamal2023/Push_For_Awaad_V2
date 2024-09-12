using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Manager;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Manager;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Info_Tickets_Bet_Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Actions_In_Starting_New_Level
    {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public async Task Actions_Befor_Starting_New_Level(
            Canvas gameArea, 
            int current_Level_Nu,
            Creating_Manager obj_Creating_Manager,
            Drawing_Manager obj_Drawing_Manager,
            Level_Ticket_Info_Controller obj_Level_Info_Ticket
            )
        {
            Level_Common_Code.detect_New_Level(current_Level_Nu);
            remove_Some_Items_From_GameArea(gameArea);
            clear_Some_Lists();
            Globals.doesPlayCollision = false;
            Level_Common_Code.reset_The_Enemy_Position();
            obj_Creating_Manager.creat_Befor_Starting_New_Level();
            obj_Drawing_Manager.draw_Before_Starting_New_Level(gameArea);
            Level_Common_Code.reset_The_Fuel_Counter();
            obj_Level_Info_Ticket.show_Level_Ticket_Info_In_Starting_The_Level(gameArea, current_Level_Nu, Globals.level_Score, 5);
            await Task.Delay(6000);
        }
       
        //---------------------------------------------------------------------------------------------------------------------------------
        private void remove_Some_Items_From_GameArea(Canvas gameArea)
        {
            remove_Lines_From_GameArea(gameArea);
            remove_Right_And_Left_SideWay_From_GameArea(gameArea);
            remove_Blocks_Of_Right_And_Left_SideWay_From_GameArea(gameArea);
            remove_The_Racing_Area(gameArea);
            remove_The_Enemy_Cars_From_GameArea(gameArea);
            remove_The_Player_From_GameArea(gameArea);
            remove_The_Food_From_GameArea(gameArea);

        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void remove_Lines_From_GameArea(Canvas gameArea)
        {
            foreach (C_Item line in Globals.li_Lines_In_Racing_Area_New)
            {
                gameArea.Children.Remove(line.rect);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void remove_Right_And_Left_SideWay_From_GameArea(Canvas gameArea)
        {
            foreach (C_Item racing_Area_Lef_Side in Globals.li_The_Left_Side_Of_The_Racing_Area)
            {
                gameArea.Children.Remove(racing_Area_Lef_Side.rect);
            }
            foreach (C_Item racing_Area_Right_Side in Globals.li_The_Right_Side_Of_The_Racing_Area)
            {
                gameArea.Children.Remove(racing_Area_Right_Side.rect);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void remove_Blocks_Of_Right_And_Left_SideWay_From_GameArea(Canvas gameArea)
        {
            foreach (C_Item left_Side_Blocks in Globals.li_Of_The_Left_Sideway_Blocks_New)
            {
                gameArea.Children.Remove(left_Side_Blocks.rect);
            }
            foreach (C_Item right_Side_Blocks in Globals.li_Of_The_Right_Sideway_Blocks_New)
            {
                gameArea.Children.Remove(right_Side_Blocks.rect);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void remove_The_Racing_Area(Canvas gameArea)
        {

            foreach (C_Item racing_Area in Globals.li_The_Racing_Area)
            {
                gameArea.Children.Remove(racing_Area.rect);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void remove_The_Enemy_Cars_From_GameArea(Canvas gameArea)
        {
            foreach (List<C_Item> list_items in Globals.li_Enemy_Cars)
            {
                foreach (C_Item item in list_items)
                {
                    gameArea.Children.Remove(item.rect);
                }
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void remove_The_Player_From_GameArea(Canvas gameArea)
        {

            foreach (C_Item player_Container_Piece in Globals.li_Player_Container)
            {
                gameArea.Children.Remove(player_Container_Piece.rect);
            }
            foreach (C_Item player_Piece in Globals.li_player)
            {
                gameArea.Children.Remove(player_Piece.rect);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void remove_The_Food_From_GameArea(Canvas gameArea)
        {
            foreach (C_Item player_Food in Globals.li_Player_Food)
            {
                gameArea.Children.Remove(player_Food.rect);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        private void clear_Some_Lists()
        {
            Globals.li_Lines_In_Racing_Area_New.Clear();
            Globals.li_The_Left_Side_Of_The_Racing_Area.Clear();
            Globals.li_The_Right_Side_Of_The_Racing_Area.Clear();
            Globals.li_Of_The_Left_Sideway_Blocks_New.Clear();
            Globals.li_Of_The_Right_Sideway_Blocks_New.Clear();
            Globals.li_The_Racing_Area.Clear();
            Globals.li_Enemy_Cars.Clear();
            Globals.li_Player_Container.Clear();
            Globals.li_player.Clear();
        }
        //---------------------------------------------------------------------------------------------------------------------------------

    }
}
