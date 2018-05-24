using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TronGame
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Speed { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            
            Speed = 5;
            GameOver = false;
            
        }
    }

    public class NonFocusButton : Button
    {
        public NonFocusButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
    }

}
