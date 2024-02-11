using MediatR;

namespace ExampleCQRSMediatR.Commands
{
    public record CreateProductCommand(Product Product): IRequest<Product>;
}
