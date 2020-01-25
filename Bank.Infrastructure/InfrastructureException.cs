using System;

namespace Bank.Infrastructure
{
    public class InfrastructureException : Exception
    {
        internal InfrastructureException(string businessMessage) : base(businessMessage) { }
    }
}
