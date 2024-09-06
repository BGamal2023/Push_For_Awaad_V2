using Car_GameBoy._1_Deps._5_Buttons.Btn_Start;
using Car_GameBoy._1_Deps._5_Buttons.Btn_Stop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps._5_Buttons.Buttons_Manager
{
    internal class Buttons_Manager
    {
        private Start_Button obj_Btn_Start=new Start_Button();
        private Stop_Button obj_Btn_Stop=new Stop_Button();
        //-------------------------------------------------------------------------------------------------
        public void handle_GameArea_Buttons(Canvas gameArea,DispatcherTimer timer
            )
        {
            obj_Btn_Start.add_And_Handle_Start_Button(gameArea, timer);
            obj_Btn_Stop.add_And_Handle_Stop_Btn(gameArea, timer);
        }
        //-------------------------------------------------------------------------------------------------
        public void set_The_current_Callback_Code_For_Arrow_Strokes(Canvas gameArea,DispatcherTimer timer)
        {

        }
    }
}
