namespace HomeWork7.Models
{
    internal class Lollipop : Candy
    {
        private int _weight;
        private string _name;

        public Lollipop(int weight, string name) 
        { 
            _weight = weight;
            _name = name;
        }

        public override int Weight => _weight;

        public override string Name => _name;

        public override string GetIngridients()
        {
            return "Sugar, water";
        }
    }
}
