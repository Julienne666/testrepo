using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Starter
    {
        public void Run() 
        {
            Actions actions = new Actions();
            Result result;

            for (int i = 0; i < 100; i++)
            {
                int randomNumber = new Random().Next(0, 3);
                switch (randomNumber)
                {
                    case 0:
                        result = actions.Start();
                        break;
                    case 1:
                        result = actions.Skip();
                        break;
                    default:
                        result = actions.Break();
                        break;
                }

                if (result.status == false)
                {
                    Logger.Instance().Error($"Action failed by a reason: {result.errorMessage}");
                }
            }

            File.WriteAllText("JMlogs.txt", Logger.Instance().GetLogs());
        }
    }
}
