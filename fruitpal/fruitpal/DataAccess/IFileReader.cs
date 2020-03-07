namespace fruitpal.DataAccess
{
    public interface IFileReader
    {
        /// <summary>
        /// Implement interface to read from a specified file
        /// and return the text.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string ReadFile(string file);
    }
}
