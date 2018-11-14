using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models.Interfaces
{
    public interface IInventory
    {
        //Create
        Task CreateProduct(Product product);

        //Update
        Task UpdateProduct(Product product);

        //Delete
        Task DeleteProduct(int id);

        //Read all
        Task<IEnumerable<Product>> GetProducts();

        //Read one
        Task<Product> GetProduct(int? id);
    }
}
