namespace Park.Domain.Interfaces
{
    public interface IPermit
    {
        public IVehicle Vehicle { get; set; }
    }

    public interface IVehicle
    {
        public string Plate { get; set; }
    }
}