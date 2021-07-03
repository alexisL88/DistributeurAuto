using DistributeurAuto.Resources;
using System.Windows;

namespace DistributeurAuto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DrinksDispenser();
        }            
    }
}
