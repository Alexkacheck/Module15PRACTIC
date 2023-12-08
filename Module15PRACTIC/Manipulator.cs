using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Module15PRACTIC
{
    public class Manipulator
    {
        public static void CreateInstanceWithoutConstructor()
        {
            // Создание экземпляра без вызова конструктора
            MyClass instance = (MyClass)Activator.CreateInstance(typeof(MyClass));

            // Манипуляции с объектом
            instance.PublicProperty = 42;
            Console.WriteLine($"Измененное значение свойства: {instance.PublicProperty}");

            // Вызов приватного метода с помощью рефлексии
            MethodInfo privateMethod = typeof(MyClass).GetMethod("частный метод", BindingFlags.NonPublic | BindingFlags.Instance);
            privateMethod.Invoke(instance, null);

            // Вызов публичного метода
            instance.PublicMethod();
        }
    }
}
