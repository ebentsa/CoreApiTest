namespace Bank.Infrastructure
{
    public class CompanyNotFoundException : InfrastructureException
    {
        internal CompanyNotFoundException(string message) : base(message) { }
    }
}
