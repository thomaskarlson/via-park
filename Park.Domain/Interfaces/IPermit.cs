namespace Park.Domain.Interfaces
{
    public interface IPermit
    {
        public Vehicle Vehicle { get; }
        public Person Person { get; }
    }
}