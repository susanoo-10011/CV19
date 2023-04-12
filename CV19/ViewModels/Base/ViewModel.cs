using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CV19.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged //интерфейс, способный уведомлять об изменении каких-либо свойств внутри объекта
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName)); //объект PropertyChangedEventArgs содержит информацию об измененном свойстве.
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null) //Set обновляет значения свойства T
                                                                                                           //ref T field ссылка на поле свойства
                                                                                                           //T value новое значение
        {
            if(Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName); 
            return true;
        }
    }
}
