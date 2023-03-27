using CleanArcMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Domain.Interfaces;

public interface IProductRepository
{
    //Task<> - Defines as Asynchronous
    //IEnumerable<> - Defines as List of one or more records
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetByIdAsync(int? id);
    //Task<Product> GetByCategoryIdAsync(int? id);
    Task<Product> AddAsync(Product product);
    Task<Product> UpdateAsync(Product product);
    Task<Product> RemoveAsync(Product product);
}
