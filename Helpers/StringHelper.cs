using System;
using System.IO;

namespace ImageWorker.Helpers
{
    public class StringHelper
    {
        /// <summary>
        /// Generates name for the file
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="directory"></param>
        /// <returns>string path</returns>
        public static string GenerateNamedPath(string extension, string directory)
        {
            var name = Guid.NewGuid().ToString() + extension;
            var path = Path.Combine(directory, name);

            return path;
        }
    }
}
