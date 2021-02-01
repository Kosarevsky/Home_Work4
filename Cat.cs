using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public delegate void EventDelegate(string a);

    public class Cat
    {
        //Событие можно обьявлять только в нестатическом классе
        public event EventDelegate ShowMessageEvent;

        public void WakeUpEvent(string a)
        {
            //Делаем проверку что у события есть подписчик
            //и вызываем событие
            ShowMessageEvent?.Invoke(a);
        }
    }
}
