using System.Collections.Generic;

namespace DistributeurAuto
{
    public interface IRecipe
    {
        string Name { get; set; }
        List<Ingredient> Ingredients { get; set; }

        void ComputePrice(IEnumerable<IProduct> product, double marge);
    }
}