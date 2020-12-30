using System.Drawing;

namespace ImageWorker.Extensions
{
    public static class GraphicExtensions
    {
        public static Graphics CreateGraphicsModes(this Graphics graphic)
        {
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            return graphic;
        }
    }
}
