using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._0_MainWindow_Handler;
using Car_GameBoy._1_Deps._1_GameArea_Handler;
using Car_GameBoy._1_Deps._2_Creating.Creating_Collision_Text;
using Car_GameBoy._1_Deps._2_Creating.Creating_Fuel_Indicator;
using Car_GameBoy._1_Deps._2_Creating.Creating_Manager;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Manager;
using Car_GameBoy._1_Deps._4_Moving.Moving_Manager;
using Car_GameBoy._1_Deps._5_Buttons.Buttons_Manager;
using Car_GameBoy._1_Deps._6_Collision;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Info_Tickets_Bet_Levels;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Manager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class level
    {
        private MainWindow_Handler obj_MWH = new MainWindow_Handler();
        private GameArea_Handler obj_GAH = new GameArea_Handler();
        public DispatcherTimer timer = new DispatcherTimer();
        private Creating_Manager obj_Creating_Manager = new Creating_Manager();
        private Drawing_Manager obj_Drawing_Manager = new Drawing_Manager();
        private Moving_Manager obj_Moving_Manager = new Moving_Manager();
        private Buttons_Manager obj_Btns_Manager = new Buttons_Manager();
        private Collision_Text obj_Collision_Text = new Collision_Text();
        private Collision_Manager obj_Collision_Manager = new Collision_Manager();
        private Controlling_Manager obj_Controlling_Manager = new Controlling_Manager();
        private Level_Ticket_Info_Controller obj_Level_Info_Ticket = new Level_Ticket_Info_Controller();
        private static int current_Level_Nu = 1;
        private Success_Ticket_Controller obj_Success_Ticke = new Success_Ticket_Controller();
        private Actions_In_Starting_New_Level obj_Actions_In_Starting_New_Level = new Actions_In_Starting_New_Level();
        //--------------------------------------------------------------------------------------------
        public Canvas start_The_Level(MainWindow mW, Label gameOver_Label)
        {
            Globals.current_Level.Run();
            Canvas r_gameArea = OnCreat(mW, gameOver_Label);
            return r_gameArea;
        }
        //---------------------------------------------------------------------------------------------
        public Canvas OnCreat(MainWindow mW, Label gameOver_Label)
        {
            obj_MWH.customize_mainWindow(mW);
            Canvas gameArea = obj_GAH.handle_And_Give_Me_The_GameArea(mW);
            OnStart(mW, gameArea, gameOver_Label);
            return gameArea;
        }
        //----------------------------------------------------------------------------------------------
        public async Task OnStart(MainWindow mW, Canvas gameArea, Label gameOver_Label)
        {
            await OnStart_Actions(gameArea);
            onRun(mW, gameArea, gameOver_Label);
        }
        //------------------------------------------------------------------------------------------------
        private async Task OnStart_Actions(Canvas gameArea)
        {
            obj_Btns_Manager.handle_GameArea_Buttons(gameArea, timer);
            obj_Creating_Manager.creat();
            obj_Drawing_Manager.draw(gameArea);
            Level_Common_Code.reset_The_Fuel_Counter();
            obj_Level_Info_Ticket.show_Level_Ticket_Info_In_Starting_The_Level(gameArea, current_Level_Nu, Globals.level_Score, 5);
            await Task.Delay(6000);
        }
        //-----------------------------------------------------------------------------------------------
        public async void onRun(MainWindow mW, Canvas gameArea, Label gameOver_Label)
        {
            handle_The_Game_Timer(Score_Box_Creator.obj_TextBox, mW, gameArea, gameOver_Label);
        }
        //------------------------------------------------------------------------------------------------
        public void onDestroy(MainWindow mW, Canvas gameArea, Label gameOver_Label)
        {
            gameArea.Children.Remove(gameOver_Label); ;
            gameArea.Children.Add(gameOver_Label);
            timer.Stop();
        }
        //------------------------------------------------------------------------------------------------
        public void handle_The_Game_Timer(TextBox player_Score, MainWindow mW, Canvas gameArea, Label gameOver_Label)
        {
            timer.Tick += (sender, e) => timer_Tick(sender, e, mW, gameArea, gameOver_Label);
            timer.Interval = System.TimeSpan.FromMilliseconds(Globals.timerTick);
            timer.Start();
        }
        //------------------------------------------------------------------------------------------------
        private void timer_Tick(object sender, EventArgs e, MainWindow mW, Canvas gameArea, Label gameOver_Label)
        {

            obj_Collision_Manager.check_Collision(Globals.li_Player_Container, Globals.li_Enemy_Cars, Globals.li_Player_Food, timer);
            obj_Moving_Manager.move_Items_During_Timer_Tick(gameArea);
            Globals.player_Score += 1;
            Level_Common_Code.update_Player_Score(Score_Box_Creator.obj_TextBox);
            obj_Controlling_Manager.control(Globals.timerTick, gameArea);
            //--
            if (Globals.doesPlayCollision)
            {
                onDestroy(mW, gameArea, gameOver_Label);
            }
            if (Globals.player_Score > Globals.level_Score)
            {
                timer.Stop();
                current_Level_Nu += 1;
                OnStart_New_Level(mW, gameOver_Label, gameArea);
            }
            //--
        }
        //------------------------------------------------------------------------------------------------
        internal void onClick_Keyup(object sender, KeyEventArgs e, Label gameOver_Label, Canvas gameArea, MainWindow mW)
        {
            if (e.Key == Key.Space && Globals.doesPlayCollision == true)
            {
                gameArea.Children.Remove(gameOver_Label);
                foreach (List<C_Item> list_items in Globals.li_Enemy_Cars)
                {
                    foreach (C_Item item in list_items)
                    {
                        gameArea.Children.Remove(item.rect);
                    }
                }
                foreach (C_Item player_Container_Piece in Globals.li_Player_Container)
                {
                    gameArea.Children.Remove(player_Container_Piece.rect);
                }
                foreach (C_Item player_Piece in Globals.li_player)
                {
                    gameArea.Children.Remove(player_Piece.rect);
                }
                foreach (C_Item player_Food in Globals.li_Player_Food)
                {
                    gameArea.Children.Remove(player_Food.rect);
                }
                Globals.li_Enemy_Cars.Clear();
                Globals.li_Player_Container.Clear();
                Globals.li_player.Clear();
                Globals.doesPlayCollision = false;
                Globals.player_Score = 0;
                OnRestart_Same_Level(mW, gameArea, gameOver_Label);
            }
            else if(e.Key==Key.Space)
            {
                if (timer.IsEnabled)
                {
                    timer.Stop();
                }
                else
                {
                    timer.Start();
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        private async void OnRestart_Same_Level(MainWindow mW, Canvas gameArea, Label gameOver_Label)
        {
            Level_Common_Code.reset_The_Enemy_Position();
            obj_Creating_Manager.creat_After_GameOver();
            obj_Drawing_Manager.draw_After_GameOver(gameArea);
            Level_Common_Code.reset_The_Fuel_Counter();
            obj_Level_Info_Ticket.show_Level_Ticket_Info_In_Starting_The_Level(gameArea, current_Level_Nu, Globals.level_Score, 5);
            await Task.Delay(6000);
            onRun(mW, gameArea, gameOver_Label);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        private async Task OnStart_New_Level(MainWindow mW, Label game_Over_Label, Canvas gameArea)
        {
            obj_Success_Ticke.issue_Succeed_Tickt(gameArea, current_Level_Nu, Globals.level_Score, 3);
            await Task.Delay(3000);
            await obj_Actions_In_Starting_New_Level.Actions_Befor_Starting_New_Level
                 (
                 gameArea,
                 current_Level_Nu,
                 obj_Creating_Manager,
                 obj_Drawing_Manager,
                 obj_Level_Info_Ticket
                 );
            onRun(mW, gameArea, game_Over_Label);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
