using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps._5_Buttons.Btn_Stop
{
    internal class Stop_Button
    {
        private C_Btn obj_Btn=new C_Btn();
        private Button btn_Stop = new Button();       
       //----------------------------------------------------------------------------------
        public void add_And_Handle_Stop_Btn(
            Canvas gameArea,
            DispatcherTimer timer)
        {
            obj_Btn.handle_The_GameArea_Buttons_GC
                (
                gameArea,
                btn_Stop,
                Globals.btn_Stop_Widht,
                Globals.btn_Stop_Height,
                Globals.btn_Stop_Left_Pos,
                Globals.btn_Stop_Top_Pos,
                Globals.btn_Stop_Text,
                Globals.btn_Stop_Bkground_Color,
                timer,
                new Stop_Button.OnClick_Callback_For_Btn_Stop()
                );

        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        internal class OnClick_Callback_For_Btn_Stop : I_GA_Btns_Runnable
        {
            public void Run(DispatcherTimer timer)
            {
                timer.Stop();
            }
        }
    }
}
