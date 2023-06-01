using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunstroctor
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer() //default or empty constructor.
        {
            Orders = new List<Order>();
        }

        //parametrize constructor.
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
            this.Id = id;
        }

    }
}
