using System;
using System.Windows.Media;

namespace DuckHunt
{
    internal class LevelTwo : LevelState
    {
        private Level level;

        public LevelTwo(Level level)
        {
            this.level = level;
        }

        public void changeBackground()
        {
            level.dispatcher.Invoke(() => level.window.canvas.Background = Brushes.DarkSlateGray);
            level.dispatcher.Invoke(() => level.window.levelInt.Content = 2);
        }

        public void checkScore()
        {
            level.dispatcher.Invoke(() => level.score = Convert.ToInt32(level.window.scoreInt.Content));
            if (level.score > 399)
            {
                level.setLevelState(level.getLevelThree());
            }
        }
    }
}