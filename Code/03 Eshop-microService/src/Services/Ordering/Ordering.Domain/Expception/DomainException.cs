namespace Ordering.Domain.Expception
{
    public class DomainException:Exception
    {
        public DomainException(string message):base($"Domain Exception: \"{message}\" throws from Domain layer")
        {
            
        }
    }
}
