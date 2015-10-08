using System;
using System.Windows.Media;

namespace DuckHunt
{
    internal class LevelThree : LevelState
    {
        private Level level;

        public LevelThree(Level level)
        {
            this.level = level;
        }

        public void changeBackground()
        {
            level.dispatcher.Invoke(() => level.window.canvas.Background = Brushes.Navy);
            level.dispatcher.Invoke(() => level.window.levelInt.Content = 3);
        }

        public void checkScore()
        {
            level.dispatcher.Invoke(() => level.score = Convert.ToInt32(level.window.scoreInt.Content));
            if (level.score > 599)
            {
                level.dispatcher.Invoke(() => level.window.win.Content = "Yay, you win");
            }
        }
    }
}