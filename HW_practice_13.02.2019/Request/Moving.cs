using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_practice_13._02._2019.Request
{
    public class Moving
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string PlaceMoved { get; set; }

        public Moving()
        { }

        public Moving(int Id, string Name, int Count, string PlaceMoved)
        {
            this.Id = Id;
            this.Name = Name;
            this.Count = Count;
            this.PlaceMoved = PlaceMoved;
        }

        public void Print()
        {
            Console.WriteLine("Id: {0}\nName: {1}\nCount: {2}\nPlace Moved: {3}", Id,Name,Count,PlaceMoved);
        }
    }
}
