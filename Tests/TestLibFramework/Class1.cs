using System;
using System.Windows.Input;

namespace TestLibFramework
{
    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parameter); //функция, которая возвращает либо истину либо ложь.
                                                           //Если ложь, то команду нельзя выполнить

        public abstract void Execute(object parameter); //то, что должно быть выполнено самой командой
    }
}
