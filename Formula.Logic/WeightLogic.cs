using Formula.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula.Logic
{
    public class WeightLogic
    {

        public double FindWeight(WeightModel model)
        {
            var gravity = 9.8;
            var result = model.Weight * gravity;
            return result;
        }
    }
}
