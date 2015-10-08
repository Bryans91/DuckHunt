using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DuckHunt
{
    abstract class Duck
    {
        DuckState aliveDuck;
        DuckState shotDuck;
        DuckState deadDuck;

        DuckState duckState;

        public MainWindow window;
        public DuckController controller;
        protected Rectangle rect;
        public Dispatcher dispatcher;
        public int left;
        public int top;
        protected int size = 50;

        public Duck(MainWindow window, int top, DuckController controller)
        {
            dispatcher = Dispatcher.CurrentDispatcher;
            aliveDuck = new AliveDuck(this);
            shotDuck = new ShotDuck(this);
            deadDuck = new DeadDuck(this);

            this.controller = controller;

            duckState = aliveDuck;
            
        }

        public abstract Rectangle drawRect();
        public abstract void getShot(object sender, RoutedEventArgs e);

        public void setNextDuckState(Rectangle rect)
        {
            duckState.getShot();
        }

        public void setDuckState(DuckState newDuckState)
        {
            duckState = newDuckState;
        }

        public Rectangle getRect()
        {
            return rect;
        }

        public DuckState getAliveDuck() { return aliveDuck; }
        public DuckState getShotDuck() { return shotDuck; }
        public DuckState getDeadDuck() { return deadDuck; }

    }
}
