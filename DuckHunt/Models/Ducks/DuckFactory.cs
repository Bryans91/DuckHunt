using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DuckHunt
{
    class DuckFactory
    {

        MainWindow window;
        DuckController controller;
        Random rnd;
        int top;
        Thread t;

        public DuckFactory(MainWindow window, DuckController controller)
        {
            this.window = window;
            this.controller = controller;
            rnd = new Random();

            newDuck();

            t = new Thread(new ThreadStart(controller.gameController.gameLoop));
            t.Start();
        }

        public void newDuck()
        {
            top = rnd.Next(25, 300);
            Duck d;
            if (rnd.Next(0, 2) == 0)
            {
                d = new RedDuck(window, top, controller);
            }
            else
            {
                d = new GreenDuck(window, top, controller);
            }
            d.drawRect();
            controller.addDuck(d);
        }

    }
}
