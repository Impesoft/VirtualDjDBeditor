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

        private void Select_Database(object sender, RoutedEventArgs e)
        {
            ViewModel?.SelectDatabase();
            SelectDB.Content = "Database Selected"; // Update as needed
        }
    }
}
