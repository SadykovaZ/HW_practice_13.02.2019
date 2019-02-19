using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_practice_13._02._2019.Request;
namespace HW_practice_13._02._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Товары в наличие: ");
            Sales s = new Sales(1,"Table",5,500,true);
            s.Print();
            Console.WriteLine("");
            Console.WriteLine("Осталось на складе: ");
            Stored st = new Stored(1, "Table", 3, 500, true, 2);
            st.Print();
            Console.WriteLine("");
            Console.WriteLine("Перемещено товара");
            Moving m = new Moving(1, "Table", 2, "Shop");
            m.Print();
            Console.WriteLine("");
            Console.WriteLine("Получено товара: ");
            GoodReceipt gr = new GoodReceipt(1, "Table", 3, 400.5);
            gr.Print();

        }
    }
}
