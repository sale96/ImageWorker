using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ImageWorker.Extensions
{
    public static class ImageExtensions
    {
        public static bool ValidateExtension(this IFormFile file, ref string extension)
        {
            var allowedExtensions = new List<string> { ".jpg", ".jpeg", ".png" };

            extension = Path.GetExtension(file.FileName);

            string typ = extension;

            return allowedExtensions.Any(x => x == typ);
        }
    }
}
