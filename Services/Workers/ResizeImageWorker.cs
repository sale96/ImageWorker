using ImageWorker.Extensions;
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
    public class ResizeImageWorker : IImageWorker
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
                graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphic.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
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
                throw new Exception("Image extension is not valid!");

            var image = await GenerateImageResize(file, width, height);

            var name = Guid.NewGuid().ToString() + extension;

            var path = Path.Combine(directory, name);

            image.Save(path);

            return path;
        }
        #endregion
    }
}
