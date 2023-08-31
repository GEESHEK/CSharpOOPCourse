using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        
        public Order Retrieve(int productId)
        {
            return new Order();
        }
        
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            
            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}