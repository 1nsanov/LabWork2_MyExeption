using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Magazine
    {
        private int Count { get; set; }
        private int Price { get; set; }

        public Magazine(int count, int price)
        {
            if (count <= 0)
            {
                throw new MagazineException();
            }
            if (price <= 0)
            {
                throw new Exception();
            }
            Count = count;
            Price = price;
        }

        public int TotalPrice()
        {
            return Count * Price;
        }

        public override string ToString()
        {
            return $"Тираж: {Count} шт. | Цена за одну шт.: {Price}$ | Общая цена: {TotalPrice()}$";
        }
    }
}

