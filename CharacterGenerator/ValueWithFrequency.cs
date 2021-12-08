using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class ValueWithFrequency
    {
        private string value;
        private int frequency;

        public ValueWithFrequency (string value, int frequency)
        {
            this.value = value;
            this.frequency = frequency;
        }
        public string Value { get => value; set => this.value = value; }
        public int Frequency { get => frequency; set => frequency = value; }
    }
}
