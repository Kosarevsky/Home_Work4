using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        delegate Animal Delegate1();

        static void Main(string[] args)
        {
            Delegate1 delegate1 = Method2;
            delegate1?.Invoke().delegate2?.Invoke();


            GenericDelegate.ExampleGeneric();

            //Создаем экземпляр класса издателя события
            Cat publisher = new Cat();
            //Создаем экземпляр делегата
            EventDelegate eventDelegate = new EventDelegate(SendMessageHandler);
            
            //Подписываемся на событие с помощью "+="
            publisher.ShowMessageEvent += eventDelegate;

            EventDelegate eventDelegateDog = new EventDelegate(Dog.DogWakeUpHandler);
            publisher.ShowMessageEvent += eventDelegateDog;

            EventDelegate eventDelegateMouse = new EventDelegate(Mouse.MouseWakeUpHandler);
            publisher.ShowMessageEvent += eventDelegateMouse;

            EventDelegate eventDelegateHuman = new EventDelegate(Human.HumanWakeUpHandler);
            publisher.ShowMessageEvent += eventDelegateHuman;

            //Используем метод издателя для вызова события
            publisher.WakeUpEvent("Cat Said Wake Up!");


            Console.ReadLine();
        }
        private static void SendMessageHandler(string a)
        {
            Console.WriteLine($"Message body: {a}");
        }

        private static Animal Method2()
        {
            return new Animal();
        }

    }


}

