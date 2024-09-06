using Car_GameBoy.__Globals;

using Car_GameBoy._1_Deps._0_MainWindow_Handler;
using Car_GameBoy._1_Deps._1_GameArea_Handler;
using Car_GameBoy._1_Deps._2_Creating.Creating_Collision_Text;
using Car_GameBoy._1_Deps._2_Creating.Creating_Fuel_Indicator;
using Car_GameBoy._1_Deps._2_Creating.Creating_Manager;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Manager;
using Car_GameBoy._1_Deps._4_Moving.Moving_Manager;
using Car_GameBoy._1_Deps._5_Buttons.Buttons_Manager;
using Car_GameBoy._1_Deps._6_Collision;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Level_1
    {

        private MainWindow_Handler obj_MWH = new MainWindow_Handler();
        private GameArea_Handler obj_GAH = new GameArea_Handler();
        private Canvas gameArea = new Canvas();
        private DispatcherTimer timer = new DispatcherTimer();
        private Creating_Manager obj_Creating_Manager = new Creating_Manager();
        private Drawing_Manager obj_Drawing_Manager = new Drawing_Manager();
        private Moving_Manager obj_Moving_Manager = new Moving_Manager();
        private Buttons_Manager obj_Btns_Manager = new Buttons_Manager();
        private Collision_Text obj_Collision_Text = new Collision_Text();
        private Collision_Manager obj_Collision_Manager = new Collision_Manager();
        private Controlling_Manager obj_Controlling_Manager = new Controlling_Manager();
        private int count = 0;
        //-----------------------------------------------------------------
        public void Run(MainWindow mW, TextBox player_Score_TB )
        {
            if(Globals.activeOnStart)
            {
                onStart(mW);
            }
            if(Globals.activeOnRun)
            {
                onRun(player_Score_TB);
            }
            if(Globals.activeOnDestroy)
            {
                onDestroy(mW);
            }

        }
        //-----------------------------------------------------------------

        public void onStart(MainWindow mW)
        {
            obj_MWH.customize_mainWindow(mW);
            gameArea = obj_GAH.handle_And_Give_Me_The_GameArea(mW);
          //  handle_The_Game_Timer(Score_Box_Creator.obj_TextBox);
            obj_Btns_Manager.handle_GameArea_Buttons(gameArea, timer);
            obj_Creating_Manager.creat();
            obj_Drawing_Manager.draw(gameArea);
            set_The_Initial_Values();
           // Globals.activeOnRun=true;

        }

       
        public void onRun(TextBox player_Score_TB)
        {
            Globals.activeOnStart = false;
            obj_Collision_Manager.check_Collision(Globals.li_Player_Container, Globals.li_Enemy_Cars, Globals.li_Player_Food, timer);
            obj_Moving_Manager.move_Items_During_Timer_Tick(gameArea);
            Globals.player_Score += 1;
            update_Player_Score(player_Score_TB);
            obj_Controlling_Manager.control(Globals.timerTick, gameArea);
            
        }

        public void onDestroy( MainWindow mW)
        { 
            Globals.activeOnRun= false;
            MessageBox.Show("failed level");
            Globals.activeOnStart = true;
           // obj_Level_State_Manager.monitor_The_Level_States(obj_Level_1, mW);


        }
        //------------------------------------------------------------------------------------------------
        public void handle_The_Game_Timer(TextBox player_Score)
        {
            timer.Tick += (sender, e) => timer_Tick(sender, e, gameArea, player_Score);

            timer.Interval = System.TimeSpan.FromMilliseconds(Globals.timerTick);
        }

        private void timer_Tick(object sender, EventArgs e, Canvas gameArea, TextBox player_Score)
        {
           // throw new NotImplementedException();
        }
        //------------------------------------------------------------------------------------------------
        private void update_Player_Score(TextBox tb)
        {
            tb.Text = Globals.player_Score.ToString();
        }
        //------------------------------------------------------------------------------------------------
        private void set_The_Initial_Values()
        {
            Globals.player_Fuel = 100;
            Fuel_Indicator_Creator.fuel_Indic_TBox.Text = Globals.player_Fuel.ToString();

        }
    }
}
