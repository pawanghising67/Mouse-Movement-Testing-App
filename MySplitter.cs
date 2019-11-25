using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseMovementCalculator
{
    class MySplitter
    {
        public MySplitter(string split)
        {
            var results = split.Split(',');
            NamedPartA = results[0];
            NamedPartB = results[1];
        }

        public string NamedPartA { get; private set; }
        public string NamedPartB { get; private set; }
    }
}
