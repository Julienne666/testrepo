using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Result
    {
        public bool status;
        public string errorMessage;

        public Result() { }

        public Result(bool status)
        {
            this.status = status;
        }

        public Result(string errorMessage, bool status)
        {
            this.errorMessage = errorMessage;
            this.status = status;
        }
    }
}
