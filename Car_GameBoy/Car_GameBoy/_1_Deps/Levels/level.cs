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
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Info_Tickets_Bet_Levels;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class level
    {
        private MainWindow_Handler obj_MWH = new MainWindow_Handler();
        private GameArea_Handler obj_GAH = new GameArea_Handler();
        private DispatcherTimer timer = new DispatcherTimer();
        private Creating_Manager obj_Creating_Manager = new Creating_Manager();
        private Drawing_Manager obj_Drawing_Manager = new Drawing_Manager();
        private Moving_Manager obj_Moving_Manager = new Moving_Manager();
        private Buttons_Manager obj_Btns_Manager = new Buttons_Manager();
        private Collision_Text obj_Collision_Text = new Collision_Text();
        private Collision_Manager obj_Collision_Manager = new Collision_Manager();
        private Controlling_Manager obj_Controlling_Manager = new Controlling_Manager();
        private int count = 0;
        private Level_Ticket_Info_Controller obj_Level_Info_Ticket=new Level_Ticket_Info_Controller();

        private bool doesHappen=false;  
        //----------------------------------------------------------------------------------------------------
        public void start_The_Level(MainWindow mW, Canvas gameArea)
        {
            OnCreat(mW,gameArea);  
        }
        //----------------------------------------------------------------------------------------------------

        public void OnCreat(MainWindow mW,Canvas gameArea)
        {


            obj_MWH.customize_mainWindow(mW);
            gameArea = obj_GAH.handle_And_Give_Me_The_GameArea(mW);

            OnStart(mW,gameArea);

        }
        //----------------------------------------------------------------------------------------------------

        public async Task OnStart(MainWindow mW, Canvas gameArea)
        {
            await start_Actions(gameArea);
            handle_The_Game_Timer(Score_Box_Creator.obj_TextBox,mW, gameArea    );
            
        }
        //----------------------------------------------------------------------------------------------------

        public async void onRun(MainWindow mW, Canvas gameArea)
        {
            obj_Collision_Manager.check_Collision(Globals.li_Player_Container, Globals.li_Enemy_Cars, Globals.li_Player_Food, timer);

            obj_Moving_Manager.move_Items_During_Timer_Tick(gameArea);
            Globals.player_Score += 1;
            update_Player_Score(Score_Box_Creator.obj_TextBox );
            obj_Controlling_Manager.control(Globals.timerTick, gameArea);

            if (Globals.doesPlayCollision)
            {
                onDestroy(mW, gameArea);

            }

        }
        //----------------------------------------------------------------------------------------------------


        public void onDestroy(MainWindow mW, Canvas gameArea)
        {
            MessageBox.Show("onDestroy is invoked");
            start_The_Level(mW, gameArea);
            timer.Stop();

        }

        //------------------------------------------------------------------------------------------------
        private void set_The_Initial_Values()
        {
            Globals.player_Fuel = 100;
            Fuel_Indicator_Creator.fuel_Indic_TBox.Text = Globals.player_Fuel.ToString();

        }
        //------------------------------------------------------------------------------------------------


        private async Task start_Actions( Canvas gameArea)
        {
            obj_Btns_Manager.handle_GameArea_Buttons(gameArea, timer);
            obj_Creating_Manager.creat();
            obj_Drawing_Manager.draw(gameArea);
            set_The_Initial_Values();
            obj_Level_Info_Ticket.show_Level_Ticket_Info_In_Starting_The_Level(gameArea, 1,500 , 5);
            await Task.Delay(6000);
        }
        //------------------------------------------------------------------------------------------------
        private void update_Player_Score(TextBox tb)
        {
            tb.Text = Globals.player_Score.ToString();
        }

        //------------------------------------------------------------------------------------------------
        public void handle_The_Game_Timer(TextBox player_Score,MainWindow mW, Canvas gameArea)
        {
            timer.Tick += (sender, e) => timer_Tick(sender, e,mW,gameArea);

            timer.Interval = System.TimeSpan.FromMilliseconds(Globals.timerTick);
            timer.Start(); 
        }
        //------------------------------------------------------------------------------------------------
        private void timer_Tick(object sender, EventArgs e,MainWindow mW, Canvas gameArea)
        {
            onRun(mW, gameArea  );

        }
    }
}
