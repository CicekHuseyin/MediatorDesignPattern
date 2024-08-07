using InspimoMediatorDesignPattern.MediatorPattern.Results;
using MediatR;

namespace InspimoMediatorDesignPattern.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery:IRequest<GetUpdateProductByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
