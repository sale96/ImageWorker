using System;

namespace ImageWorker.Exceptions
{
    public class InvalidDimensionsException : Exception
    {
        public InvalidDimensionsException(int width, int height)
            : base($"Image dimensions must not be 0 or below, your dimensions are: width={width}, height={height}")
        {
        }
    }
}
