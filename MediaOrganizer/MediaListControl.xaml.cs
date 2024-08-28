using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MediaOrganizer
{
    /// <summary>
    /// Interaction logic for MediaListControl.xaml
    /// </summary>
    public partial class MediaListControl : UserControl
    {
        public ObservableCollection<MediaItem> MediaItems { get; set; }
        public string MediaType { get; set; }

        public MediaListControl()
        {
            InitializeComponent();
            MediaItems = new ObservableCollection<MediaItem>();
            DataContext = this;

            if (MediaType == "Video")
                MediaItems.Add(new MediaItem { Name = "Video.mp4" });
            else if (MediaType == "Music")
                MediaItems.Add(new MediaItem { Name = "Music.mp3" });
            else if (MediaType == "Web")
                MediaItems.Add(new MediaItem { Name = "Website1" });
        }
    }
    public class MediaItem
    {
        public string Name { get; set; }
    }
}
