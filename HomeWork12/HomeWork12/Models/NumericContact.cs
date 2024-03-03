namespace HomeWork12.Models
{
    internal class NumericContact : Contact
    {
        public NumericContact(string name, string phone)
        {
            _name = name;
            _phone = phone;
        }

        private string _name;
        private string _phone;

        public override string Name => _name;

        public override string Phone => _phone;
    }
}
