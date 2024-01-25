using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    internal class Participate
    {
        private string name;
        private double weightBefore;
        private double weightAfter;

        public Participate (string name, double weightBefore, double weightAfter)
        {
            this.name = name;
            this.weightBefore = weightBefore;
            this.weightAfter = weightAfter;
        }
        public string GetName()
        {
            return name;
        }
        public double GetWeightBefore()
        {
            return weightBefore;
        }
        public double GetWeightAfter()
        {
                return weightAfter;
        }
        public void SetName(string name)
        {
            this.name = name; 
        }
        public void SetWeightBefore(double weightBefore)
        {
            this.weightBefore = weightBefore;
        }
        public void SetWeightAfter(double weightAfter)
        {
            this.weightAfter = weightAfter;
        }
        public double Decrease()
        {
            return ((weightBefore - weightAfter)/weightBefore)*100;
        }

    }
}
