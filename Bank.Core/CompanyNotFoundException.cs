namespace Bank.Core
{
    public class CompanyNotFoundException : CoreException
    {
        internal CompanyNotFoundException(string message) : base(message) { }
    }
}
