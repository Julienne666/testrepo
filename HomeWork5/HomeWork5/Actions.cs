using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Actions
    {
        public Result Start()
        {
            var message = "Start method";
            Logger.Instance().Info(message);

            var result = new Result();
            result.status = true; 
            return result;
        }

        public Result Skip()
        {
            var message = "Skipped logic in method";
            Logger.Instance().Warning(message);

            return new Result(true);
        }

        public Result Break()
        {
            return new Result("I broke a logic", false);
        }
    }
}
