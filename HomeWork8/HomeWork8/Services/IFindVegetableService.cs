using HomeWork8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Services
{
    internal interface IFindVegetableService
    {
        public Vegetable? FindVegetableByName(string? vegetableName);
    }
}
