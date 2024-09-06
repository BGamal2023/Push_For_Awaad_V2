using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_The_Enemyes
{
    internal class Creating_The_Enemies
    {
        private C_Creating_Car obj_Creating_Car = new C_Creating_Car();
        //--------------------------------------------------------------------------------
        public void creating_The_Enemies()
        {
            for (int i = 0; i < Globals.number_Of_Enemies; i++)
            {
                List<C_Item> li_Car_Parts = obj_Creating_Car.creat_Car(
                Globals.enemy_One_Block_Width,
                 Globals.enemy_One_Block_Height,
                 Globals.enemy_X_Pos,
                 Globals.enemy_Y_Pos,
                 Globals.enemy_Color,
                 Globals.no_Of_Blocks_in_enemy_Body);

                Globals.li_Enemy_Cars.Add(li_Car_Parts);

                Globals.enemy_X_Pos = generate_Randome_X_Pos_For_Enemey();

                Globals.enemy_Color = Globals.li_Car_Colors[generate_Randome_Num_For_Enemy_Color()];

                Globals.enemy_Y_Pos += Globals.vertical_Dis_Bet_Enemies;

            }


        }
        //--------------------------------------------------------------------------------
        private int generate_Randome_X_Pos_For_Enemey()
        {
            Random random = new Random();



            // Generate a random integer between 5 (inclusive) and 15 (exclusive)
            int randomNumberInRange =
                random.Next(Globals.racing_Area_X_Pos + Globals.enemy_One_Block_Width, Globals.right_Sideway_Blocks_X_Pos - 2 * Globals.enemy_One_Block_Width);

            return randomNumberInRange;
        }
        //--------------------------------------------------------------------------------
        private int generate_Randome_Num_For_Enemy_Color()
        {
            Random random = new Random();



            // Generate a random integer between 5 (inclusive) and 15 (exclusive)
            int randomNumberInRange =
                random.Next(0, Globals.li_Car_Colors.Count);

            return randomNumberInRange;
        }


    }
}
