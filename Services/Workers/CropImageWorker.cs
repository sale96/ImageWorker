using ImageWorker.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ImageWorker.Services.Workers
{
    public class CropImageWorker : IWorkerImage
    {
        private IPassPointData _data;

        public CropImageWorker(IPassPointData data)
        {
            _data = data;
        }

        public Task<string> SaveAndModifyAsync(IFormFile file, int width, int height, string dir)
        {
            throw new System.NotImplementedException();
        }
    }
}
