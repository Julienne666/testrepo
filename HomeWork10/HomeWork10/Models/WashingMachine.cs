namespace HomeWork10.Models
{
    internal class WashingMachine : CleaningElectricalAppliance
    {
        public WashingMachine(string name, int powerConsumption)
        {
            _name = name;
            _powerConsumption = powerConsumption;
        }

        private string _name;
        private int _powerConsumption;
        public override string Name => _name;

        public override int PowerConsumption => _powerConsumption;
    }
}
