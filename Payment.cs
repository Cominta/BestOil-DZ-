using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    abstract public class Payment
    {
        public abstract Dictionary<string, double> Prices { get; }

        public abstract double Evaluate();
    }
}
