using System;
using System.Collections.Generic;

namespace Park.Domain.Interfaces
{
    public interface IParkService
    {
        public string ServiceName { get; }
        public IEnumerable<IPermit> GetPermits(Person person);
        public IEnumerable<IPermit> GetPermits(Vehicle vehicle);
        public void AddPermit(Person person, Vehicle vehicle, DateTime startDate, DateTime endDate);
    }
}