using HomeWork9.Models;

namespace HomeWork9
{
    internal class Actions
    {
        public void Start()
        {
            var message = "Start method";
            Logger.Instance().Info(message);
        }

        public void Skip()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public void Break()
        {
            throw new Exception("I broke a logic");
        }
    }
}
