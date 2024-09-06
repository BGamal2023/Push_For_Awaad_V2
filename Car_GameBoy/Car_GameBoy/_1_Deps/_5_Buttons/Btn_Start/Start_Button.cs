using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps._5_Buttons.Btn_Start
{
    internal class Start_Button
    {
        private C_Btn obj_btn=new C_Btn();
        Button btn_Start=new Button();
        //--------------------------------------------------------------------
        public void add_And_Handle_Start_Button(Canvas gameArea,DispatcherTimer timer)
        {
            obj_btn.handle_The_GameArea_Buttons_GC(
                gameArea,
                btn_Start,
                Globals.btn_Start_Widht,
                Globals.btn_Start_Height,
                Globals.btn_Start_Left_Pos,
                Globals.btn_Start_Top_Pos,
                Globals.btn_Start_Text,
                Globals.btn_Start_Bkground_Color,
                timer,
                new Start_Button.My_Btn_Start_Runnable()
                );
           
        }

        internal class My_Btn_Start_Runnable : I_GA_Btns_Runnable
        {
            public void Run(DispatcherTimer timer)
            {
                timer.Start();
                
            }
        }
    }
}
