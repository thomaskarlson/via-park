using System.Collections.Generic;

namespace Park.Domain.Interfaces
{
    public interface IParkService
    {
        public string ServiceName { get; }
        public IEnumerable<IPermit> GetPermits(IPerson person);
    }
}