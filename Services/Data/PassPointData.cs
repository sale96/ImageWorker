using ImageWorker.Services.Interfaces;

namespace ImageWorker.Services.Data
{
    public class PassPointData : IPassPointData
    {
        public (int, int, int, int) Points { get; set; } = (0, 0, 0, 0);

        public PassPointData()
        {
        }

        public PassPointData((int, int, int, int) points)
        {
            Points = points;
        }

        public PassPointData(int pointA, int pointB)
        {
            var tupple = (pointA, pointB, 0, 0);
            Points = tupple;
        }

        public PassPointData(int pointA, int pointB, int pointC, int pointD)
        {
            var tupple = (pointA, pointB, pointC, pointD);
            Points = tupple;
        }
    }
}
