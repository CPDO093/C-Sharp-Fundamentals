using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Morning_Challenge.NewFolder1
{
    public class OrdersRepo
    {

        protected readonly List<Order> _orderDirect = new List<Order>();
        //create and add order
        //get all orders
        // remove (delet)
        //print contnets

        //crud - u

        //crate
        public bool AddOrderToDirect(Order order)
        {
            //order number (count)
            int startingCount = _orderDirect.Count();
            if (!OrderIDAlreadyExisit(order.OrderNumber))
            {
                _orderDirect.Add(order);
            }
            _orderDirect.Add(order);
            //customer name
            bool wasAdded = (_orderDirect.Count() > startingCount) ? true : false;
            return wasAdded;
        }
        public bool OrderIDAlreadyExisit(int id)
        {
            foreach (var exisitingOrders in _orderDirect)
            {
                if (exisitingOrders.OrderNumber == id)
                {
                    return true;
                }
            }
            return false;
        }

        //read
        public List<Order> GetOrders()
        {
            return _orderDirect;

        }
        // get orders by type
        

        //delete
        public bool RemoveOrder(Order order)
        {
            bool result = _orderDirect.Remove(order);
            return result;
        }



    }
}
