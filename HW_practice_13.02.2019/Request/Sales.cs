using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_practice_13._02._2019.Request
{
    public class Sales
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public double ProductPrice { get; set; }
        public bool Availability { get; set; }


        public Sales()
        {

        }
        public Sales(int Id, string Name, int Count, double Price, bool Avail)
        {
            this.ProductId = Id;
            this.ProductName = Name;
            this.ProductCount = Count;
            this.ProductPrice = Price;
            this.Availability = Avail;
        }
        public virtual void Print()
        {
            Console.WriteLine("ID: {0}\nName:{1}\nCount:{2}\nPrice:{3}\nAvailability:{4}",ProductId, ProductName,ProductCount,ProductPrice,Availability);
            
        }
    }
}
