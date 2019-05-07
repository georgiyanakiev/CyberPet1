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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CyberPet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button a = (Button)sender;
            if (sender.Equals(this.button))
                MessageBox.Show("I couldn't be any happier!");
        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (sender.Equals(this.button1))
                MessageBox.Show("I'm stuffed!  I can't eat another bite!");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Button c = (Button)sender;
            if (sender.Equals(this.button2))
                MessageBox.Show("Hey! I'm down here. Play with me!");
        }
    }
    }

