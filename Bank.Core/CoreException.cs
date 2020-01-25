using System;

namespace Bank.Core
{
    public class CoreException : Exception
    {
        internal CoreException(string businessMessage) : base(businessMessage) { }
    }
}
