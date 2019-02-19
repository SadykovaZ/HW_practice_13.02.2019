using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_practice_13._02._2019.Request
{
    public class GoodReceipt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public GoodReceipt()
        { }

        public GoodReceipt(int Id, string Name, int Count, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Count = Count;
            this.Price = Price;
        }

        public void Print()
        {
            Console.WriteLine("Id: {0}\nName: {1}\nCount: {2}\nPrice: {3}", Id, Name, Count, Price);
        }

    }
}
