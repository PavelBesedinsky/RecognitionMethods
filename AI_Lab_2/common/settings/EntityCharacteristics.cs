using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Lab_2.common.settings
{
    class EntityCharacteristics
    {
        private string name;
        private double value;

        public EntityCharacteristics(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public string Name { get => name; set => name = value; }
        public double Value { get => value; set => this.value = value; }
    }
}
