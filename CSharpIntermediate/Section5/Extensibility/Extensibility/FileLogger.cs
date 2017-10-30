using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true)) // streanWriter.Dispose(); 当exception发生的时候，会自动call这一句，using里面自动帮我们call了这一句!!!
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}