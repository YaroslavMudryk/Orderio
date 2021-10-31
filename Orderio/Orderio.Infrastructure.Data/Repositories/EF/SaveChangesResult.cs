using System;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class SaveChangesResult
    {
        public bool Success => Exception == null;
        public Exception Exception { get; private set; }
        public void AddException(Exception ex) => Exception = ex;
    }
}
