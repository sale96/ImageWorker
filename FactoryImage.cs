using ImageWorker.Services;
using ImageWorker.Services.Enums;
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
        /// <returns>IImageWorker worker</returns>
        public IWorkerImage GetWorker(WorkerType workerType)
        {
            IWorkerImage worker = null;
            switch (workerType)
            {
                case WorkerType.RezizeWorker:
                    worker = new ResizeImageWorker();
                    break;
            }

            return worker;
        }
    }
}
