using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;
using System.Diagnostics;
using System.Windows.Threading;


namespace DuckHunt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        GameController controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = new GameController(this);
        }

        public Rectangle DrawRect(int x, int y,int w,int h)
        {
            Rectangle rect = new Rectangle
            {
                Fill = Brushes.Aqua,
                Width = w,
                Height = h,
                Cursor = Cursors.Hand
        };
            rect.MouseLeftButtonDown += getShot;
            replaceDuck(rect);
            canvas.Children.Add(rect);
            return rect;
        }


        public void moveRect(Rectangle rect, int velocity)
        {
            double pos = Canvas.GetLeft(rect);
            Canvas.SetLeft(rect, pos + velocity);

        }

        private void replaceDuck(Rectangle rect)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 550);
            int y = rnd.Next(1, 300);
            rect.Margin = new Thickness(x, y, 50, 50);
        }

        private void getShot(object sender, RoutedEventArgs e)
        {
            Rectangle rect = sender as Rectangle;
            replaceDuck(rect);
        }

    }
}
