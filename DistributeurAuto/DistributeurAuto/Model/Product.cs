using System.Xml.Serialization;

namespace DistributeurAuto
{
    [XmlRoot("Product")]
    public class Product : IProduct
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
