using System;
using System.Threading;

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
            
            int wood = 1000000;// Колличесто дерева.
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

                if (wood >= 1000000)
                {
                    Console.WriteLine("готовы заплатить залог за своё особождение в размере - 1000000?");
                    Console.WriteLine("Для покупки введите '/yes' ");

                    string answer = Console.ReadLine();
                    if (answer == "/yes")
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("...");
            Console.WriteLine("Неужели у тебя хватило терпения выбраться из заточения?...");
            Thread.Sleep(2500);
            Console.WriteLine("Поздравляю! Но ты серавно не уйдёшь отсюда раз забрался так далеко!");
            Thread.Sleep(2500);
            Console.WriteLine("Ты назначен на каторжные работы и должен добывать камень.");
            Console.WriteLine("Но раз ты такой работяга будем платить тебе 1$ в день)");
            Console.WriteLine($"Удачи не умереть... {Name}...");
            Thread.Sleep(3000);
            Console.Clear();
            Thread.Sleep(3000);
            Console.WriteLine("Загрузка уровня...");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Загрузка 1/3");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Загрузка 2/3");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Загрузка 3/3");
            Thread.Sleep(1500);
            Console.Clear();

            int cash = 0;
            int heals = 100;
            int rock = 0;
            int dead = 0;

            while (true)
            {
                Console.WriteLine($"Ваш Капитал составляет - {cash}.");
                Console.WriteLine($"Уровень здоровья - {heals}.");
                Console.WriteLine($"Колличество добытых камней - {rock}.");
                Console.WriteLine("Чтоб добыть камень введите '/has'. ");
                Console.WriteLine($"Чтоб подличиться введите '/help'. Стоимость - 8");
                string commannd = Console.ReadLine();

                if (commannd == "/has")
                {
                    rock++;
                    cash++;
                    if (cash % 3 == 0)
                    {
                        heals--;
                    }
                    Console.Clear();
                }
                else if (commannd == "/help" && cash >= 20)
                {
                    heals += 5;
                    cash -= 8;
                    dead++;

                    Console.Clear();
                    Console.WriteLine("Вы выглядите подозрительно...");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Комманда введена не верно.");
                }
                if (heals <= 0)
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("К сожалению вы умерли на каторге...");//Конец игры.
            Console.WriteLine("У вас не было и шанса...");
            Console.WriteLine("Спасибо что сыграли в мою игру. Создатель - Zifir0k.");
            Console.WriteLine("Я только учусь!");
        }
    }
}
