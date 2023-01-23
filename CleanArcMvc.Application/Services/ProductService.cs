using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CleanArcMvc.Application.DTOs;
using CleanArcMvc.Application.Interfaces;
using CleanArcMvc.Domain.Entities;
using CleanArcMvc.Domain.Interfaces;

namespace CleanArcMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(product);            
        }

        public async Task<ProductDTO> GetByCategoryId(int? id)
        {
            var product = await _productRepository.GetByCategoryIdAsync(id);
            return _mapper.Map<ProductDTO>(product);            
        }

        public async Task Add(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.AddAsync(product);
        }

        public async Task Update(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.UpdateAsync(product);
        }

        public async Task Remove(int? id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            await _productRepository.RemoveAsync(product);                    
       }
   }
}