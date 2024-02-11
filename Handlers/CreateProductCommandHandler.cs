using ExampleCQRSMediatR.Commands;
using MediatR;

namespace ExampleCQRSMediatR.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly FakeDataStore _fakeDataStore;

        public CreateProductCommandHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.CreateProduct(request.Product);
            return request.Product;
        }
    }
}
