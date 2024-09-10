using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Shapes;
using Car_GameBoy.__Globals;

namespace Car_GameBoy._1_Deps._7_Controlling.Controlling_Info_Tickets_Bet_Levels
{
    internal class Level_Ticket_Info_Controller
    {


        public void show_Level_Ticket_Info_In_Starting_The_Level(Canvas gameArea, int level_No, int req_Score, int show_Time_In_Second)
        {
            // Create the canvas
            Canvas canvas = new Canvas();
            canvas.Width = 300;
            canvas.Height = 200;

            // Set the background of the canvas
            canvas.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); // White background

            // Create a border around the canvas
            Rectangle border = new Rectangle();
            border.Stroke = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0)); // Black border
            border.StrokeThickness = 1;
            border.RadiusX = 10;
            border.RadiusY = 10;
            border.Width = canvas.Width;
            border.Height = canvas.Height;
            Canvas.SetTop(border, 0);
            Canvas.SetLeft(border, 0);
            canvas.Children.Add(border);

            // Create the label
            Label label = new Label();
            label.Content = "Level Information";
            label.FontSize = 18;
            label.HorizontalAlignment = HorizontalAlignment.Center;
            label.VerticalAlignment = VerticalAlignment.Center;
            Canvas.SetTop(label, 20);
            Canvas.SetLeft(label, canvas.Width / 2 - label.Width / 2);
            canvas.Children.Add(label);

            // Create the first text block
            TextBlock textBlock1 = new TextBlock();
            textBlock1.Text = "Level_No:-";
            textBlock1.FontSize = 14;
            textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock1.VerticalAlignment = VerticalAlignment.Center;
            Canvas.SetTop(textBlock1, 60);
            Canvas.SetLeft(textBlock1, canvas.Width / 2 - textBlock1.Width / 2);
            canvas.Children.Add(textBlock1);

            // Create the first text box
            TextBox textBox1 = new TextBox();
            textBox1.Width = 150;
            textBox1.FontSize = 14;
            textBox1.HorizontalAlignment = HorizontalAlignment.Center;
            textBox1.VerticalAlignment = VerticalAlignment.Center;
            textBox1.Text = level_No.ToString();
            Canvas.SetTop(textBox1, 80);
            Canvas.SetLeft(textBox1, canvas.Width / 2 - textBox1.Width / 2);
            canvas.Children.Add(textBox1);

            // Create the second text block
            TextBlock textBlock2 = new TextBlock();
            textBlock2.Text = "Required Score:-";
            textBlock2.FontSize = 14;
            textBlock2.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock2.VerticalAlignment = VerticalAlignment.Center;
            Canvas.SetTop(textBlock2, 120);
            Canvas.SetLeft(textBlock2, canvas.Width / 2 - textBlock2.Width / 2);
            canvas.Children.Add(textBlock2);

            // Create the second text box
            TextBox textBox2 = new TextBox();
            textBox2.Width = 150;
            textBox2.FontSize = 14;
            textBox2.HorizontalAlignment = HorizontalAlignment.Center;
            textBox2.VerticalAlignment = VerticalAlignment.Center;
            textBox2.Text = req_Score.ToString();

            Canvas.SetTop(textBox2, 140);
            Canvas.SetLeft(textBox2, canvas.Width / 2 - textBox2.Width / 2);
            canvas.Children.Add(textBox2);

            // Add the canvas to the window
            gameArea.Children.Add(canvas);
            Canvas.SetTop(canvas, gameArea.Height / 2 - canvas.Height / 2);
            Canvas.SetLeft(canvas, gameArea.Width / 2 - canvas.Width / 2);
            Canvas.SetZIndex(canvas, 100);
            // Create a timer to remove the canvas after 5 seconds
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(show_Time_In_Second);
            timer.Tick += (sender, e) =>
            {
                gameArea.Children.Remove(canvas);

            };

            timer.Start();
        }

    }
}
