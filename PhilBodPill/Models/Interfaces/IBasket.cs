using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models.Interfaces
{
    public interface IBasket
    {
        // Create (User has added to their cart)
        Task CreateBasket(Basket basket);

        // Update (User has updated the quantity of an item in their cart)
        Task UpdateBasket(int id, int quantity);

        // Delete (User has removed an item from their cart)
        Task DeleteBasket(int id);

        // Get All By User ID
        Task<IEnumerable<Basket>> GetAllByUserID(string userID);

        // Get One Basket
        Task<Basket> GetOneBasket(int? id);
    }
}