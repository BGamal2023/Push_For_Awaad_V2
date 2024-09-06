using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes
{
    internal interface I_Btn
    {
        //-----------------------------
        public void set_The_OnClick_For_Any_Dirction_Button_GC(Canvas gameArea, DispatcherTimer timer, Button btn, I_GA_Btns_Runnable runnable);
        //-----------------------------
        public void add_The_Btn_To_The_GameArea_GC(
            Canvas gameArea,
            Button btn,
            int btn_Width,
            int btn_Height,
            int btn_Left_Pos,
            int btn_Top_Pos,
            string btn_Text,
            Brush btn_Color
            );

    }
}
