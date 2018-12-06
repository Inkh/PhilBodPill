using Microsoft.EntityFrameworkCore;
using PhilBodPill.Data;
using PhilBodPill.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models.Services
{
    public class OrderService : IOrder
    {
        private PhilBodPillDbContext _context;

        public OrderService(PhilBodPillDbContext context)
        {
            _context = context;
        }

        public async Task CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task<Order> GetOrder(int id)
        {
            return await _context.Orders.FirstOrDefaultAsync(o => o.ID == id);
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await _context.Orders.OrderByDescending(o => o.ID).Take(10).ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetOrdersByUser(string userID)
        {
            return await _context.Orders.Where(o => o.UserID == userID).OrderByDescending(o => o.ID).Take(5).ToListAsync();
        }
    }
}
