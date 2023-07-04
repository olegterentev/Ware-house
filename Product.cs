using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace Warehouse
{
    [Serializable]
    public class Product : ISerializable
    {
        public static int IDCounter = 0;

        public Section Section { set; get; }
        public int Id { set; get; }
        public string Name { set; get; }
        public string VendorCode { set; get; }
        public float Price { set; get; }
        public int StockBalance { set; get; }
        public string Description { set; get; }
        public Bitmap Image { set; get; }
        public Product()
        {
            Id = IDCounter++;
            Name = "";
            VendorCode = "";
            Price = 0.0f;
            StockBalance = 0;
            Description = "";
            Image = null;
        }

        protected Product(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Id");
            Name = info.GetString("Name");
            VendorCode = info.GetString("VendorCode");
            Price = info.GetSingle("Price");
            StockBalance = info.GetInt32("StockBalance");
            Description = info.GetString("Description");
            Image = (Bitmap)info.GetValue("Image", typeof(Bitmap));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Name", Name);
            info.AddValue("VendorCode", VendorCode);
            info.AddValue("Price", Price);
            info.AddValue("StockBalance", StockBalance);
            info.AddValue("Description", Description);
            info.AddValue("Image", Image);
        }

        private string GetPath(Section section)
        {
            return section.Parent == null ? section.Text : $"{GetPath((Section)section.Parent)}/{section.Text}";
        }

        public string Path
        {
            get => GetPath(Section);
        }
    }
}
