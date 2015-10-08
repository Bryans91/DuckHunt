using System;

namespace DuckHunt
{
    internal class LevelOne : LevelState
    {
        private Level level;

        public LevelOne(Level level)
        {
            this.level = level;
        }

        public void changeBackground()
        {
            // No need to change yet.
        }

        public void checkScore()
        {
            level.dispatcher.Invoke(() => level.score = Convert.ToInt32(level.window.scoreInt.Content));
            if (level.score > 199)
            {
                level.setLevelState(level.getLevelTwo());
            }
        }
    }
}