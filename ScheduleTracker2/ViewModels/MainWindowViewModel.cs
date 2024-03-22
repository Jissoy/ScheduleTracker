using ReactiveUI;
using System.Reactive;
namespace ScheduleTracker.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _userName;
        public string UserName
        {
            get => _userName;
            set => this.RaiseAndSetIfChanged(ref _userName, value);
        }

        private string _greetingMessage;
        public string GreetingMessage
        {
            get => _greetingMessage;
            set => this.RaiseAndSetIfChanged(ref _greetingMessage, value);
        }

        public ReactiveCommand<Unit, Unit> GreetCommand { get; }

        public MainWindowViewModel()
        {
            GreetCommand = ReactiveCommand.Create(ShowGreeting);
        }

        private void ShowGreeting()
        {
            if (string.IsNullOrWhiteSpace(UserName))
            {
                GreetingMessage = "Witam!";
            }
            else
            {
                GreetingMessage = $"Witam, {UserName}!";
            }
        }
    }
}
