using System;

namespace ImageWorker.Exceptions
{
    public class NotPassedPointException : Exception
    {
        public NotPassedPointException()
            : base("Please provide points for this action.")
        {

        }
    }
}
