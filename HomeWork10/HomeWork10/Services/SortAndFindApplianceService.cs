using HomeWork10.Models;
using HomeWork10.Repositories;
using HomeWork10.Services.Abstractions;

namespace HomeWork10.Services
{
    internal class SortAndFindApplianceService : ISortAndFindApplianceService
    {
        private readonly IElectricalApplianceRepository _applianceRepository;

        public SortAndFindApplianceService(IElectricalApplianceRepository applianceRepository)
        {
            _applianceRepository = applianceRepository;
        }
        public ElectricalAppliance[] SortAppliancesByPower(ElectricalAppliance[] appliances)
        {
            for (int i = 0; i < appliances.Length; i++)
            {
                for (int j = i + 1; j < appliances.Length; j++)
                {
                    if (appliances[i].PowerConsumption > appliances[j].PowerConsumption)
                    {
                        ElectricalAppliance temp = appliances[i];
                        appliances[i] = appliances[j];
                        appliances[j] = temp;
                    }
                }
            }
            return appliances;
        }
        public ElectricalAppliance? FindApplianceByName(string? applianceName)
        {
            ElectricalAppliance[] appliances = _applianceRepository.GetAppliances();

            for (int i = 0; i < appliances.Length; i++)
            {
                if (appliances[i].Name == applianceName)
                {
                    return appliances[i];
                }
            }
            return null;
        }
    }
}
