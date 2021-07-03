using System.Xml;
using System.Xml.Serialization;

namespace DistributeurAuto
{
    [XmlRoot("Ingredient")]
    public class Ingredient : IIngredient
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Quantity")]
        public int Quantity { get; set; }
    }
}
