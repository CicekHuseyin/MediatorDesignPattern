using InspimoMediatorDesignPattern.DAL;
using InspimoMediatorDesignPattern.MediatorPattern.Commands;
using MediatR;

namespace InspimoMediatorDesignPattern.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProdutCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProdutCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductCategory = request.ProductCategory,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock
            });
            await _context.SaveChangesAsync();
        }
    }
}
