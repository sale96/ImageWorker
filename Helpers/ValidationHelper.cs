namespace ImageWorker.Helpers
{
    public class ValidationHelper
    {
        public static bool ValidateDimensions(int width, int height) => (width <= 0 || height <= 0);
    }
}
