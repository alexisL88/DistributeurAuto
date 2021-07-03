using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace DistributeurAuto
{
    public class Recipe : IRecipe
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Ingredient")]
        public List<Ingredient> Ingredients { get; set; }

        [XmlIgnore]
        public double Price { get; set; }

        public void ComputePrice(IEnumerable<IProduct> products, double marge)
        {
            Price = 0;
            foreach (var ingredient in Ingredients)
            {
                var product = products.FirstOrDefault(p => p.Name == ingredient.Name);
                if(product != null)
                {
                    Price += product.Price;
                }
            }
            Price *= 1 + (marge / 100);
            Price = Math.Round(Price, 2);
        }
    }
}
