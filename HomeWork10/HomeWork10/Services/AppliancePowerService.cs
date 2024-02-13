using HomeWork10.Models;
using HomeWork10.Repositories;
using HomeWork10.Services.Abstractions;

namespace HomeWork10.Services
{
    internal class AppliancePowerService : IAppliancePowerService
    {
        private readonly ISortAndFindApplianceService _sortAndFindApplianceService;
        private readonly IElectricalApplianceRepository _applianceRepository;
        private readonly ILoggerService _loggerService;
        private ElectricalAppliance[] _turnedOnAppliances;
        public AppliancePowerService(
            IElectricalApplianceRepository applianceRepository, 
            ISortAndFindApplianceService sortAndFindAppliance,
            ILoggerService loggerService
            ) 
        {
            _applianceRepository = applianceRepository;
            _sortAndFindApplianceService = sortAndFindAppliance;
            _loggerService = loggerService;
        }
        public void TurnOnSomeAppliances()
        {
            ElectricalAppliance[] electricalAppliances = new ElectricalAppliance[9];
            for (int i = 0; i < electricalAppliances.Length; i++)
            {
                electricalAppliances[i] = _applianceRepository.GetAppliances()[new Random().Next(0, 9)];
            }
            _turnedOnAppliances = electricalAppliances;

            _sortAndFindApplianceService.SortAppliancesByPower(electricalAppliances);

            
            Console.WriteLine("Turned on appliances:");
            foreach (ElectricalAppliance appliance in electricalAppliances)
            {
                _loggerService.Log(LogType.Info, $"{appliance.Name}, {appliance.PowerConsumption} W");
            }
            
        }

        public int GetOperatingAppliancePower()
        {
            int totalPower = 0;
            foreach (ElectricalAppliance electricalAppliance in _turnedOnAppliances)
            {
                totalPower += electricalAppliance.PowerConsumption;
            }
            return totalPower;
        }
    }
}
