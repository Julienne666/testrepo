namespace HomeWork8.Models
{
    internal class Solanaceae : Vegetable
    {
        public Solanaceae(string name, int calories)
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
