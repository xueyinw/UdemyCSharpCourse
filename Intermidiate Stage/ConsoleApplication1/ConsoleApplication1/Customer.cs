using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Customer
    {
        public string Name;
        public int Id;
        public readonly List<string> Orders;

        public Customer()
        {
            Orders = new List<string>(); //this is very important to avoid null reference exception
        }

        public Customer(int id) : this()  //call default first, then we could initialize the Orders list.
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id) //call the second Constructor first, then we could remove redundancy
        {
            this.Name = name;
        }
    }
}
