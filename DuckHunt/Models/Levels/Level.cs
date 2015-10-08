using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DuckHunt
{
    class Level
    {
        LevelState levelOne;
        LevelState levelTwo;
        LevelState levelThree;
        LevelState bossLevel;

        LevelState levelState;

        public MainWindow window;
        public int score = 0;

        public Dispatcher dispatcher;

        public Level(MainWindow window)
        {
            this.window = window;
            levelOne = new LevelOne(this);
            levelTwo = new LevelTwo(this);
            levelThree = new LevelThree(this);
            bossLevel = new BossLevel(this);
            setLevelState(levelOne);
            dispatcher = Dispatcher.CurrentDispatcher;
        }

        public void checkScore()
        {
            levelState.checkScore();
        }

        public void setLevelState(LevelState newLevelState)
        {
            levelState = newLevelState;
            levelState.changeBackground();
        }

        public LevelState getLevelOne() { return levelOne; }
        public LevelState getLevelTwo() { return levelTwo; }
        public LevelState getLevelThree() { return levelThree; }
        public LevelState getBossLevel() { return bossLevel; }


    }
}
