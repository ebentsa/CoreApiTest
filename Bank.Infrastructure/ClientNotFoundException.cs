namespace Bank.Infrastructure
{
    public class ClientNotFoundException : InfrastructureException
    {
        internal ClientNotFoundException(string message) : base(message) { }
    }
}
