namespace HomeWork7.Models
{
    internal class Jelly : Candy
    {
        public Jelly(int weight, string name) 
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
            return "Jelly, sugar, water";
        }
    }
}
