using HomeWork10.Models;

namespace HomeWork10.Services.Abstractions
{
    internal interface IAppliancePowerService
    {
        public void TurnOnSomeAppliances();
        public int GetOperatingAppliancePower();
    }
}
