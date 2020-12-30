using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ImageWorker.Services
{
    public interface IWorkerImage
    {
        Task<string> SaveAndModifyAsync(IFormFile file, int width, int height, string dir);
    }
}
