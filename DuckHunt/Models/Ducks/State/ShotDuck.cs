using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DuckHunt
{
    internal class ShotDuck : DuckState
    {
        private Duck duck;

        public ShotDuck(Duck duck)
        {
            this.duck = duck;
        }

        public void getShot()
        {
            duck.window.scoreInt.Content = Convert.ToInt32(duck.window.scoreInt.Content) + 100;
            Rectangle rect = duck.getRect();
            rect.Fill = Brushes.Black;
            duck.controller.reset();
            duck.setDuckState(duck.getDeadDuck());
        }
    }
}