using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace DuckHunt.Controllers
{
    class GameController
    {

        private ArrayList ducks;
        private MainWindow n = new MainWindow();

        public GameController()
        {
            ducks = new ArrayList();
            //create duck and add to this.ducks
           
            var duckie = n.DrawRect(25, 25, 200, 200);
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
                    n.moveRect(d,2);
                }
               
                //moveducks
            }

        }


    }
}
