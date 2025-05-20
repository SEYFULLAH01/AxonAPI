using AxonAPI.Application.Interfaces.AutoMapper;
using AxonAPI.Application.Interfaces.UnitOfWorks;
using AxonAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxonAPI.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public IMapper mapper { get; }
        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<Product, UpdateProductCommandRequest>(request);

            var productCategories = await unitOfWork.GetReadRepository<ProductCategory>()
                .GetAllAsync(x => x.ProductId == product.Id);

            await unitOfWork.GetWriteRepository<ProductCategory>()
                .HardDeleteRangeAsync(productCategories);

            foreach (var categoryId in request.CategoryIds)
                await unitOfWork.GetWriteRepository<ProductCategory>()
                    .AddAsync(new() { CategoryId = categoryId, ProductId = product.Id });

            await unitOfWork.GetWriteRepository<Product>().UpdateAsync(map);
            await unitOfWork.SaveAsync();
        }
    }
}
