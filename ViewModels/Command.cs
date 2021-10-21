using System;
using System.Windows.Input;

namespace WpfApp1.ViewModels
{
    class Command : ICommand
    {
        private Action<object> action;
        private Func<object, bool> Func;

        public Command(Action<object> action, Func<object, bool> func)
        {
            this.action = action;
            Func = func;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action.Invoke(parameter);
        }
    }
}
