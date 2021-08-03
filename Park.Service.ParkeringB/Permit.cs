using Park.Domain.Interfaces;

namespace Park.Service.ParkeringB
{
    public class Permit:IPermit
    {
        public Permit(Person person, Vehicle vehicle)
        {
            Person = person;
            Vehicle = vehicle;
        }

        public Vehicle Vehicle { get; }
        public Person Person { get; }
    }
}