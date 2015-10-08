using System;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DuckHunt
{
    internal class AliveDuck : DuckState
    {
        private Duck duck;

        public AliveDuck(Duck duck)
        {
            this.duck = duck;
        }

        public void getShot()
        {
            duck.setDuckState(duck.getShotDuck());
            Rectangle rect = duck.getRect();
            rect.Fill = Brushes.Maroon;
        }
    }
}