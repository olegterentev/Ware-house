using System.Drawing;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FormProduct : Form
    {
        public new string ProductName
        { 
            set { TextBoxName.Text = value; ButtonAdd.Text = "Изменить"; }
            get => TextBoxName.Text;
        }

        public string ProductVendoreCode
        {
            set { TextBoxVendorCode.Text = value; ButtonAdd.Text = "Изменить"; }
            get => TextBoxVendorCode.Text;
        }

        public float ProductPrice
        {
            set { NumericUpDownPrice.Value = (decimal)value; ButtonAdd.Text = "Изменить"; }
            get => (float)NumericUpDownPrice.Value;
        }

        public int ProductStockBalance
        {
            set { NumericUpDownStockBalance.Value = (decimal)value; ButtonAdd.Text = "Изменить"; }
            get => (int)NumericUpDownStockBalance.Value;
        }

        public string ProductDescription
        {
            set { TextBoxDescription.Text = value; ButtonAdd.Text = "Изменить"; }
            get => TextBoxDescription.Text;
        }

        public Bitmap ProductImage
        {
            set { PictureBoxImage.Image = value; ButtonAdd.Text = "Изменить"; }
            get => (Bitmap)PictureBoxImage.Image;
        }

        public FormProduct()
        {
            InitializeComponent();
        }

        private void ButtonImageSelect_Click(object sender, System.EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                PictureBoxImage.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void ButtonAdd_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
