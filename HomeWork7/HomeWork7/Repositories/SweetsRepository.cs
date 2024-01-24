using HomeWork7.Models;

namespace HomeWork7.Repositories
{
    internal class SweetsRepository : ISweetsRepository
    {

        private Sweet[] _sweets;
        public SweetsRepository() 
        {
            _sweets = new Sweet[] { 
                new Jelly(50, "Cola"), 
                new Jelly(90, "Bears"), 
                new WhiteChocolate(100, "Alenka"), 
                new Lollipop(45, "Chupa-chups"),
                new Choco(50, "Twix"),
                new MilkChocolate(120, "Milka"),
                new DarkChocolate(120, "Toblerone"),
                new Lollipop(50, "Rachky"),
                new Jelly(75, "Bdzhilka"),
                new Choco(60, "Snikers"),
                new Lollipop(85, "LittleCock"),
                new WhiteChocolate(100, "Millenium"),
                new MilkChocolate(130, "Kinder"),
                new DarkChocolate(130, "Ferrero"),
                new Choco(100, "Truffel"),
                new Lollipop(80, "Chupa-ChupsXXL"),
                new Choco(40, "Rafaello"),
                new Jelly(20, "Worm"),
                new MilkChocolate(100, "Trappa"),
                new WhiteChocolate(70, "Bounty"),
                new Choco(100, "Choco Eg")
            };
        }

        public Sweet[] GetSweets()
        {
            return _sweets;
        }
    }
}
