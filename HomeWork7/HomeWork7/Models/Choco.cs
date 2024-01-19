namespace HomeWork7.Models
{
    internal class Choco : Candy
    {
        public Choco(int weight, string name)
        {
            _weight = weight;
            _name = name;
        }

        private int _weight;
        private string _name;

        public override int Weight => _weight;

        public override string Name => _name;

        public override string GetIngridients()
        {
            return "Cocoa, milk, palm oil, sugar";
        }
    }
}
