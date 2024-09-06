using Car_GameBoy.__Globals;
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
    internal class C_Btn : I_Btn
    {
        public void handle_The_GameArea_Buttons_GC(
             Canvas gameArea,
            Button btn,
            int btn_Width,
            int btn_Height,
            int btn_Left_Pos,
            int btn_Top_Pos,
            string btn_Text,
            Brush btn_Color,
            DispatcherTimer timer,
            I_GA_Btns_Runnable Btn_Onclick_Callback_Code)
        {
            add_The_Btn_To_The_GameArea_GC(gameArea, btn, btn_Width, btn_Height, btn_Left_Pos, btn_Top_Pos, btn_Text, btn_Color);
            set_The_OnClick_For_Any_Dirction_Button_GC(gameArea, timer, btn,Btn_Onclick_Callback_Code);
        }
        //---------------------------------------------------------------------------------
        public void handle_The_KeyBoard_Buttons_GC
            (Canvas gameArea,
            Button btn,
            DispatcherTimer timer,
            I_GA_Btns_Runnable Btn_Onclick_Callback_Code)
        {
            set_The_OnClick_For_Any_Dirction_Button_GC(gameArea, timer, btn, Btn_Onclick_Callback_Code);

        }
        //---------------------------------------------------------------------------------
        public void add_The_Btn_To_The_GameArea_GC(
            Canvas gameArea, 
            Button btn, 
            int btn_Width, 
            int btn_Height, 
            int btn_Left_Pos, 
            int btn_Top_Pos, 
            string btn_Text, 
            Brush btn_Color)
        {
            gameArea.Children.Add(btn);
            btn.Height = btn_Height;
            btn.Width = btn_Width;
            btn.Background = btn_Color;
            btn.Content = btn_Text;
            Canvas.SetLeft(btn, btn_Left_Pos);
            Canvas.SetTop(btn, btn_Top_Pos);
        }
        //---------------------------------------------------------------------------------
        public void Btn_OnClick_GC(object sender, EventArgs e,I_GA_Btns_Runnable runnable,DispatcherTimer timer)
        {
            runnable.Run(timer);
        }
        //-----------------------------------------------------------------------------------
        public void set_The_OnClick_For_Any_Dirction_Button_GC(Canvas gameArea, DispatcherTimer timer, Button btn,I_GA_Btns_Runnable runnable)
        {
            btn.Click += (sender, e) => Btn_OnClick_GC(sender, e,runnable,timer);
        }

       

    }
}
