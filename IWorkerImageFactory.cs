using ImageWorker.Services;
using ImageWorker.Services.Enums;

namespace ImageWorker
{
    /// <summary>
    /// Provides the way to GetWorker from WorkerType enum
    /// </summary>
    public interface IWorkerImageFactory
    {
        /// <summary>
        /// Returns the worker defined by WorkerType enum
        /// </summary>
        /// <param name="workerType"></param>
        /// <returns>IImageWorker worker</returns>
        IImageWorker GetWorker(WorkerType workerType);
    }
}
