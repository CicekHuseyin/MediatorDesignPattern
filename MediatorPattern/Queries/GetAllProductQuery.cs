using InspimoMediatorDesignPattern.MediatorPattern.Results;
using MediatR;

namespace InspimoMediatorDesignPattern.MediatorPattern.Queries
{
    public class GetAllProductQuery : IRequest<List<GetAllProductQueryResult>>
    {

    }
}
