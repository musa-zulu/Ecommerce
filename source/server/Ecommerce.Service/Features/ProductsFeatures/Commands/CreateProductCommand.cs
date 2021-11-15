using AutoMapper;
using MediatR;
using Ecommerce.Domain.Entities;
using Ecommerce.Service.Contracts;
using System;
using System.Threading;
using System.Threading.Tasks;
using Ecommerce.Domain.Dtos.Product;

namespace Ecommerce.Service.Features.ProductsFeatures.Commands
{
    public class CreateProductCommand : IRequest<bool>
    {
        public AddOrEditProductDto ProductDto { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
        {
            private readonly IProductsService _productsService;
            private readonly IMapper _mapper;
            public CreateProductCommandHandler(IProductsService productsService, IMapper mapper)
            {
                _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
                _productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));
            }
            public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var product = _mapper.Map<Product>(request.ProductDto);
                product.ProductId = Guid.NewGuid();

                var prductSaved = false;
                if (product != null)
                {
                    var response = await _productsService.AddAsync(product);
                    prductSaved = response.Succeeded;
                }
                return prductSaved;
            }
        }
    }
}