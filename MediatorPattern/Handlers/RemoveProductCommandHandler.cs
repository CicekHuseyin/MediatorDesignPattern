using InspimoMediatorDesignPattern.DAL;
using InspimoMediatorDesignPattern.MediatorPattern.Commands;
using MediatR;

namespace InspimoMediatorDesignPattern.MediatorPattern.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.Id);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();

        }
    }
}
