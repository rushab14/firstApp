namespace FirstApi.Models
{
    public class ApiLogger : IApiLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} :{message}");
        }
    }
    public interface IApiLogger
    {
        void Log(string message);
    }
    public class FileApiLogger : IApiLogger
    {
        private string _filename;
        public FileApiLogger()
            
        {
            _filename = $"Log_{DateTime.Now.ToFileTime()}.log";
            File.WriteAllText(_filename,"This is a log file " + Environment.NewLine);
        
        }
        public void Log(string message)
        {
            File.AppendAllText(_filename, $"{DateTime.Now} : {message}"); 
            File.AppendAllText(_filename, Environment.NewLine);
        }
    }
}
