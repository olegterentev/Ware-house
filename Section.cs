using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Warehouse
{
    [Serializable]
    public class Section : TreeNode, ISerializable
    {
        public new string Name { set => Text = value; get => Text; }
        public int SortCode { set; get; }
        public List<Product> Products { set; get; }

        public Section(string name)
        {
            Name = name;
            SortCode = 0;
            Products = new List<Product>();
        }

        public Section()
        {
            Name = "";
            SortCode = 0;
            Products = new List<Product>();
        }


        protected Section(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            SortCode = info.GetInt32("SortCode");
            Products = (List<Product>)info.GetValue("Product", typeof(List<Product>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("SortCode", SortCode);
            info.AddValue("Product", Products);
        }
    }
}
