namespace HomeWork8.Models
{
    internal class Brassicaceae : Vegetable
    {
        public Brassicaceae(string name, int calories)
        {
            _name = name;
            _calories = calories;
        }

        private string _name;
        private int _calories;
        public override string Name => _name;

        public override int Calories => _calories;
    }
}
