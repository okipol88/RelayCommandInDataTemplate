using System;
using System.Windows.Input;

namespace RelayCommandInDataTemplate.Helpers
{
    public class SimpleRelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute;
        private readonly Func<T, bool> _canExecute;

        public event EventHandler? CanExecuteChanged;

        public SimpleRelayCommand(Action<T> execute, Func<T, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            if (parameter is not T t)
            {
                return false;
            }

            return _canExecute?.Invoke(t) ?? true;
        }

        public void Execute(object? parameter)
        {
        }
    }
}
