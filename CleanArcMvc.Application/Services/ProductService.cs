using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CleanArcMvc.Application.DTOs;
using CleanArcMvc.Application.Interfaces;
using CleanArcMvc.Application.Products.Queries;
using CleanArcMvc.Domain.Entities;
using CleanArcMvc.Domain.Interfaces;
using MediatR;

namespace CleanArcMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ProductService(IMapper mapper, IMediator mediator) 
        {            
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsQuery = new GetProductsQuery();

            if (productsQuery == null)
                throw new Exception($"Entity could not be loaded.");
            
            var result = await _mediator.Send(productsQuery);

            return _mapper.Map<IEnumerable<ProductDTO>>(result);
        }

    //     public async Task<ProductDTO> GetById(int? id)
    //     {
    //         var product = await _productRepository.GetByIdAsync(id);
    //         return _mapper.Map<ProductDTO>(product);            
    //     }

    //     public async Task<ProductDTO> GetByCategoryId(int? id)
    //     {
    //         var product = await _productRepository.GetByCategoryIdAsync(id);
    //         return _mapper.Map<ProductDTO>(product);            
    //     }

    //     public async Task Add(ProductDTO productDto)
    //     {
    //         var product = _mapper.Map<Product>(productDto);
    //         await _productRepository.AddAsync(product);
    //     }

    //     public async Task Update(ProductDTO productDto)
    //     {
    //         var product = _mapper.Map<Product>(productDto);
    //         await _productRepository.UpdateAsync(product);
    //     }

    //     public async Task Remove(int? id)
    //     {
    //         var product = await _productRepository.GetByIdAsync(id);
    //         await _productRepository.RemoveAsync(product);                    
    //    }
   }
}