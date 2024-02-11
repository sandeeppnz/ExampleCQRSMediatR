using MediatR;

namespace ExampleCQRSMediatR.Queries
{
    public record GetProductsQuery(): IRequest<IEnumerable<Product>>;
}
