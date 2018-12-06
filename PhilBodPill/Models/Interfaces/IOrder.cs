using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models.Interfaces
{
    public interface IOrder
    {
        //Create
        Task CreateOrder(Order order);

        //Get One
        Task<Order> GetOrder(int id);

        //Get All
        Task<IEnumerable<Order>> GetOrders();

        //Get All by UserID
        Task<IEnumerable<Order>> GetOrdersByUser(string userID);
    }
}
