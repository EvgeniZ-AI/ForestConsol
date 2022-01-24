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
            
            int wood = 10000;// Колличесто дерева.
            int axe = 1;// Уровень топора.

            int priceAxeSharp = 100; // Цена заточки топора.
            int priceAxeCover = 1000; // Цена нового покрытия топора.
            int priceAxeGrip = 10000; // Цена новой рукоятки топора.

            var axeShop = new Shop();
            while (true)
            {
                Console.WriteLine("Для рубки дерева используйте команду '/has' ");
                Console.WriteLine("Для того чтоб войти в магазин введите /shop");
                Console.WriteLine("Ожидается команда...");
                string EnterCommand = Console.ReadLine();
                if (EnterCommand == "/has")
                {
                    Console.Clear();
                    wood += axe;
                    Console.WriteLine($"Вы получили {axe} дерево");
                }
                else if (EnterCommand == "/shop")
                {
                    Console.Clear();

                    Console.WriteLine("Добро пожаловать в магазин.");

                    Console.WriteLine($"чтоб заточить топор введите '/sharp'. Стоимость - {priceAxeSharp}.");
                    Console.WriteLine($"Для новго покрытия топора введите '/cover'. Стоимость - {priceAxeCover}");
                    Console.WriteLine($"Для новой рукоятки введите '/grip'. Стоимость - {priceAxeGrip}");

                    string enterShop = Console.ReadLine();

                    if (enterShop == "/sharp")
                    {
                        axe = axeShop.Buy(ref priceAxeSharp, ref wood, axe, 1);
                    }
                    else if (enterShop == "/cover")
                    {
                        axe = axeShop.Buy(ref priceAxeCover, ref wood, axe, 5);
                    }
                    else if (enterShop == "/grip")
                    {
                        axe = axeShop.Buy(ref priceAxeGrip, ref wood, axe, 15);
                    }
                    else
                    {
                        Console.WriteLine("Произошла ошибка.");
                    }

                    Console.Clear();
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
