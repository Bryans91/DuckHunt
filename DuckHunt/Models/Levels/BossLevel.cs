using System;

namespace DuckHunt
{
    internal class BossLevel : LevelState
    {
        private Level level;

        public BossLevel(Level level)
        {
            this.level = level;
        }

        public void changeBackground()
        {
            throw new NotImplementedException();
        }

        public void changeDuckSpeed()
        {
            throw new NotImplementedException();
        }

        public void checkLives()
        {
            throw new NotImplementedException();
        }

        public void checkScore()
        {
            throw new NotImplementedException();
        }
    }
}