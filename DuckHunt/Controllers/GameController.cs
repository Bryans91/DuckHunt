using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace DuckHunt
{
    class GameController
    {

        private MainWindow window;
        private Level levelState;
        private DuckController duckController;

        public GameController(MainWindow window)
        {
            this.window = window;
            levelState = new Level(window);
            levelState.getLevelOne();
            duckController = new DuckController(window, this);
        }

        public void gameLoop()
        {
            double previous = DateTime.Now.Ticks;
            double lag = 0.0;
            while (true)
            {
                double current = DateTime.Now.Ticks;
                double elapsed = current - previous;
                previous = current;
                lag += elapsed;
                while (lag >= 60000)
                {
                    duckController.moveDucks();
                    levelState.checkScore();
                    lag -= 60000;
                }
            }
        }
    }
}
