using HomeWork10.Models;

namespace HomeWork10.Repositories
{
    internal class ElectricalApplianceRepository : IElectricalApplianceRepository
    {
        private ElectricalAppliance[] _electricalAppliances;
        public ElectricalApplianceRepository()
        {
            _electricalAppliances =
            [
                new Blender("Blender", 1200),
                new Fridge("Fridge", 500),
                new Microwave("Microwave", 1500),
                new Hairdryer("Hairdryer", 1800),
                new Razor("Razor", 700),
                new Styler("Styler", 1200),
                new WashingMachine("Washing Machine", 2000),
                new VacuumCleaner("Vacuun Cleaner", 2200),
                new WindowWasher("Window Washer", 600)
            ];
        }
        public ElectricalAppliance[] GetAppliances()
        {
            return _electricalAppliances;
        }
    }
}
