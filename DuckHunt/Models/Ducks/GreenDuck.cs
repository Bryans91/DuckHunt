using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DuckHunt
{
    class GreenDuck : Duck
    {

        public GreenDuck(MainWindow window, int top, DuckController controller) : base(window, top, controller)
        {
            this.window = window;
            this.top = top;
            this.controller = controller;
        }

        public override Rectangle drawRect()
        {
            this.rect = new Rectangle
            {
                Fill = Brushes.MediumAquamarine,
                Width = size,
                Height = size,
                Cursor = Cursors.Hand
            };
            rect.MouseLeftButtonDown += getShot;
            window.canvas.Children.Add(rect);
            return rect;
        }

        public override void getShot(object sender, RoutedEventArgs e)
        {
            Rectangle rect = sender as Rectangle;
            setNextDuckState(rect);
        }

    }
}
