namespace ImageWorker.Services.Interfaces
{
    public interface IPassPointData
    {
        (int, int, int, int) Points { get; set; }
    }
}
