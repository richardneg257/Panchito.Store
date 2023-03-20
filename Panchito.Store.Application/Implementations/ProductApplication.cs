using AutoMapper;
using Panchito.Store.Application.Dtos;
using Panchito.Store.Application.Interfaces;
using Panchito.Store.Repository.Interfaces;

namespace Panchito.Store.Application.Implementations
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductApplication(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var products = await _productRepository.GetProductsAsync();

            var productsDto = _mapper.Map<List<ProductDto>>(products);
            return productsDto;
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);

            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }
    }
}
