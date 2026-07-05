public interface IPlugin
{
    string SetPlugin();
}

namespace MyDLL3
{
    public class MyDLL3Class : IPlugin
    {
        public string SetPlugin()
        {
            return "DLL3 로드 성공";
        }
    }
}