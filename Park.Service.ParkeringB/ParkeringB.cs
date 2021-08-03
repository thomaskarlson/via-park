using System;
using System.Collections.Generic;
using Park.Domain.Interfaces;

namespace Park.Service.ParkeringB
{
    public class ParkeringB : IParkService
    {
        private IEnumerable<IPermit> _data = new List<IPermit>()
        {
            new Permit(
                new Person() {FirstName = "Thomas", LastName = "Karlson"},
                new Vehicle() {Plate = "ZV56445"})
        };


        public string ServiceName => "Børge's parkeringsservice";

        public IEnumerable<IPermit> GetPermits(Person person)
        {
            //TODO: This should probably filter people...
            return _data;
        }

        public IEnumerable<IPermit> GetPermits(Vehicle vehicle)
        {
            //TODO: This should probably filter vehicles...
            return _data;
        }

        public void AddPermit(Person person, Vehicle vehicle, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}