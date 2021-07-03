using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DistributeurAuto
{
    internal class Dao
    {        
        public static void LoadXml(out double marge, out IEnumerable<IProduct> Product, out IEnumerable<IRecipe> Recipes)
        {
            XmlSerializer reader = new XmlSerializer(typeof(double));
            StreamReader file = new StreamReader(@".\Xml Data\Marge.xml");
            marge = (double)reader.Deserialize(file);
            file.Close();

            reader = new XmlSerializer(typeof(List<Product>));
            file = new StreamReader(
                 @".\Xml Data\Product.xml");
            Product = (List<Product>)reader.Deserialize(file);
            file.Close();

            reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Recipe>));
            file = new System.IO.StreamReader(
                 @".\Xml Data\Recipes.xml");
            Recipes = (List<Recipe>)reader.Deserialize(file);
            file.Close();
        }

        public static IEnumerable<IRecipe> LoadData()
        {
            LoadXml(out double marge, out IEnumerable<IProduct> Product, out IEnumerable<IRecipe> Recipes);
            foreach(var recipe in Recipes)
            {
                recipe.ComputePrice(Product, marge);
            }
            return Recipes;
        }

    }
}