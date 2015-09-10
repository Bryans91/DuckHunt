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
        private MainWindow n;

        public GameController(MainWindow n)
        {
            this.n = n;
            ducks = new ArrayList();
            //create duck and add to this.ducks
           
            var duckie = n.DrawRect(10, 10, 50, 50);
            ducks.Add(duckie);
            Thread t = new Thread(new ThreadStart(gameLoop));
            t.Start();
        }

        public void gameLoop()
        {
          while(ducks.Count > 0)
            {
                foreach(Rectangle d in ducks)
                {
                    //n.moveRect(d,2);
                }
               
                //moveducks
            }

        }


    }
}
