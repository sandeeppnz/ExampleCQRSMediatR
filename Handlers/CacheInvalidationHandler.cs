using ExampleCQRSMediatR.Notifications;
using MediatR;

namespace ExampleCQRSMediatR.Handlers
{
    public class CacheInvalidationHandler : INotificationHandler<ProductCreatedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;
        public CacheInvalidationHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task Handle(ProductCreatedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccurred(notification.Product, "Cache Invalidated");
            await Task.CompletedTask;
        }
    }
}
