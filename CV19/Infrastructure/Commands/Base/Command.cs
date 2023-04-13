using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace CV19.Infrastructure.Commands.Base
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
