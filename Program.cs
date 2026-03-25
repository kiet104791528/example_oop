using System;
using SplashKitSDK;

namespace week_4_task
{
    public class Program
    {
        public static void Main()
        {
            Window gameWindow = new Window("Week 4 Task", 800, 600);
            Shape shape1 = new Shape(100);
            do
            {
                SplashKit.ProcessEvents();
                   
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    shape1.X = (float)SplashKit.MouseX();
                    shape1.Y = (float)SplashKit.MouseY();
                }
                
                if (SplashKit.KeyTyped(KeyCode.SpaceKey) && shape1.IsAt(SplashKit.MousePosition()))
                {
                    shape1.Color = SplashKit.RandomColor();
                }
                
                SplashKit.ClearScreen(Color.White);

                shape1.Draw();

                gameWindow.Refresh(60);
            } while (!gameWindow.CloseRequested);
        }
    }
}
