using Formula.Logic;
using Formula.Model;
using System;

namespace FormulaApp.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeightLogic _weightlogic = new WeightLogic();
            WeightModel model = new WeightModel();

            model.Weight = 5;

            var result = _weightlogic.FindWeight(model);

            Console.WriteLine(result);
        }
    }
}
