using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Lab_2.common.settings
{
    class EntityOutput
    {
        private double value;
        private string name;

        public double Value { get => value; set => this.value = value; }
        public string Name { get => name; set => name = value; }
    }
}
