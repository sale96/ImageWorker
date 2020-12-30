using ImageWorker.Exceptions;
using ImageWorker.Extensions;
using ImageWorker.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace ImageWorker.Services.Workers
{
    /// <summary>
    /// Resize image worker: use it to resize images
    /// </summary>
    public class ResizeImageWorker : IWorkerImage
    {
        #region Private methods
        private async Task<Image> GenerateImageResize(IFormFile file, int width, int height)
        {
            Image newImage = null;
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                using (var img = Image.FromStream(memoryStream))
                {
                    newImage = ResizeImage(img, width, height);
                }
            }

            return newImage;
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            var res = new Bitmap(width, height);

            using (var graphic = Graphics.FromImage(res))
            {
                graphic.CreateGraphicsModes();
                graphic.DrawImage(image, 0, 0, width, height);
            }

            return res;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Resize image and Save it to directory with the new guid name
        /// </summary>
        /// <param name="file"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="directory"></param>
        /// <returns>string path</returns>
        public async Task<string> Save(IFormFile file, int width, int height, string directory)
        {
            string extension = "";
            if (!file.ValidateExtension(ref extension))
                throw new InvalidExtensionTypeException(extension);

            var image = await GenerateImageResize(file, width, height);
            var path  = StringHelper.GenerateNamedPath(extension, directory);

            image.Save(path);

            return path;
        }
        #endregion
    }
}
