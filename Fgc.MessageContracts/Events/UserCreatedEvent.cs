namespace Fgc.MessageContracts.Events
{
    public record UserCreatedEvent(Guid Id, string Name, string Email, DateTime CreatedAt);
}
