namespace Fgc.MessageContracts.Events
{
    public record UserCreatedEvent(
        Guid Id, 
        string Name, 
        string Email, 
        DateTime CreatedAt);

    public record OrderPlacedEvent(
        Guid OrderId, 
        Guid UserId, 
        Guid GameId, 
        decimal Price);

    public record PaymentProcessedEvent(
        Guid OrderedId,
        Guid UserId,
        Guid GameId,
        decimal Price,
        string Status,
        DateTime ProcessedAt);
}