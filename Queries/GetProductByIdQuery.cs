using MediatR;

namespace ExampleCQRSMediatR.Queries
{
    public record  GetProductByIdQuery(int Id) : IRequest<Product>;
}
