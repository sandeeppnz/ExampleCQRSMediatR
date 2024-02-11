using MediatR;

namespace ExampleCQRSMediatR.Notifications
{
    public record ProductCreatedNotification(Product Product) : INotification;
}
