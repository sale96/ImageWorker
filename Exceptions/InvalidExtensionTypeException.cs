using System;

namespace ImageWorker.Exceptions
{
    public class InvalidExtensionTypeException : Exception
    {
        public InvalidExtensionTypeException(string extension)
            : base($"Invalid extension type: extension: {extension} is not a valid type.")
        {
        }
    }
}
