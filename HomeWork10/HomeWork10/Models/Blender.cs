﻿using System.Xml.Linq;

namespace HomeWork10.Models
{
    internal class Blender : KitchenElectricalAppliance
    {
        public Blender(string name, int powerConsumption) 
        {
            _name = name;
            _powerConsumption = powerConsumption;
        }

        private string _name;
        private int _powerConsumption;
        public override string Name => _name;

        public override int PowerConsumption => _powerConsumption;
    }
}
