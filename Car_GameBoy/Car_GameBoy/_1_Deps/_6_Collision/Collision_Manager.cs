using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps._6_Collision
{
    internal class Collision_Manager
    {
        private Enemey_Collision obj_Enemy_Collision=new Enemey_Collision();
        private Food_Collision obj_Food_Collision=new Food_Collision();
       //---------------------------------------------------------------------
       public void check_Collision
            (List<C_Item> li_player, List<List<C_Item>> li_Enemies, List<C_Item> li_Food, DispatcherTimer timer)
        {
            obj_Enemy_Collision.detect_Enemy_Collison(li_player, li_Enemies, timer);
            obj_Food_Collision.detect_Food_Collision(li_player, li_Food);
        }
    }
}
