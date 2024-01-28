namespace HomeWork8.Models
{
    internal class SaladItem
    {
        private readonly Vegetable _vegetableType;
        private readonly int _vegetableMass;

        public SaladItem(Vegetable vegetableType, int vegetableMass)
        {
            _vegetableType = vegetableType;
            _vegetableMass = vegetableMass;
        }

        public Vegetable VegetableType => _vegetableType;
        public int VegetableMass => _vegetableMass;
    }
}
