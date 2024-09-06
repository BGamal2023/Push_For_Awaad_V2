using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_List_Of_Brush_Colors
{
    internal class Creating_The_List_Of_Brush_Colors
    {


        public static void GenerateDistinctBrushes(int count)
        {
           
            Random random = new Random();
            int greenThreshold = 100;

            // Generate a list of distinct colors
            while (Globals.li_Car_Colors.Count < count)
            {
                // Generate random RGB values
                byte red = (byte)random.Next(256);
                byte green = (byte)random.Next(256);
                byte blue = (byte)random.Next(256);

                if (green >= greenThreshold)
                {
                    // Skip green colors
                    continue;
                }
                // Create a SolidColorBrush with the generated color
                SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, red, green, blue));

                // Check if the brush is already in the list
                if (!Globals.li_Car_Colors.Contains(brush))
                {
                    Globals.li_Car_Colors.Add(brush);
                }
            }

          
        }
    }
}
