using ExampleCQRSMediatR.Notifications;
using MediatR;

namespace ExampleCQRSMediatR.Handlers
{
    public class EmailHandler : INotificationHandler<ProductCreatedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;

        public EmailHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task Handle(ProductCreatedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccurred(notification.Product, "Email Sent");
            await Task.CompletedTask;
        }
    }
}
