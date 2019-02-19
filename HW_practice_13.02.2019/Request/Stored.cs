using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_practice_13._02._2019.Request
{
    public class Stored:Sales
    {
        public int LeftCount { get; set; }
        public Stored(int Id, string Name, int Count, double Price, bool Avail, int LeftP) : base( Id, Name, Count, Price, Avail)
        {
            this.LeftCount = LeftP;
        }
        public override void Print()
        {
            Console.WriteLine("ID: {0}\nName:{1}\nCount:{2}\nPrice:{3}\nAvailability:{4}\nLeft Product:{5}", ProductId, ProductName, ProductCount, ProductPrice, Availability,LeftCount);

        }

    }
}
