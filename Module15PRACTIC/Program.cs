using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15PRACTIC
{
    class Program
    {
        static void Main(string[] args)
        {

            // Исследование типа
            TypeEx.ExType(typeof(MyClass));

            // Создание экземпляра без вызова конструктора
            Manipulator.CreateInstanceWithoutConstructor();

            Console.ReadLine();
        }
    }
}
