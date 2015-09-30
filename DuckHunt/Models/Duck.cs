using System;
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
    class Duck
    {

        MainWindow window;
        Rectangle rect;
        Dispatcher dispatcher;
        int left;
        int top;
        int size = 50;

        public Duck(MainWindow window)
        {
            this.window = window;
            dispatcher = Dispatcher.CurrentDispatcher;
        }

        public Rectangle DrawRect()
        {
            this.rect = new Rectangle
            {
                Fill = Brushes.PowderBlue,
                Width = size,
                Height = size,
                Cursor = Cursors.Hand
            };
            rect.MouseLeftButtonDown += getShot;
            restartDuck();
            window.canvas.Children.Add(rect);
            return rect;
        }

        public void moveRect(Rectangle rect, int velocity)
        {
            double pos = Canvas.GetLeft(rect);
            Canvas.SetLeft(rect, pos + velocity);
        }

        public void moveLeft()
        {
            this.left++;
            if (this.left > 750)
            {
                this.left = -size;
            }
            Thread.Sleep(4);
            if (this.dispatcher.CheckAccess())
            {
                rect.Margin = new Thickness(this.left, this.top, size, size);
            }
            else
            {
                this.dispatcher.Invoke(() => rect.Margin = new Thickness(this.left, this.top, size, size));
            }
        }

        private void restartDuck()
        {
            Random rnd = new Random();
            this.left = -size;
            this.top = rnd.Next(26, 300);
            rect.Margin = new Thickness(this.left, this.top, size, size);
        }

        private void getShot(object sender, RoutedEventArgs e)
        {
            Rectangle rect = sender as Rectangle;
            restartDuck();
        }
    }
}
