using MediatR;

namespace InspimoMediatorDesignPattern.MediatorPattern.Commands
{
    public class UpdateProductCommand : IRequest
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCategory { get; set; }
    }
}
