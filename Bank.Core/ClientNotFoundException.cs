namespace Bank.Core
{
    public class ClientNotFoundException : CoreException
    {
        internal ClientNotFoundException(string message) : base(message) { }
    }
}
