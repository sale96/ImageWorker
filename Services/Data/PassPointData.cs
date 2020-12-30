using ImageWorker.Services.Interfaces;

namespace ImageWorker.Services.Data
{
    public class PassPointData : IPassPointData
    {
        public (int PointA, int PointB, int PointC, int PointD) Points { get; set; } = (0, 0, 0, 0);
    }
}
