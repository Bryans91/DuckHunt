using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace DuckHunt
{
    class GameController
    {

        private ArrayList ducks;
        private MainWindow window;

        public GameController(MainWindow window)
        {
            this.window = window;
            ducks = new ArrayList();
            //create duck and add to this.ducks

            Duck d = new Duck(window);
            d.DrawRect();
            ducks.Add(d);
            Thread t = new Thread(new ThreadStart(gameLoop));
            t.Start();

            Duck d2 = new Duck(window);
            d2.DrawRect();
            ducks.Add(d2);
            Thread t2 = new Thread(new ThreadStart(gameLoop));
            t2.Start();
        }

        public void gameLoop()
        {
          while(ducks.Count > 0)
            {
                foreach(Duck d in ducks)
                {
                    d.moveLeft();
                }
            }

        }


    }
}
