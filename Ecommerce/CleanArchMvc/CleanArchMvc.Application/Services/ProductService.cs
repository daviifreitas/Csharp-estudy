using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Application.Products.Queries;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using MediatR;

namespace CleanArchMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IMediator _mediator; 
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task Add(ProductDTO productDTO)
        {
            var productCreateCommand = _mapper.Map<ProductCreateCommand>(productDTO);
            await _mediator.Send(productCreateCommand);
        }
        public async Task<ProductDTO> GetById(int? id)
        {
            if (id != null)
            {
                var getProductByIdQuery = new GetProductByIdQuery(id.Value);

                if (getProductByIdQuery != null)
                {
                    var product = await _mediator.Send(getProductByIdQuery);
                    return _mapper.Map<ProductDTO>(product);
                }

                else
                {
                    throw new ApplicationException("Error , don't exist product id");
                }
            }
            else
            {
                throw new ApplicationException("Error ,id value is null");
            }

        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsQuery = new GetProductsQuery();

            if (productsQuery == null)
                throw new ApplicationException("Error in entity load");

            var result = await _mediator.Send(productsQuery);

            return _mapper.Map<IEnumerable<ProductDTO>>(result);
        }

        public async Task Remove(int? id)
        {
            var productRemoveCommand = new ProductRemoveCommand(id.Value);

            if (productRemoveCommand != null)
            {
                await _mediator.Send(productRemoveCommand);
            }
            else
            {
                throw new ApplicationException(message: "Error to remove product ");
            }
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productUpdateCommand = _mapper.Map<ProductUpdateCommand>(productDTO);
            await _mediator.Send(productUpdateCommand);
        }
    }
}
