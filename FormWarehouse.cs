using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FormWarehouse : Form
    {
        private string path;
        private bool saved;
        private List<Section> sections;
        private ImageList imageList;

        public FormWarehouse()
        {
            InitializeComponent();
            sections = new List<Section>();
            imageList = new ImageList();
            imageList.Images.Add(new Bitmap(Properties.Resources.section));
            TreeViewSections.ImageList = imageList;
            DataGridViewProducts.AutoGenerateColumns = false;
            saved = true;
            path = "";
        }

        private void UpdateSectionsTree()
        {
            TreeViewSections.Nodes.Clear();
            TreeViewSections.Nodes.AddRange(sections.ToArray());
        }

        private void UpdateProductList()
        {
            var selected = (Section)TreeViewSections.SelectedNode;
            DataGridViewProducts.DataSource = null;
            if (selected != null)
            {
                List<Product> products = new List<Product>();
                products.AddRange(GetProductList(selected));
                var uppers = products.Where(x => x.Section == selected);
                DataGridViewProducts.DataSource = products;
                for (int i = 0; i < DataGridViewProducts.Rows.Count; i++)
                {
                    if (uppers.Where(x => x.Id == int.Parse(DataGridViewProducts.Rows[i].Cells[0].Value.ToString())).FirstOrDefault() == null)
                        DataGridViewProducts.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
                DataGridViewProducts.ClearSelection();
            }
        }

        private List<Product> GetProductList(Section section)
        {
            var products = (IEnumerable<Product>)section.Products;
            if (CheckBoxShowSubsectionProducts.Checked)
            {
                foreach (Section subsection in section.Nodes)
                    products = products.Concat(GetProductList(subsection));
            }
            return products.ToList();
        }

        private void TreeViewSections_MouseUp(object sender, MouseEventArgs e)
        {

            TreeViewSections.SelectedNode = TreeViewSections.GetNodeAt(e.X, e.Y);
            if (TreeViewSections.SelectedNode != null)
            {
                if (e.Button == MouseButtons.Right)
                    ContextMenuStripTreeNode.Show(TreeViewSections, e.Location);
            }
            else
            {
                if (e.Button == MouseButtons.Right)
                    ContextMenuStripSections.Show(TreeViewSections, e.Location);
                ToolStripMenuItemSectionEdit.Enabled = false;
                ToolStripMenuItemSectionRemove.Enabled = false;
                ToolStripMenuItemProductAdd.Enabled = false;
                DataGridViewProducts.DataSource = null;
            }
        }

        private void ToolStripMenuItemAddSection_Click(object sender, EventArgs e)
        {
            var form = new FormSection();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (sections.Where(x => x.Text == form.SectionName).FirstOrDefault() == null)
                {
                    if (form.SectionName != "")
                    {
                        var section = new Section(form.SectionName);
                        section.ImageIndex = 0;
                        sections.Add(section);
                        UpdateSectionsTree();
                        saved = false;
                    }
                    else
                        MessageBox.Show("Раздел должен иметь непустое имя!", "Некорреткное название раздела",
                            MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                else
                    MessageBox.Show("Раздел с данным именем уже существует!", "Некорреткное название раздела",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void ToolStripMenuItemAddSubsection_Click(object sender, EventArgs e)
        {
            var selected = TreeViewSections.SelectedNode;
            if (selected != null)
            {
                var form = new FormSection();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (selected.Nodes.Cast<Section>().Where(x => x.Text == form.SectionName).FirstOrDefault() == null)
                    {
                        if (form.SectionName != "")
                        {
                            var subsection = new Section(form.SectionName);
                            subsection.SortCode = form.SortCode;
                            subsection.ImageIndex = 0;
                            selected.Nodes.Add(subsection);
                            selected.Expand();
                            TreeViewSections.SelectedNode = subsection;
                            saved = false;
                        }
                        else
                            MessageBox.Show("Подраздел должен иметь непустое имя!", "Некорреткное название раздела",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Подраздел с данным именем уже существует!", "Некорреткное название раздела",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ToolStripMenuItemRemoveSection_Click(object sender, EventArgs e)
        {
            var selected = (Section)TreeViewSections.SelectedNode;
            if (selected != null)
            {
                if (selected.Nodes.Count == 0)
                {
                    if (selected.Products.Count == 0)
                    {
                        if (selected.Parent != null)
                            selected.Parent.Nodes.Remove(selected);
                        else
                        {
                            sections.Remove(selected);
                            if (sections.Count == 0)
                            {
                                ToolStripMenuItemSectionEdit.Enabled = false;
                                ToolStripMenuItemSectionRemove.Enabled = false;
                                ToolStripMenuItemProductAdd.Enabled = false;
                                DataGridViewProducts.DataSource = null;
                            }
                            UpdateSectionsTree();
                        }
                        saved = false;
                    }
                    else
                        MessageBox.Show("Раздел содержит продукты!", "Невозмодно удалить раздел!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Раздел содержит подразделы!", "Невозмодно удалить раздел!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToolStripMenuItemEditSection_Click(object sender, EventArgs e)
        {
            var selected = (Section)TreeViewSections.SelectedNode;
            if (selected != null)
            {
                var form = new FormSection();
                form.SectionName = selected.Text;
                form.SortCode = selected.SortCode;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (selected.Nodes.Cast<Section>().Where(x => x.Text == form.SectionName && x != selected).FirstOrDefault() == null)
                    {
                        if (form.SectionName != "")
                        {
                            selected.Text = form.SectionName;
                            selected.SortCode = form.SortCode;
                            saved = false;
                        }
                        else
                            MessageBox.Show("Подраздел должен иметь непустое имя!", "Некорреткное название раздела",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Подраздел с данным именем уже существует!", "Некорреткное название раздела",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ToolStripMenuItemProductAdd_Click(object sender, EventArgs e)
        {
            var selected = (Section)TreeViewSections.SelectedNode;
            if (selected != null)
            {
                var form = new FormProduct();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var product = new Product()
                    {
                        Name = form.ProductName,
                        VendorCode = form.ProductVendoreCode,
                        Price = form.ProductPrice,
                        StockBalance = form.ProductStockBalance,
                        Description = form.ProductDescription,
                        Image = form.ProductImage
                    };

                    product.Section = selected;
                    selected.Products.Add(product);
                    UpdateProductList();
                    saved = false;
                }
            }
        }

        private void TreeViewSections_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selected = (Section)TreeViewSections.SelectedNode;
            if (selected != null)
            {
                ToolStripMenuItemSectionEdit.Enabled = true;
                ToolStripMenuItemSectionRemove.Enabled = true;
                ToolStripMenuItemProductAdd.Enabled = true;

                UpdateProductList();
            }
            else
            {
                ToolStripMenuItemSectionEdit.Enabled = false;
                ToolStripMenuItemSectionRemove.Enabled = false;
                ToolStripMenuItemProductAdd.Enabled = false;
                DataGridViewProducts.DataSource = null;
            }
        }

        private void DataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewProducts.SelectedRows.Count > 0)
            {
                ToolStripMenuItemProductRemove.Enabled = true;
                ToolStripMenuItemProductEdit.Enabled = true;
            }
            else
            {
                ToolStripMenuItemProductRemove.Enabled = false;
                ToolStripMenuItemProductEdit.Enabled = false;
            }
        }

        private void ToolStripMenuItemSectionAdd_Click(object sender, EventArgs e)
        {
            var selected = (Section)TreeViewSections.SelectedNode;
            if (selected != null)
                ToolStripMenuItemAddSubsection_Click(this, EventArgs.Empty);
            else
                ToolStripMenuItemAddSection_Click(this, EventArgs.Empty);
        }

        private Product GetProductById(Section section, int id)
        {
            var product = section.Products.Where(x => x.Id == id).FirstOrDefault();
            if (product != null)
                return product;
            foreach (Section subSection in section.Nodes)
            {
                product = GetProductById(subSection, id);
                if (product != null)
                    return product;
            }
            return null;
        }

        private Product GetProductById(int id)
        {
            foreach (var section in sections)
            {
                var product = GetProductById(section, id);
                if (product != null)
                    return product;
            }
            return null;
        }

        private void ToolStripMenuItemProductEdit_Click(object sender, EventArgs e)
        {
            var selectedRow = DataGridViewProducts.SelectedRows[0];
            var selectedProduct = GetProductById(int.Parse(selectedRow.Cells[0].Value.ToString()));
            var section = selectedProduct.Section;

            if (section != null)
            {
                var form = new FormProduct()
                {
                    ProductName = selectedProduct.Name,
                    ProductVendoreCode = selectedProduct.VendorCode,
                    ProductPrice = selectedProduct.Price,
                    ProductStockBalance = selectedProduct.StockBalance,
                    ProductDescription = selectedProduct.Description,
                    ProductImage = selectedProduct.Image
                };
                if (form.ShowDialog() == DialogResult.OK)
                {
                    selectedProduct.Name = form.ProductName;
                    selectedProduct.VendorCode = form.ProductVendoreCode;
                    selectedProduct.Price = form.ProductPrice;
                    selectedProduct.StockBalance = form.ProductStockBalance;
                    selectedProduct.Description = form.ProductDescription;
                    selectedProduct.Image = form.ProductImage;
                    UpdateProductList();
                    saved = false;
                }
            }
        }

        private void ToolStripMenuItemProductRemove_Click(object sender, EventArgs e)
        {
            var selectedRow = DataGridViewProducts.SelectedRows[0];
            var selectedProduct = GetProductById(int.Parse(selectedRow.Cells[0].Value.ToString()));
            var section = selectedProduct.Section;
            section.Products.Remove(selectedProduct);
            UpdateProductList();
        }

        private void DataGridViewProducts_DoubleClick(object sender, EventArgs e)
        {
            if (DataGridViewProducts.SelectedRows.Count > 0)
                ToolStripMenuItemProductEdit_Click(this, EventArgs.Empty);
        }

        private void CheckBoxShowSubsectionProducts_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProductList();
        }

        private void MenuItemFileSaveAs_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Json Файл (*.json) | *.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var converter = new SectionConverter();
                var serializer = new JsonSerializer();
                serializer.Converters.Add(converter);
                serializer.NullValueHandling = NullValueHandling.Ignore;
                using (StreamWriter sw = new StreamWriter(dialog.FileName))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw) { Formatting = Newtonsoft.Json.Formatting.Indented })
                    {
                        serializer.Serialize(writer, sections);
                    }
                }
                saved = true;
                path = dialog.FileName;
            }
        }

        private void MenuItemFileIOpen_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                var answer = MessageBox.Show("Желаете сохранить предыдущий файл перед открытием нового?", "Файл не сохранен!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.OK)
                    MenuItemFileSave_Click(this, EventArgs.Empty);
                else if (answer == DialogResult.Cancel)
                    return;
            }

            var dialog = new OpenFileDialog();
            dialog.Filter = "Json Файл (*.json) | *.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                JsonSerializer serializer = new JsonSerializer();
                var sectionConverter = new SectionConverter();
                serializer.Converters.Add(sectionConverter);
                serializer.NullValueHandling = NullValueHandling.Ignore;
                using (StreamReader sr = new StreamReader(dialog.FileName))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        sections = sectionConverter.LoadSections(reader, serializer);
                        UpdateSectionsTree();
                        UpdateProductList();
                    }
                }
            }
            saved = true;
        }

        private void MenuItemFileSave_Click(object sender, EventArgs e)
        {
            if (path == "")
                MenuItemFileSaveAs_Click(this, EventArgs.Empty);
            else
            {
                var converter = new SectionConverter();
                var serializer = new JsonSerializer();
                serializer.Converters.Add(converter);
                serializer.NullValueHandling = NullValueHandling.Ignore;
                using (StreamWriter sw = new StreamWriter(path))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw) { Formatting = Newtonsoft.Json.Formatting.Indented })
                    {
                        serializer.Serialize(writer, sections);
                    }
                }
                saved = true;
            }
        }

        private void MenuItemFileNew_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                var answer = MessageBox.Show("Желаете сохранить предыдущий файл перед созданием нового?", "Файл не сохранен!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.OK)
                    MenuItemFileSave_Click(this, EventArgs.Empty);
                else if (answer == DialogResult.Cancel)
                    return;
            }
            sections.Clear();
            UpdateSectionsTree();
            UpdateProductList();
            path = "";
            saved = true;
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                var answer = MessageBox.Show("Желаете сохранить предыдущий файл перед завершиением работы?", "Файл не сохранен!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.OK)
                    MenuItemFileSave_Click(this, EventArgs.Empty);
                else if (answer == DialogResult.Cancel)
                    return;
            }
            Close();
        }

        private void ToolStripMenuItemReport_Click(object sender, EventArgs e)
        {
            var dialog = new FormReport(sections);
            dialog.ShowDialog();
        }


        private void CodeSort(Section section)
        {
            for (int i = 0; i < section.Nodes.Count - 1; i++)
            {
                for (int j = 0; j < section.Nodes.Count - i - 1; j++)
                {
                    if (((Section)section.Nodes[j + 1]).SortCode < ((Section)section.Nodes[j]).SortCode ||
                        (((Section)section.Nodes[j + 1]).SortCode == ((Section)section.Nodes[j]).SortCode &&
                        ((Section)section.Nodes[j + 1]).Name.CompareTo(((Section)section.Nodes[j]).Name) < 0))
                    {
                        var temp = section.Nodes[j + 1];
                        section.Nodes[j + 1] = section.Nodes[j];
                        section.Nodes[j] = temp;
                    }
                }
            }

            foreach (Section subsection in section.Nodes)
                CodeSort(subsection);
        }

        private void ToolStripMenuItemCodeSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sections.Count - 1; i++)
            {
                for (int j = 0; j < sections.Count - i - 1; j++)
                {
                    if (sections[j + 1].SortCode < sections[j].SortCode ||
                        ((sections[j + 1]).SortCode == (sections[j]).SortCode &&
                        (sections[j + 1]).Name.CompareTo((sections[j]).Name) < 0))
                    {
                        var temp = sections[j + 1];
                        sections[j + 1] = sections[j];
                        sections[j] = temp;
                    }
                }
            }

            foreach (var section in sections)
                CodeSort(section);

            UpdateSectionsTree();
        }

        private void LettersSort(Section section)
        {
            for (int i = 0; i < section.Nodes.Count - 1; i++)
            {
                for (int j = 0; j < section.Nodes.Count - i - 1; j++)
                {
                    if (((Section)section.Nodes[j + 1]).Name.CompareTo(((Section)section.Nodes[j]).Name) < 0)
                    {
                        var temp = section.Nodes[j + 1];
                        section.Nodes[j + 1] = section.Nodes[j];
                        section.Nodes[j] = temp;
                    }
                }
            }

            foreach (Section subsection in section.Nodes)
                CodeSort(subsection);
        }

        private void ToolStripMenuItemLetterSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sections.Count - 1; i++)
            {
                for (int j = 0; j < sections.Count - i - 1; j++)
                {
                    if (sections[j + 1].Name.CompareTo((sections[j]).Name) < 0)
                    {
                        var temp = sections[j + 1];
                        sections[j + 1] = sections[j];
                        sections[j] = temp;
                    }
                }
            }

            foreach (var section in sections)
                LettersSort(section);

            UpdateSectionsTree();
        }

        private void ToolStripMenuItemRandomGeneration_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                var answer = MessageBox.Show("Желаете сохранить предыдущий файл перед генерацией?", "Файл не сохранен!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.OK)
                    MenuItemFileSave_Click(this, EventArgs.Empty);
                else if (answer == DialogResult.Cancel)
                    return;
            }
            var dialog = new RandomForm();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sections = dialog.Sections;
                UpdateSectionsTree();
                UpdateProductList();
                saved = false;
                path = "";
            }
        }
    }
}
