using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public class Order : IInteraction
    {
        public int Number { get; set; }
        public string Status { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Order(int number, string status)
        {
            throw new NotImplementedException();
        }

        public void AddPizza(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
