using System;
using System.Windows;

namespace MinimalResizeIssue
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= Window_Loaded;
            _mediaElement.Source = new Uri("Content/bbb_sunflower_1080p_30fps_normal_EDIT.mp4", UriKind.Relative);
        }

        private void _mediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            _mediaElement.UnloadedBehavior = System.Windows.Controls.MediaState.Manual;
            _mediaElement.Position = TimeSpan.Zero;

            _mediaElement.Play();
        }
    }
}
