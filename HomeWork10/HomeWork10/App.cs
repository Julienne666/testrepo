using HomeWork10.Models;
using HomeWork10.Services.Abstractions;

namespace HomeWork10
{
    internal class App
    {
        private readonly IAppliancePowerService _appliancePowerService;
        private readonly ISortAndFindApplianceService _sortAndFindAppliance;
        private readonly ILoggerService _loggerService;

        public App(
            IAppliancePowerService appliancePowerService, 
            ISortAndFindApplianceService sortAndFindAppliance,
            ILoggerService loggerService
            )
        {
            _appliancePowerService = appliancePowerService;
            _sortAndFindAppliance = sortAndFindAppliance;
            _loggerService = loggerService;
        }
        public void Run()
        {
            _appliancePowerService.TurnOnSomeAppliances();
            GetTotalPower();
            FindAppliance();
        }

        private void GetTotalPower()
        {
            int totalPower = _appliancePowerService.GetOperatingAppliancePower();
            Console.WriteLine($"{totalPower} total power");
        }

        private void FindAppliance()
        {
            Console.WriteLine("Enter name of appliance: ");
            string? applianceName = Console.ReadLine();
            if (applianceName == null)
            {
                _loggerService.Log(LogType.Error, "User has not provided any data");
            }
            else
            {
                ElectricalAppliance? electricalAppliance = _sortAndFindAppliance.FindApplianceByName(applianceName);
                if (electricalAppliance == null)
                {
                    _loggerService.Log(LogType.Warning, "Nothig was found");
                }
                else
                {
                    _loggerService.Log(LogType.Info, $"{electricalAppliance.Name}, {electricalAppliance.PowerConsumption} W");
                }
            }
        }
    }
}
