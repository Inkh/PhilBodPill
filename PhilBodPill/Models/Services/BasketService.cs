using Microsoft.EntityFrameworkCore;
using PhilBodPill.Data;
using PhilBodPill.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models.Services
{
    public class BasketService : IBasket
    {
        private PhilBodPillDbContext _context;

        public BasketService(PhilBodPillDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new Basket Object when user adds something to their cart
        /// </summary>
        /// <param name="basket">The instance of Basket to be created</param>
        /// <returns>Nothing, creates new basket into database table</returns>
        public async Task CreateBasket(Basket basket)
        {
            _context.Basket.Add(basket);
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// Updates a basket when the user updates the quantity
        /// </summary>
        /// <param name="id">Id of the basket to be updated</param>
        /// <param name="quantity">The new quantity the basket will be updated with</param>
        /// <returns>Nothing, updates the basket in databse table</returns>
        public async Task UpdateBasket(int id, int quantity)
        {
            Basket basket = await GetOneBasket(id);
            basket.Quantity = quantity;
            _context.Basket.Update(basket);
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// Removes one basket object from the database
        /// </summary>
        /// <param name="id">The ide of the basket to be deleted</param>
        /// <returns>Nothing, deletes the basket from the database</returns>
        public async Task DeleteBasket(int id)
        {
            Basket basket = await GetOneBasket(id);
            _context.Basket.Remove(basket);
        }

        public async Task<IEnumerable<Basket>> GetAllByUserID(string userID)
        {
            return await _context.Basket.Include(b => b.Product).Where(x => x.UserID == userID).ToListAsync();
        }

        public async Task<Basket> GetOneBasket(int id)
        {
            return await _context.Basket.FirstOrDefaultAsync(b => b.ID == id);
        }
    }
}
