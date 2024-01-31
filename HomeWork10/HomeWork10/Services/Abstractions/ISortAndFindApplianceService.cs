using HomeWork10.Models;

namespace HomeWork10.Services.Abstractions
{
    internal interface ISortAndFindApplianceService
    {
        public ElectricalAppliance[] SortAppliancesByPower(ElectricalAppliance[] appliances);
        public ElectricalAppliance? FindApplianceByName(string? applianceName);
    }
}
