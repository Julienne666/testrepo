using HomeWork8.Models;

namespace HomeWork8.Repositories
{
    internal class VegetablesRepository : IVegetablesRepository
    {
        private Vegetable[] _vegetables;
        public VegetablesRepository()
        {
            _vegetables = new Vegetable[]
            {
                new Alliaceae("Onion", 30),
                new Alliaceae("Leek", 35),
                new Alliaceae("Garlic", 32),
                new Brassicaceae("Red Cabbage", 27),
                new Brassicaceae("Cauliflower", 31),
                new Brassicaceae("Broccoli", 33),
                new Cucurbitaceae("Cucumber", 18),
                new Cucurbitaceae("Zucchini", 25),
                new Cucurbitaceae("Pumpkin", 37),
                new Solanaceae("Tomato", 24),
                new Solanaceae("Eggplant", 36),
                new Solanaceae("Capsicum", 29),
                new RootVegetable("Beetroot", 40),
                new RootVegetable("Carrot", 27),
                new RootVegetable("Radish", 25),
                new RootVegetable("Celery", 21)
            };
        }
        public Vegetable[] GetVegetables()
        {
            return _vegetables;
        }
    }
}
