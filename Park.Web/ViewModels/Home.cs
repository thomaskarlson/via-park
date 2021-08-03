using System.Collections.Generic;
using Park.Domain.Interfaces;
using Web.Models;

namespace Web.ViewModels
{
    public class Home
    {
        private readonly ParkServices _parkServices;

        public Home(ParkServices parkServices)
        {
            _parkServices = parkServices;
        }


        public IEnumerable<IParkService> Services => _parkServices.Services;
    }
}