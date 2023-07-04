
namespace Warehouse
{
    partial class FormWarehouse
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TreeViewSections = new System.Windows.Forms.TreeView();
            this.ContextMenuStripSections = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemAddSection = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.ColumnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductVecdorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductStockBalanse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileIOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.разделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSectionAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSectionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSectionRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProductAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProductEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProductRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripTreeNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemAddSubsection = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditSection = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRemoveSection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CheckBoxShowSubsectionProducts = new System.Windows.Forms.CheckBox();
            this.ToolStripMenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemCodeSort = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLetterSort = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRandomGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripSections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.ContextMenuStripTreeNode.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeViewSections
            // 
            this.TreeViewSections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeViewSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewSections.Location = new System.Drawing.Point(0, 6);
            this.TreeViewSections.Name = "TreeViewSections";
            this.TreeViewSections.Size = new System.Drawing.Size(198, 487);
            this.TreeViewSections.TabIndex = 0;
            this.TreeViewSections.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewSections_AfterSelect);
            this.TreeViewSections.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeViewSections_MouseUp);
            // 
            // ContextMenuStripSections
            // 
            this.ContextMenuStripSections.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddSection});
            this.ContextMenuStripSections.Name = "ContextMenuStripSections";
            this.ContextMenuStripSections.Size = new System.Drawing.Size(167, 26);
            // 
            // ToolStripMenuItemAddSection
            // 
            this.ToolStripMenuItemAddSection.Name = "ToolStripMenuItemAddSection";
            this.ToolStripMenuItemAddSection.Size = new System.Drawing.Size(166, 22);
            this.ToolStripMenuItemAddSection.Text = "Добавить раздел";
            this.ToolStripMenuItemAddSection.Click += new System.EventHandler(this.ToolStripMenuItemAddSection_Click);
            // 
            // DataGridViewProducts
            // 
            this.DataGridViewProducts.AllowUserToAddRows = false;
            this.DataGridViewProducts.AllowUserToDeleteRows = false;
            this.DataGridViewProducts.AllowUserToResizeRows = false;
            this.DataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProductId,
            this.ColumnProductName,
            this.ColumnProductVecdorCode,
            this.ColumnProductPrice,
            this.ColumnProductStockBalanse});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewProducts.MultiSelect = false;
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.ReadOnly = true;
            this.DataGridViewProducts.RowHeadersVisible = false;
            this.DataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewProducts.Size = new System.Drawing.Size(501, 501);
            this.DataGridViewProducts.TabIndex = 1;
            this.DataGridViewProducts.SelectionChanged += new System.EventHandler(this.DataGridViewProducts_SelectionChanged);
            this.DataGridViewProducts.DoubleClick += new System.EventHandler(this.DataGridViewProducts_DoubleClick);
            // 
            // ColumnProductId
            // 
            this.ColumnProductId.DataPropertyName = "Id";
            this.ColumnProductId.HeaderText = "Id";
            this.ColumnProductId.Name = "ColumnProductId";
            this.ColumnProductId.ReadOnly = true;
            this.ColumnProductId.Visible = false;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnProductName.DataPropertyName = "Name";
            this.ColumnProductName.HeaderText = "Наименование";
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            this.ColumnProductName.Width = 116;
            // 
            // ColumnProductVecdorCode
            // 
            this.ColumnProductVecdorCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnProductVecdorCode.DataPropertyName = "VendorCode";
            this.ColumnProductVecdorCode.HeaderText = "Артикул";
            this.ColumnProductVecdorCode.Name = "ColumnProductVecdorCode";
            this.ColumnProductVecdorCode.ReadOnly = true;
            this.ColumnProductVecdorCode.Width = 77;
            // 
            // ColumnProductPrice
            // 
            this.ColumnProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnProductPrice.DataPropertyName = "Price";
            this.ColumnProductPrice.HeaderText = "Стоимость";
            this.ColumnProductPrice.Name = "ColumnProductPrice";
            this.ColumnProductPrice.ReadOnly = true;
            this.ColumnProductPrice.Width = 91;
            // 
            // ColumnProductStockBalanse
            // 
            this.ColumnProductStockBalanse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnProductStockBalanse.DataPropertyName = "StockBalance";
            this.ColumnProductStockBalanse.HeaderText = "Остаток на складе";
            this.ColumnProductStockBalanse.Name = "ColumnProductStockBalanse";
            this.ColumnProductStockBalanse.ReadOnly = true;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer.Location = new System.Drawing.Point(0, 24);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.SplitContainer.Panel1.Controls.Add(this.panel1);
            this.SplitContainer.Panel1MinSize = 200;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.DataGridViewProducts);
            this.SplitContainer.Size = new System.Drawing.Size(705, 501);
            this.SplitContainer.SplitterDistance = 200;
            this.SplitContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TreeViewSections);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.panel1.Size = new System.Drawing.Size(200, 501);
            this.panel1.TabIndex = 1;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.разделыToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.ToolStripMenuItemReport,
            this.ToolStripMenuItemRandomGeneration,
            this.MenuItemHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(705, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.MenuItemFileIOpen,
            this.MenuItemFileSave,
            this.MenuItemFileSaveAs,
            this.MenuItemFileExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.MenuItemFile.Text = "Файл";
            // 
            // MenuItemFileNew
            // 
            this.MenuItemFileNew.Name = "MenuItemFileNew";
            this.MenuItemFileNew.Size = new System.Drawing.Size(187, 22);
            this.MenuItemFileNew.Text = "Новый";
            this.MenuItemFileNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
            // 
            // MenuItemFileIOpen
            // 
            this.MenuItemFileIOpen.Name = "MenuItemFileIOpen";
            this.MenuItemFileIOpen.Size = new System.Drawing.Size(187, 22);
            this.MenuItemFileIOpen.Text = "Открыть";
            this.MenuItemFileIOpen.Click += new System.EventHandler(this.MenuItemFileIOpen_Click);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.Size = new System.Drawing.Size(187, 22);
            this.MenuItemFileSave.Text = "Сохранить";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // MenuItemFileSaveAs
            // 
            this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
            this.MenuItemFileSaveAs.Size = new System.Drawing.Size(187, 22);
            this.MenuItemFileSaveAs.Text = "Сохранить как ...";
            this.MenuItemFileSaveAs.Click += new System.EventHandler(this.MenuItemFileSaveAs_Click);
            // 
            // MenuItemFileExit
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            this.MenuItemFileExit.Size = new System.Drawing.Size(187, 22);
            this.MenuItemFileExit.Text = "Завершение работы";
            this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
            // 
            // разделыToolStripMenuItem
            // 
            this.разделыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSectionAdd,
            this.ToolStripMenuItemSectionEdit,
            this.ToolStripMenuItemSectionRemove,
            this.toolStripSeparator2,
            this.ToolStripMenuItemCodeSort,
            this.ToolStripMenuItemLetterSort});
            this.разделыToolStripMenuItem.Name = "разделыToolStripMenuItem";
            this.разделыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.разделыToolStripMenuItem.Text = "Разделы";
            // 
            // ToolStripMenuItemSectionAdd
            // 
            this.ToolStripMenuItemSectionAdd.Name = "ToolStripMenuItemSectionAdd";
            this.ToolStripMenuItemSectionAdd.Size = new System.Drawing.Size(265, 22);
            this.ToolStripMenuItemSectionAdd.Text = "Добавить";
            this.ToolStripMenuItemSectionAdd.Click += new System.EventHandler(this.ToolStripMenuItemSectionAdd_Click);
            // 
            // ToolStripMenuItemSectionEdit
            // 
            this.ToolStripMenuItemSectionEdit.Enabled = false;
            this.ToolStripMenuItemSectionEdit.Name = "ToolStripMenuItemSectionEdit";
            this.ToolStripMenuItemSectionEdit.Size = new System.Drawing.Size(265, 22);
            this.ToolStripMenuItemSectionEdit.Text = "Изменить";
            this.ToolStripMenuItemSectionEdit.Click += new System.EventHandler(this.ToolStripMenuItemEditSection_Click);
            // 
            // ToolStripMenuItemSectionRemove
            // 
            this.ToolStripMenuItemSectionRemove.Enabled = false;
            this.ToolStripMenuItemSectionRemove.Name = "ToolStripMenuItemSectionRemove";
            this.ToolStripMenuItemSectionRemove.Size = new System.Drawing.Size(265, 22);
            this.ToolStripMenuItemSectionRemove.Text = "Удалить";
            this.ToolStripMenuItemSectionRemove.Click += new System.EventHandler(this.ToolStripMenuItemRemoveSection_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemProductAdd,
            this.ToolStripMenuItemProductEdit,
            this.ToolStripMenuItemProductRemove});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // ToolStripMenuItemProductAdd
            // 
            this.ToolStripMenuItemProductAdd.Enabled = false;
            this.ToolStripMenuItemProductAdd.Name = "ToolStripMenuItemProductAdd";
            this.ToolStripMenuItemProductAdd.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemProductAdd.Text = "Добавить";
            this.ToolStripMenuItemProductAdd.Click += new System.EventHandler(this.ToolStripMenuItemProductAdd_Click);
            // 
            // ToolStripMenuItemProductEdit
            // 
            this.ToolStripMenuItemProductEdit.Enabled = false;
            this.ToolStripMenuItemProductEdit.Name = "ToolStripMenuItemProductEdit";
            this.ToolStripMenuItemProductEdit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemProductEdit.Text = "Изменить";
            this.ToolStripMenuItemProductEdit.Click += new System.EventHandler(this.ToolStripMenuItemProductEdit_Click);
            // 
            // ToolStripMenuItemProductRemove
            // 
            this.ToolStripMenuItemProductRemove.Enabled = false;
            this.ToolStripMenuItemProductRemove.Name = "ToolStripMenuItemProductRemove";
            this.ToolStripMenuItemProductRemove.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemProductRemove.Text = "Удалить";
            this.ToolStripMenuItemProductRemove.Click += new System.EventHandler(this.ToolStripMenuItemProductRemove_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(65, 20);
            this.MenuItemHelp.Text = "Справка";
            // 
            // ContextMenuStripTreeNode
            // 
            this.ContextMenuStripTreeNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddSubsection,
            this.ToolStripMenuItemEditSection,
            this.ToolStripMenuItemRemoveSection,
            this.toolStripSeparator1,
            this.ToolStripMenuItemAddProduct});
            this.ContextMenuStripTreeNode.Name = "ContextMenuStripSections";
            this.ContextMenuStripTreeNode.Size = new System.Drawing.Size(187, 98);
            // 
            // ToolStripMenuItemAddSubsection
            // 
            this.ToolStripMenuItemAddSubsection.Name = "ToolStripMenuItemAddSubsection";
            this.ToolStripMenuItemAddSubsection.Size = new System.Drawing.Size(186, 22);
            this.ToolStripMenuItemAddSubsection.Text = "Добавить подраздел";
            this.ToolStripMenuItemAddSubsection.Click += new System.EventHandler(this.ToolStripMenuItemAddSubsection_Click);
            // 
            // ToolStripMenuItemEditSection
            // 
            this.ToolStripMenuItemEditSection.Name = "ToolStripMenuItemEditSection";
            this.ToolStripMenuItemEditSection.Size = new System.Drawing.Size(186, 22);
            this.ToolStripMenuItemEditSection.Text = "Изменить раздел";
            this.ToolStripMenuItemEditSection.Click += new System.EventHandler(this.ToolStripMenuItemEditSection_Click);
            // 
            // ToolStripMenuItemRemoveSection
            // 
            this.ToolStripMenuItemRemoveSection.Name = "ToolStripMenuItemRemoveSection";
            this.ToolStripMenuItemRemoveSection.Size = new System.Drawing.Size(186, 22);
            this.ToolStripMenuItemRemoveSection.Text = "Удалить раздел";
            this.ToolStripMenuItemRemoveSection.Click += new System.EventHandler(this.ToolStripMenuItemRemoveSection_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // ToolStripMenuItemAddProduct
            // 
            this.ToolStripMenuItemAddProduct.Name = "ToolStripMenuItemAddProduct";
            this.ToolStripMenuItemAddProduct.Size = new System.Drawing.Size(186, 22);
            this.ToolStripMenuItemAddProduct.Text = "Добавить товар";
            this.ToolStripMenuItemAddProduct.Click += new System.EventHandler(this.ToolStripMenuItemProductAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CheckBoxShowSubsectionProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 25);
            this.panel2.TabIndex = 4;
            // 
            // CheckBoxShowSubsectionProducts
            // 
            this.CheckBoxShowSubsectionProducts.AutoSize = true;
            this.CheckBoxShowSubsectionProducts.Location = new System.Drawing.Point(12, 3);
            this.CheckBoxShowSubsectionProducts.Name = "CheckBoxShowSubsectionProducts";
            this.CheckBoxShowSubsectionProducts.Size = new System.Drawing.Size(231, 19);
            this.CheckBoxShowSubsectionProducts.TabIndex = 0;
            this.CheckBoxShowSubsectionProducts.Text = "Отображать товары из подразделов";
            this.CheckBoxShowSubsectionProducts.UseVisualStyleBackColor = true;
            this.CheckBoxShowSubsectionProducts.CheckedChanged += new System.EventHandler(this.CheckBoxShowSubsectionProducts_CheckedChanged);
            // 
            // ToolStripMenuItemReport
            // 
            this.ToolStripMenuItemReport.Name = "ToolStripMenuItemReport";
            this.ToolStripMenuItemReport.Size = new System.Drawing.Size(51, 20);
            this.ToolStripMenuItemReport.Text = "Отчет";
            this.ToolStripMenuItemReport.Click += new System.EventHandler(this.ToolStripMenuItemReport_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Серым выделены товары расположенные в подразделах.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(262, 6);
            // 
            // ToolStripMenuItemCodeSort
            // 
            this.ToolStripMenuItemCodeSort.Name = "ToolStripMenuItemCodeSort";
            this.ToolStripMenuItemCodeSort.Size = new System.Drawing.Size(265, 22);
            this.ToolStripMenuItemCodeSort.Text = "Отсортировать по коду";
            this.ToolStripMenuItemCodeSort.Click += new System.EventHandler(this.ToolStripMenuItemCodeSort_Click);
            // 
            // ToolStripMenuItemLetterSort
            // 
            this.ToolStripMenuItemLetterSort.Name = "ToolStripMenuItemLetterSort";
            this.ToolStripMenuItemLetterSort.Size = new System.Drawing.Size(265, 22);
            this.ToolStripMenuItemLetterSort.Text = "Отсортиролвать лексиграфически";
            this.ToolStripMenuItemLetterSort.Click += new System.EventHandler(this.ToolStripMenuItemLetterSort_Click);
            // 
            // ToolStripMenuItemRandomGeneration
            // 
            this.ToolStripMenuItemRandomGeneration.Name = "ToolStripMenuItemRandomGeneration";
            this.ToolStripMenuItemRandomGeneration.Size = new System.Drawing.Size(139, 20);
            this.ToolStripMenuItemRandomGeneration.Text = "Случайная генерация";
            this.ToolStripMenuItemRandomGeneration.Click += new System.EventHandler(this.ToolStripMenuItemRandomGeneration_Click);
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 550);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "FormWarehouse";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.ContextMenuStripSections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ContextMenuStripTreeNode.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewSections;
        private System.Windows.Forms.DataGridView DataGridViewProducts;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripSections;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddSection;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripTreeNode;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddSubsection;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRemoveSection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditSection;
        private System.Windows.Forms.ToolStripMenuItem разделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSectionAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSectionEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSectionRemove;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProductAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProductEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProductRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductVecdorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductStockBalanse;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileIOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CheckBoxShowSubsectionProducts;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCodeSort;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLetterSort;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRandomGeneration;
    }
}

