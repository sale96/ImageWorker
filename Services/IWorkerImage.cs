using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ImageWorker.Services
{
    public interface IImageWorker
    {
        Task<string> Save(IFormFile file, int width, int height, string dir);
    }
}
