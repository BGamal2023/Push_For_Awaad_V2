using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Fuel_Indicator;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_Player_Food
{
    internal class Player_Food_Creator
    {
        private C_Creating_One_Segement_Items_GC obj_Creating = new C_Creating_One_Segement_Items_GC();
        private C_Creating_Car obj_Creating_Car=new C_Creating_Car();
        public Brush[] player_Food_Colors =
        {
             Brushes.Red,
            Brushes.Yellow,
            Brushes.Magenta,
            Brushes.Cyan,
            Brushes.Gold,
            Brushes.White,
            Brushes.White,
             Brushes.White,
             Brushes.White,
        };
        //-------------------------------------------------------------------------------------------------

        public void create_The_Player_Food()
        {

            Globals.li_Player_Food= obj_Creating_Car.creat_Car(
          Globals.enemy_One_Block_Width,
           Globals.enemy_One_Block_Height,
            Globals.player_Food_X_pos,
           Globals.player_Food_Y_Pos,
           player_Food_Colors,
           Globals.no_Of_Blocks_in_enemy_Body);

          

        }
     

    }
}
