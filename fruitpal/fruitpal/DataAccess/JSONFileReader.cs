using System.IO;

namespace fruitpal.DataAccess
{
    public class JSONFileReader : IFileReader
    {
        /// <summary>
        /// Reads from the specified json file
        /// and returns the text
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string ReadFile(string file)
        {
            return File.ReadAllText(file);
        }
    }
}
