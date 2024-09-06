using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Shapes;
using Car_GameBoy.__Globals;

namespace Car_GameBoy._1_Deps._6_Collision
{
    internal class Food_Collision
    {
        public void detect_Food_Collision(List<C_Item> player, List<C_Item> Food)
        {
            for (int i = 0; i < player.Count; i++)
            {
                foreach (C_Item food_Piece in Food)
                {
                    bool isColliding = CheckCollision(player[i].rect, food_Piece.rect);
                    if (isColliding)
                    {
                        Globals.food_Collision = true;
                    }


                }
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        private bool CheckCollision(Rectangle rect1, Rectangle rect2)
        {
            // Get the bounding rectangles of the shapes
            Rect rect1Bounds = new Rect(Canvas.GetLeft(rect1), Canvas.GetTop(rect1), rect1.Width, rect1.Height);
            Rect rect2Bounds = new Rect(Canvas.GetLeft(rect2), Canvas.GetTop(rect2), rect2.Width, rect2.Height);

            // Check if the rectangles intersect
            return rect1Bounds.IntersectsWith(rect2Bounds);

        }

    }

}

