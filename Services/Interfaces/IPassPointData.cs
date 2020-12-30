namespace ImageWorker.Services.Interfaces
{
    public interface IPassPointData
    {
        (int PointA, int PointB, int PointC, int PointD) Points { get; set; }
    }
}
