using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FormReport : Form
    {
        List<Section> sections;

        public FormReport(List<Section> sections)
        {
            InitializeComponent();
            this.sections = sections;
        }

        private void Search(Section section, List<Product> products)
        {
            foreach (var product in section.Products)
                if (product.StockBalance < NumericUpDownSortCode.Value)
                    products.Add(product);
            foreach (Section subsection in section.Nodes)
                Search(subsection, products);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            foreach (var section in sections)
                Search(section, products);
            var dialog = new SaveFileDialog();
            dialog.Filter = "CSV Файл  (*.csv) | *.csv";
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"\"Путь\",\"Артикул\",\"Наименование\",\"Количество на суладе\"");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var product in products)
                    builder.AppendLine($"\"{product.Path}\",\"{product.VendorCode}\",\"{product.Name}\",\"{product.StockBalance}\"");
                File.WriteAllText(dialog.FileName, builder.ToString(), Encoding.UTF8);
                Close();
            }
        }
    }
}
