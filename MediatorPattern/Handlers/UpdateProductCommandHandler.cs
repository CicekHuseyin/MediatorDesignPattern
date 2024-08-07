using InspimoMediatorDesignPattern.DAL;
using InspimoMediatorDesignPattern.MediatorPattern.Commands;
using MediatR;

namespace InspimoMediatorDesignPattern.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.ProductID);
            values.ProductName=request.ProductName;
            values.ProductPrice=request.ProductPrice;
            values.ProductStock=request.ProductStock;
            values.ProductCategory=request.ProductCategory;
            await _context.SaveChangesAsync();
        }
    }
}
