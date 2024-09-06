using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Media.Media3D;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System.Windows.Documents;
using Car_GameBoy.__Globals;
using System.Windows.Threading;


namespace Car_GameBoy._1_Deps._2_Creating.Creating_Collision_Text
{
    internal class Collision_Text
    {


        public void detect_Collision(List<C_Item> player, List<C_Item> enemy,DispatcherTimer timer)
        {

            for (int i = 0; i < player.Count; i++)
            {
                for (int j = 0; j < enemy.Count; j++)
                {
                    Globals.doesPlayCollision= checkCollision(player[i], enemy[j]);
                    if(Globals.doesPlayCollision)
                    {
                        Globals.collision_Num++;
                        MessageBox.Show("Collision!");
                        timer.Stop();

                    }
                }
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        private bool checkCollision(C_Item item_1, C_Item item_2)
        {

            return (
            item_1.left_Pos < item_2.left_Pos + item_2.width &&
            item_1.left_Pos + item_1.width > item_2.left_Pos &&
            item_1.top_Pos < item_2.top_Pos + item_2.Height &&
              item_1.top_Pos + item_1.Height > item_2.top_Pos
            );
            //-----------------------------------------------------------------------------------------------------------------------------------

        }


    }

}
