using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ScheduleTracker.ViewModels;

namespace ScheduleTracker.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
