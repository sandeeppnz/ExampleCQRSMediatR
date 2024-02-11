using ExampleCQRSMediatR.Queries;
using MediatR;

namespace ExampleCQRSMediatR.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private FakeDataStore _fakeDataStore;

        public GetProductByIdQueryHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            => await _fakeDataStore.GetProductById(request.Id);
    }


}
