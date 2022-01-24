using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestConsol
{
    public class Shop
    {
        public int price { get; set; }
        public int wood { get; set; }

        public int Buy(ref int price, ref int wood, int axe, int add)
        {
            if (wood >= price)
            {
                wood -= price;

                price += (price % 2) + 5;

                Console.WriteLine("Успех!");

                return axe + add;
            }
            else
            {
                Console.WriteLine("Неудача(");

                return axe;
            }
        }

    }
}
