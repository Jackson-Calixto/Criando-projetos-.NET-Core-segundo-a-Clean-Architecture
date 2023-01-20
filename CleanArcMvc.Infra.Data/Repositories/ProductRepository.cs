using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArcMvc.Domain.Entities;
using CleanArcMvc.Domain.Interfaces;
using CleanArcMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArcMvc.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _productContext;
        public ProductRepository(ApplicationDbContext productContext)
        {
            _productContext = productContext;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _productContext.Products.Add(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetByCategoryIdAsync(int? id)
        {
            return await _productContext.Products.FirstOrDefaultAsync(p => p.CategoryId == id);
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return await _productContext.Products.FirstOrDefaultAsync(p => p.Id == id);            
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productContext.Products.ToListAsync();
        }

        public async Task<Product> RemoveAsync(Product product)
        {
            _productContext.Products.Remove(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _productContext.Update(product);
            await _productContext.SaveChangesAsync();
            return product;
        }
    }
}
