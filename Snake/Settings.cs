using Snake.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Direction { Up, Down, Left, Right};

    class Settings
    {
        public static int Heigth { get; set; }
        public static int Width { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int HighestScore { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings() {
            Width = 14;
            Heigth = 14;
            Speed = 13;
            HighestScore = Int32.Parse(System.IO.File.ReadAllText("..\\HighestScore.txt"));
            Score = 0;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
