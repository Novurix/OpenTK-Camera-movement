using System;
using OpenTK;

namespace CAMERA_MOVEMENT
{
    class MainClass
    {
        static GameWindow window;
        static Game game;
        public static void Main(string[] args)
        {
            window = new GameWindow(720, 720);
            game = new Game(window);
        }
    }
}
