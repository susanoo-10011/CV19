using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Анализ статистики CV19";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
            /*set
            {
                if (Equals(_Title, value)) return;
                _Title = value;
                OnPropertyChanged();
            }*/
        }

        /// <summary>Статус программы</summary>
        private string _Status = "Готов!";
        /// <summary>Статус программы</summary>
        public string Status
        {
            get => _Status; // просто возвращает значение поля 
            set => Set(ref _Status, value); //вызывает метод Set, который передает ссылку на поле _Status и значение, которое будет установленно(value)
        }

        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p) 
        {
            Application.Current.Shutdown();        
        } //метод выполняется когда команда выполняется

        private bool CanCloseApplicationCommandExecute(object p) => true; //команда доступна всегда

        #endregion

        #endregion
        public MainWindowViewModel()
        {
            #region

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion

        }

    }
}
