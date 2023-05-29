using System;

namespace ListNamesSort
{
    class Program
    {
        static void Main()
        {
            // Вводим имена с клавиатуры и сохраняем их в списке
            List<string> names = new List<string>();

            Console.WriteLine("Введите имена (для завершения введите пустую строку):");
            string inputName;
            do
            {
                inputName = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputName))
                {
                    names.Add(inputName);
                }
            } while (!string.IsNullOrEmpty(inputName));

            // Сортируем список имен по алфавиту
            names.Sort();

            Console.WriteLine("Отсортированный по алфавиту список имен:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Вводим имя, которое нужно найти
            Console.WriteLine("Введите имя для поиска:");
            string searchName = Console.ReadLine();

            // Ищем имя в списке
            int index = names.BinarySearch(searchName);

            if (index >= 0)
            {
                // Имя найдено
                Console.WriteLine("Имя найдено в списке.");
            }
            else
            {
                // Имя не найдено
                Console.WriteLine("0");
            }

            Console.ReadLine();
        }
    }
}