using ImageWorker.Exceptions;
using ImageWorker.Services;
using ImageWorker.Services.Enums;
using ImageWorker.Services.Interfaces;
using ImageWorker.Services.Workers;

namespace ImageWorker
{
    /// <summary>
    /// Provides the way to GetWorker from WorkerType enum
    /// </summary>
    public class FactoryImage : IFactoryImage
    {
        /// <summary>
        /// Returns the worker defined by WorkerType enum
        /// </summary>
        /// <param name="workerType"></param>
        /// <param name="data"></param>
        /// <returns>IImageWorker worker</returns>
        public IWorkerImage GetWorker(WorkerType workerType, IPassPointData data = null)
        {
            IWorkerImage worker = null;
            switch (workerType)
            {
                case WorkerType.Resize:
                    worker = new ResizeImageWorker();
                    break;
                case WorkerType.Crop:
                    if (data == null)
                        throw new NotPassedPointException();
                    worker = new CropImageWorker(data);
                    break;
            }

            return worker;
        }
    }
}
