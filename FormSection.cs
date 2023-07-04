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
    public partial class FormSection : Form
    {
        public string SectionName
        {
            set { TextBoxName.Text = value; ButtonAdd.Text = "Изменить"; }
            get => TextBoxName.Text;
        }

        public int SortCode
        {
            set { NumericUpDownSortCode.Value = value; ButtonAdd.Text = "Изменить"; }
            get => (int)NumericUpDownSortCode.Value;
        }

        public FormSection()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            SectionName = TextBoxName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
