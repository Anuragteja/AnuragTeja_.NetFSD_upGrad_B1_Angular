using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment
{
    public class Order
    {
        public int OrderId { get; set; }
        public double OrderAmount { get; set; }

        public virtual void CalculateShippingCost()
        {
            Console.WriteLine("Shipping Cost: 50");
        }
    }

    public class StandardOrder : Order
    {
        public override void CalculateShippingCost()
        {
            Console.WriteLine("Standard Order Shipping Cost: 50");
        }
    }

    public class ExpressOrder : Order
    {
        public override void CalculateShippingCost()
        {
            Console.WriteLine("Express Order Shipping Cost: 100");
        }
    }

    public class InternationalOrder : Order
    {
        public override void CalculateShippingCost()
        {
            Console.WriteLine("International Order Shipping Cost: 500");
        }
    }
    internal class E_Commerce_Order_System
    {
        static void Main(string[] args)
        {
            Order[] orders = new Order[3];

            orders[0] = new StandardOrder();
            orders[1] = new ExpressOrder();
            orders[2] = new InternationalOrder();

            for (int i = 0; i < orders.Length; i++)
            {
                orders[i].CalculateShippingCost();
            }
        }
    }
}
