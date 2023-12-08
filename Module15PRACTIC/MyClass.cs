using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15PRACTIC
{
    public class MyClass
    {
        public int PublicProperty { get; set; }
        private string PrivateField;

        public MyClass()
        {
            // Конструктор
        }

        public MyClass(int value)
        {
            // Конструктор с параметром
            PublicProperty = value;
        }

        private void PrivateMethod()
        {
            // Приватный метод
            Console.WriteLine("Вызываемый частный метод");
        }

        public void PublicMethod()
        {
            // Публичный метод
            Console.WriteLine("Вызываемый открытый метод");
        }
    }
}
