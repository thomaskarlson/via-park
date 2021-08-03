using System.Collections.Generic;
using Park.Domain.Interfaces;

namespace Web.Models
{
    public class ParkServices
    {
        private readonly List<IParkService> _parkServices = new();

        public IEnumerable<IParkService> Services => _parkServices;

        public ParkServices AddService(IParkService service)
        {
            _parkServices.Add(service);
            return this;
        }
    }
}