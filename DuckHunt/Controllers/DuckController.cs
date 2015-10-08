using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DuckHunt
{
    class DuckController
    {

        MainWindow window;
        public GameController gameController;
        Dispatcher dispatcher;
        public DuckFactory duckFactory;
        private ArrayList ducks;
        Random rnd;
        Rectangle rect;
        int left;
        int top;
        int size = 50;

        public DuckController(MainWindow window, GameController gameController)
        {
            this.window = window;
            this.gameController = gameController;
            ducks = new ArrayList();
            rnd = new Random();
            dispatcher = Dispatcher.CurrentDispatcher;
            duckFactory = new DuckFactory(window, this);
        }

        public void addDuck(Duck duck)
        {
            ducks.Add(duck);
        }

        public void moveDucks()
        {
            foreach (Duck d in ducks)
            {
                rect = d.getRect();
                top = d.top;
                moveLeft(rect, top);
            }
        }

        public void moveLeft(Rectangle rect, int top)
        {
            this.left++;
            if (this.left > 750)
            {
                this.left = -size;
            }
            if (dispatcher.CheckAccess())
            {
                rect.Margin = new Thickness(this.left, top, size, size);
            }
            else
            {
                dispatcher.Invoke(() => rect.Margin = new Thickness(this.left, top, size, size));
            }
        }

        public void reset()
        {
            ducks = null;
            ducks = new ArrayList();
            duckFactory = null;
            duckFactory = new DuckFactory(window, this);

        }

    }
}
