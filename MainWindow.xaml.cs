using System.Windows;
using VirtualDjDBeditor.ViewModels;

namespace VirtualDjDBeditor
{
    public partial class MainWindow : Window
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
