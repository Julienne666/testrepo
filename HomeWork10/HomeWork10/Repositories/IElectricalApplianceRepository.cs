using HomeWork10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Repositories
{
    internal interface IElectricalApplianceRepository
    {
        public ElectricalAppliance[] GetAppliances();
    }
}
