using Microsoft.EntityFrameworkCore;
using PhilBodPill.Data;
using PhilBodPill.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models.Services
{
    public class ProductService : IInventory
    {
        private PhilBodPillDbContext _context;

        public ProductService(PhilBodPillDbContext context)
        {
            _context = context;
        }

        public async Task CreateProduct(Product product)
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            Product product = await GetProduct(id);
            _context.Product.Remove(product);

            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProduct(int? id)
        {
            return await _context.Product.FirstOrDefaultAsync(p => p.ID == id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Product.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
