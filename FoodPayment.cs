using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class FoodPayment : Payment
    {
        public override Dictionary<string, double> Prices { get; }
        public Dictionary<string, int> Items { get; set; }

        public FoodPayment()
        {
            Items = new Dictionary<string, int>();

            Prices = new Dictionary<string, double>() 
            {
                {"Hotdog", 70},
                {"Burger", 65},
                {"French fries", 40},
                {"Cola", 20}
            };
        }

        public override double Evaluate()
        {
            double sum = 0;

            foreach (var item in Items)
            {
                sum += Prices[item.Key] * item.Value;
            }

            return sum;
        }
    }
}
