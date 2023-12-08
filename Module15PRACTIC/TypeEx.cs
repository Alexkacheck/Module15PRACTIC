using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Module15PRACTIC
{
    public class TypeEx
    {
        public static void ExType(Type type)
        {
            // Имя класса
            Console.WriteLine($"Имя класса: {type.Name}");

            // Конструкторы
            Console.WriteLine("\nКонструкторы:");
            foreach (var constructor in type.GetConstructors())
            {
                Console.WriteLine($"  {constructor}");
            }

            // Поля и свойства
            Console.WriteLine("\nПоля и свойства:");
            foreach (var member in type.GetMembers())
            {
                Console.WriteLine($"  {member}");
            }

            // Методы
            Console.WriteLine("\nМетоды:");
            foreach (var method in type.GetMethods())
            {
                Console.WriteLine($"  {method}");
            }
        }
    }
}
