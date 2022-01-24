using System;

namespace ForestConsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя...");
            string Name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Добро пожаловать в систему {Name} ");

            Console.WriteLine("Вы назначены на должность рубки леса.");
            Console.WriteLine("Для рубки дерева используйте команду '/has' ");
            Console.WriteLine("Для того чтоб войти в магазин введите /shop");

            int wood = 10000;// Колличесто дерева.
            int axe = 1;// Уровень топора.

            int priceAxeSharpening = 100;

            while (true)
            {
                Console.WriteLine("Ожидается команда...");
                string EnterCommand = Console.ReadLine();
                if (EnterCommand == "/has")
                {
                    wood += axe;
                    Console.WriteLine("Вы получили 1 дерево");
                }
                else if (EnterCommand == "/shop")
                {
                    Console.WriteLine($"чтоб заточить топор введите '/sharp'. Стоимость - {priceAxeSharpening}.");

                    string enterShop = Console.ReadLine();

                    if (enterShop == "/sharp") // Тут ошибка(((
                    {
                        if (wood >= priceAxeSharpening)
                        {
                            axe++;
                            wood += priceAxeSharpening;
                            Console.WriteLine("Заточка произведена!");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Введена не верная команда...");
                }
                Console.WriteLine($"Колличество дерева : {wood}");
            }
        }
    }
}
