using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Warehouse
{
    public class SectionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Section).IsAssignableFrom(objectType) || typeof(Product).IsAssignableFrom(objectType);
        }

        private string ImageToBase64(Image image)
        {
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private Bitmap Base64ToImage(string base64String)
        {
            byte[] bytes = Convert.FromBase64String(base64String);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return (Bitmap)image;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value.GetType() == typeof(Section))
            {
                Section section = (Section)value;
                JObject obj = new JObject();
                obj.Add("Type", "Section");
                obj.Add("Name", section.Name);
                obj.Add("SortCode", section.SortCode);
                obj.Add("Products", JArray.FromObject(section.Products, serializer));
                obj.Add("Children", JArray.FromObject(section.Nodes, serializer));
                obj.WriteTo(writer);
            }
            else if (value.GetType() == typeof(Product))
            {
                Product product = (Product)value;
                JObject obj = new JObject();
                obj.Add("Type", "Product");
                obj.Add("Id", product.Id);
                obj.Add("Name", product.Name);
                obj.Add("VendorCode", product.VendorCode);
                obj.Add("Price", product.Price);
                obj.Add("StockBalance", product.StockBalance);
                obj.Add("Description", product.Description);
                if (product.Image == null)
                    obj.Add("Image", "Null");
                else
                    obj.Add("Image", ImageToBase64(product.Image));
                obj.WriteTo(writer);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject obj = (JObject)existingValue;
            var type = obj.GetValue("Type").ToString();
            if (type == "Section")
            {
                Section section = new Section(obj.GetValue("Name").ToString());
                section.SortCode = (int)obj.GetValue("SortCode");
                var array = JArray.Parse(obj.GetValue("Products").ToString());
                foreach (var jObject in array)
                {
                    var product = (Product)ReadJson(reader, typeof(object), jObject, serializer);
                    product.Section = section;
                    section.Products.Add(product);
                }
                array = JArray.Parse(obj.GetValue("Children").ToString());
                foreach (var jObject in array)
                    section.Nodes.Add((Section)ReadJson(reader, typeof(object), jObject, serializer));
                return section;
            }
            else if (type == "Product")
            {
                Product product = new Product();
                product.Id = (int)obj.GetValue("Id");
                product.Name = (string)obj.GetValue("Name");
                product.VendorCode = (string)obj.GetValue("VendorCode");
                product.Price = (float)obj.GetValue("Price");
                product.StockBalance = (int)obj.GetValue("StockBalance");
                product.Description= (string)obj.GetValue("Description");
                var image = obj.GetValue("Image").ToString();
                if (image == "Null")
                    product.Image = null;
                else
                {
                    product.Image = Base64ToImage(image);
                }
                return product;
            }
            return null;
        }


        public List<Section> LoadSections(JsonReader reader, JsonSerializer serializer)
        {
            List<Section> sections = new List<Section>();
            JArray jArray = JArray.Load(reader);
            foreach (var jObject in jArray)
                sections.Add((Section)ReadJson(reader, typeof(object), jObject, serializer));
            return sections;
        }
    }
}
