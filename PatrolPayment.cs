using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class PatrolPayment : Payment
    {
        public override Dictionary<string, double> Prices { get; }
        public string PatrolType { get; set; }
        private char mode;
        public double Argument { get; set; }

        public PatrolPayment() 
        {
            //A-76
            //Disel
            //B-32
            //Best

            // Mode 
            // C - Count
            // P - price

            PatrolType = string.Empty;
            mode = 'C';

            Prices = new Dictionary<string, double>()
            {
                {"A-76", 5.78},
                {"Disel", 4.2},
                {"B-32", 9.43},
                {"Best", 11.51}
            };
        }

        public void SetMode(char mode)
        {
            if (mode != 'C' && mode != 'P')
            {
                MessageBox.Show("Wrong mode", "Error");
            }

            else
            {
                this.mode = mode;
            }
        }

        public override double Evaluate()
        {
            if (PatrolType == string.Empty)
            {
                MessageBox.Show("Choose patrol type", "Error");
                return 0;
            }

            if (mode == 'C')
            {
                return Argument * Prices[PatrolType];
            }

            else
            {
                return Argument / Prices[PatrolType];
            }
        }
    }
}
