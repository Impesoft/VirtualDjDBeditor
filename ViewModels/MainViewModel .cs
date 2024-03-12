using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;
using VirtualDjDBeditor.Models;
using VirtualDjDBeditor.Commands;
using System.Windows.Input;

namespace VirtualDjDBeditor.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand SelectDatabaseCommand { get; }
        public ICommand FindAndReplaceCommand { get; }


        private ObservableCollection<Song>? _songs;
        public ObservableCollection<Song> Songs
        {
            get => _songs ?? new();
            set
            {
                if (_songs != value)
                {
                    _songs = value;
                    OnPropertyChanged(nameof(Songs));
                }
            }
        }

        public MainViewModel()
        {
            Songs = new ObservableCollection<Song>();
            SelectDatabaseCommand = new RelayCommand(SelectDatabase);
            FindAndReplaceCommand = new RelayCommand(FindAndReplace);
        }

        private void FindAndReplace()
        {
            throw new NotImplementedException();
        }

        public void LoadSongs(string filePath)
        {
            var serializer = new XmlSerializer(typeof(VirtualDJDatabase));
            using (var reader = new StreamReader(filePath))
            {
                var database = (VirtualDJDatabase)(serializer.Deserialize(reader) ?? new VirtualDJDatabase());
                Songs.Clear();
                int index = 1;
                foreach (var song in database.Songs)
                {
                    song.Index = index++;
                    Songs.Add(song);
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SelectDatabase()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Database Files (*.xml)|*.xml",
                InitialDirectory = "C:\\Users\\ward\\Documents\\VirtualDJ"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                LoadSongs(openFileDialog.FileName);
            }
        }
    }
}
