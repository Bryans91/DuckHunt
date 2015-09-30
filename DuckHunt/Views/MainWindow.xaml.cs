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

        GameController c;

        public MainWindow()
        {
            InitializeComponent();
            c = new GameController(this);
        }

        private void dragable(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void closeGame(object sender, RoutedEventArgs e)
        {
            Dispatcher.CurrentDispatcher.Thread.Abort();
            this.Close();
        }

    }
}
