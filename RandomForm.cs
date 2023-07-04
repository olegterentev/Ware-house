using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class RandomForm : Form
    {
        public List<Section> Sections;
        private Random random;
       
        public RandomForm()
        {
            InitializeComponent();
            Sections = new List<Section>();
            random = new Random();
        }


        private void Generate(Section section, int minSection, int maxSection, int minProducts, int maxProducts,
            string[] productWords, string[] sectionWords, int maxLevel, int level = 0)
        {
            
            string name = sectionWords[random.Next(sectionWords.Length)];
            section.Name = name;
            section.SortCode = random.Next(maxProducts);

            var productNumber = random.Next(minProducts, maxProducts);
            for (int i = 0; i < productNumber; i++)
            {
                var product = new Product();
                name = productWords[random.Next(productWords.Length)];
                product.Name = name;
                product.Section = section;
                product.Price = random.Next(1000);
                string vendorCode = "";
                for (int j = 0; j < 5; j++)
                    vendorCode += new string((char)('A' + random.Next('Z' - 'A')), 1) + random.Next(10).ToString();
                product.VendorCode = vendorCode;
                product.StockBalance = random.Next(100);
                string description = "";
                var maxWords = random.Next(50);
                for (int j = 0; j < maxWords; j++)
                    description += productWords[random.Next(productWords.Length)] + " ";
                product.Description = description;

                section.Products.Add(product);
            }

            if (level < maxLevel && random.Next(3) >= 1)
            {
                var sectionNumber = random.Next(minSection, maxSection);
                for (int i = 0; i < sectionNumber; i++)
                {
                    var subSection = new Section();
                    section.Nodes.Add(subSection);
                    Generate(subSection, minSection, maxSection, minProducts, maxProducts, productWords, sectionWords, maxLevel, level + 1);
                }
            }
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            var minSection = (int)NumericUpDownSectionsMin.Value;
            var maxSection = (int)NumericUpDownSectionMax.Value;
            var minProducts = (int)NumericUpDownProductsMin.Value;
            var maxProducts = (int)NumericUpDownProducsMax.Value;
            var maxLevel = (int)NumericUpDownDown.Value;
            string[] productWords = TextBoxProductsWords.Text.Split(',');
            string[] sectionWords = TextBoxScetionsWords.Text.Split(',');

            for(int i = 0; i < productWords.Length; i++)
                productWords[i] = productWords[i].TrimStart().TrimEnd();

            for (int i = 0; i < sectionWords.Length; i++)
                sectionWords[i] = sectionWords[i].TrimStart().TrimEnd();

            if (productWords.Length == 0 || sectionWords.Length == 0)
            {
                MessageBox.Show("Заполните слова для наименований!", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    

            var sectionNumber = random.Next(minSection, maxSection);
            for (int i = 0; i < sectionNumber; i++)
            {
                var section = new Section();
                Sections.Add(section);
                Generate(section, minSection, maxSection, minProducts, maxProducts, productWords, sectionWords, maxLevel, 1);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
