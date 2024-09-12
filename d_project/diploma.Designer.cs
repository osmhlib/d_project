using System.Windows.Forms;

namespace d_project
{
    partial class Diploma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diploma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиБазуДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиCompletedOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.експортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.експортуватиOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.експортуватиcompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиРезервнуКопіюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поточніЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виконаніЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скасуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.materialButtonComplete = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.customDataGridView2 = new CustomDataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrepaymentColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch1 = new System.Windows.Forms.TextBox();
            this.customDataGridView1 = new CustomDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prepayment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customDatePicker1 = new CustomDatePicker();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonWrite = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxCost = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxModel = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add_24dp_FILL0_wght500_GRAD200_opsz24.png");
            this.imageList1.Images.SetKeyName(1, "wysiwyg_24dp_FILL0_wght500_GRAD0_opsz24.png");
            this.imageList1.Images.SetKeyName(2, "edit_24dp_FILL0_wght500_GRAD0_opsz24.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.переглядToolStripMenuItem,
            this.скасуватиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 79);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1459, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.очиститиБазуДанихToolStripMenuItem,
            this.експортToolStripMenuItem,
            this.створитиРезервнуКопіюToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Image = global::d_project.Properties.Resources.floppy;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Image = global::d_project.Properties.Resources.open;
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(340, 28);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // очиститиБазуДанихToolStripMenuItem
            // 
            this.очиститиБазуДанихToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститиOrdersToolStripMenuItem,
            this.очиститиCompletedOrdersToolStripMenuItem});
            this.очиститиБазуДанихToolStripMenuItem.Image = global::d_project.Properties.Resources.clear;
            this.очиститиБазуДанихToolStripMenuItem.Name = "очиститиБазуДанихToolStripMenuItem";
            this.очиститиБазуДанихToolStripMenuItem.Size = new System.Drawing.Size(340, 28);
            this.очиститиБазуДанихToolStripMenuItem.Text = "Очистити базу даних";
            // 
            // очиститиOrdersToolStripMenuItem
            // 
            this.очиститиOrdersToolStripMenuItem.Name = "очиститиOrdersToolStripMenuItem";
            this.очиститиOrdersToolStripMenuItem.Size = new System.Drawing.Size(280, 28);
            this.очиститиOrdersToolStripMenuItem.Text = "Очистити поточні";
            this.очиститиOrdersToolStripMenuItem.Click += new System.EventHandler(this.очиститиПоточніToolStripMenuItem_Click);
            // 
            // очиститиCompletedOrdersToolStripMenuItem
            // 
            this.очиститиCompletedOrdersToolStripMenuItem.Name = "очиститиCompletedOrdersToolStripMenuItem";
            this.очиститиCompletedOrdersToolStripMenuItem.Size = new System.Drawing.Size(280, 28);
            this.очиститиCompletedOrdersToolStripMenuItem.Text = "Очистити виконані";
            this.очиститиCompletedOrdersToolStripMenuItem.Click += new System.EventHandler(this.очиститиВиконаніToolStripMenuItem_Click);
            // 
            // експортToolStripMenuItem
            // 
            this.експортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.експортуватиOrdersToolStripMenuItem,
            this.експортуватиcompletedToolStripMenuItem});
            this.експортToolStripMenuItem.Image = global::d_project.Properties.Resources.ios_share_24dp_FILL0_wght500_GRAD0_opsz24;
            this.експортToolStripMenuItem.Name = "експортToolStripMenuItem";
            this.експортToolStripMenuItem.Size = new System.Drawing.Size(340, 28);
            this.експортToolStripMenuItem.Text = "Експорт";
            // 
            // експортуватиOrdersToolStripMenuItem
            // 
            this.експортуватиOrdersToolStripMenuItem.Name = "експортуватиOrdersToolStripMenuItem";
            this.експортуватиOrdersToolStripMenuItem.Size = new System.Drawing.Size(317, 28);
            this.експортуватиOrdersToolStripMenuItem.Text = "Експортувати поточні";
            this.експортуватиOrdersToolStripMenuItem.Click += new System.EventHandler(this.експортуватиПоточніToolStripMenuItem_Click);
            // 
            // експортуватиcompletedToolStripMenuItem
            // 
            this.експортуватиcompletedToolStripMenuItem.Name = "експортуватиcompletedToolStripMenuItem";
            this.експортуватиcompletedToolStripMenuItem.Size = new System.Drawing.Size(317, 28);
            this.експортуватиcompletedToolStripMenuItem.Text = "Експортувати виконані";
            this.експортуватиcompletedToolStripMenuItem.Click += new System.EventHandler(this.експортуватиВиконаніToolStripMenuItem_Click);
            // 
            // створитиРезервнуКопіюToolStripMenuItem
            // 
            this.створитиРезервнуКопіюToolStripMenuItem.Image = global::d_project.Properties.Resources.backup_24;
            this.створитиРезервнуКопіюToolStripMenuItem.Name = "створитиРезервнуКопіюToolStripMenuItem";
            this.створитиРезервнуКопіюToolStripMenuItem.Size = new System.Drawing.Size(340, 28);
            this.створитиРезервнуКопіюToolStripMenuItem.Text = "Створити резервну копію";
            this.створитиРезервнуКопіюToolStripMenuItem.Click += new System.EventHandler(this.створитиРезервнуКопіюToolStripMenuItem_Click);
            // 
            // переглядToolStripMenuItem
            // 
            this.переглядToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поточніЗаявкиToolStripMenuItem,
            this.виконаніЗаявкиToolStripMenuItem});
            this.переглядToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.переглядToolStripMenuItem.Image = global::d_project.Properties.Resources.view;
            this.переглядToolStripMenuItem.Name = "переглядToolStripMenuItem";
            this.переглядToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.переглядToolStripMenuItem.Text = "Перегляд";
            // 
            // поточніЗаявкиToolStripMenuItem
            // 
            this.поточніЗаявкиToolStripMenuItem.Image = global::d_project.Properties.Resources.processing;
            this.поточніЗаявкиToolStripMenuItem.Name = "поточніЗаявкиToolStripMenuItem";
            this.поточніЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(256, 28);
            this.поточніЗаявкиToolStripMenuItem.Text = "Поточні заявки";
            this.поточніЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.поточніЗаявкиToolStripMenuItem_Click);
            // 
            // виконаніЗаявкиToolStripMenuItem
            // 
            this.виконаніЗаявкиToolStripMenuItem.Image = global::d_project.Properties.Resources.completed;
            this.виконаніЗаявкиToolStripMenuItem.Name = "виконаніЗаявкиToolStripMenuItem";
            this.виконаніЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(256, 28);
            this.виконаніЗаявкиToolStripMenuItem.Text = "Виконані заявки";
            this.виконаніЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.виконаніЗаявкиToolStripMenuItem_Click);
            // 
            // скасуватиToolStripMenuItem
            // 
            this.скасуватиToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.скасуватиToolStripMenuItem.Image = global::d_project.Properties.Resources.undo;
            this.скасуватиToolStripMenuItem.Name = "скасуватиToolStripMenuItem";
            this.скасуватиToolStripMenuItem.Size = new System.Drawing.Size(142, 28);
            this.скасуватиToolStripMenuItem.Text = "Скасувати";
            this.скасуватиToolStripMenuItem.Click += new System.EventHandler(this.скасуватиToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.textBoxSearch2);
            this.tabPage3.Controls.Add(this.materialButtonComplete);
            this.tabPage3.Controls.Add(this.materialButtonDelete);
            this.tabPage3.Controls.Add(this.materialButtonSave);
            this.tabPage3.Controls.Add(this.customDataGridView2);
            this.tabPage3.ImageKey = "edit_24dp_FILL0_wght500_GRAD0_opsz24.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1451, 712);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Редагувати";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::d_project.Properties.Resources.icons8_search_22;
            this.pictureBox2.Location = new System.Drawing.Point(1133, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearch2.Location = new System.Drawing.Point(1168, 0);
            this.textBoxSearch2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 4);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(265, 26);
            this.textBoxSearch2.TabIndex = 13;
            this.textBoxSearch2.TextChanged += new System.EventHandler(this.textBoxSearch2_TextChanged);
            // 
            // materialButtonComplete
            // 
            this.materialButtonComplete.AutoSize = false;
            this.materialButtonComplete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonComplete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonComplete.Depth = 0;
            this.materialButtonComplete.HighEmphasis = true;
            this.materialButtonComplete.Icon = null;
            this.materialButtonComplete.Location = new System.Drawing.Point(1053, 610);
            this.materialButtonComplete.Margin = new System.Windows.Forms.Padding(5, 7, 133, 7);
            this.materialButtonComplete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonComplete.Name = "materialButtonComplete";
            this.materialButtonComplete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonComplete.Size = new System.Drawing.Size(267, 92);
            this.materialButtonComplete.TabIndex = 12;
            this.materialButtonComplete.Text = "Позначити як виконану";
            this.materialButtonComplete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonComplete.UseAccentColor = false;
            this.materialButtonComplete.UseVisualStyleBackColor = true;
            this.materialButtonComplete.Click += new System.EventHandler(this.materialButtonComplete_Click);
            // 
            // materialButtonDelete
            // 
            this.materialButtonDelete.AutoSize = false;
            this.materialButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDelete.Depth = 0;
            this.materialButtonDelete.HighEmphasis = true;
            this.materialButtonDelete.Icon = null;
            this.materialButtonDelete.Location = new System.Drawing.Point(776, 610);
            this.materialButtonDelete.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDelete.Name = "materialButtonDelete";
            this.materialButtonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDelete.Size = new System.Drawing.Size(267, 92);
            this.materialButtonDelete.TabIndex = 11;
            this.materialButtonDelete.Text = "Видалити заявку";
            this.materialButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDelete.UseAccentColor = false;
            this.materialButtonDelete.UseVisualStyleBackColor = true;
            this.materialButtonDelete.Click += new System.EventHandler(this.materialButtonDelete_Click);
            // 
            // materialButtonSave
            // 
            this.materialButtonSave.AutoSize = false;
            this.materialButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSave.Depth = 0;
            this.materialButtonSave.HighEmphasis = true;
            this.materialButtonSave.Icon = null;
            this.materialButtonSave.Location = new System.Drawing.Point(67, 610);
            this.materialButtonSave.Margin = new System.Windows.Forms.Padding(67, 7, 5, 7);
            this.materialButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSave.Name = "materialButtonSave";
            this.materialButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSave.Size = new System.Drawing.Size(267, 92);
            this.materialButtonSave.TabIndex = 10;
            this.materialButtonSave.Text = "Зберегти зміни";
            this.materialButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSave.UseAccentColor = false;
            this.materialButtonSave.UseVisualStyleBackColor = true;
            this.materialButtonSave.Click += new System.EventHandler(this.materialButtonSave_Click);
            // 
            // customDataGridView2
            // 
            this.customDataGridView2.AllowUserToAddRows = false;
            this.customDataGridView2.AllowUserToDeleteRows = false;
            this.customDataGridView2.AllowUserToResizeColumns = false;
            this.customDataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.customDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customDataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.customDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.ModelColumn,
            this.ClientColumn,
            this.NumberColumn,
            this.ServiceColumn,
            this.CostColumn,
            this.DateColumn,
            this.PrepaymentColumn});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customDataGridView2.DefaultCellStyle = dataGridViewCellStyle10;
            this.customDataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.customDataGridView2.EnableHeadersVisualStyles = false;
            this.customDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.customDataGridView2.Location = new System.Drawing.Point(13, 34);
            this.customDataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.customDataGridView2.Name = "customDataGridView2";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.customDataGridView2.RowHeadersVisible = false;
            this.customDataGridView2.RowHeadersWidth = 51;
            this.customDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.customDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView2.Size = new System.Drawing.Size(1421, 565);
            this.customDataGridView2.TabIndex = 9;
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdColumn.FillWeight = 1F;
            this.IdColumn.HeaderText = "№";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdColumn.Width = 54;
            // 
            // ModelColumn
            // 
            this.ModelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModelColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ModelColumn.FillWeight = 0.3F;
            this.ModelColumn.HeaderText = "Модель";
            this.ModelColumn.MinimumWidth = 6;
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClientColumn
            // 
            this.ClientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClientColumn.FillWeight = 0.5F;
            this.ClientColumn.HeaderText = "П.І.Б.";
            this.ClientColumn.MinimumWidth = 6;
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NumberColumn
            // 
            this.NumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NumberColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.NumberColumn.FillWeight = 0.225F;
            this.NumberColumn.HeaderText = "Мобільний телефон";
            this.NumberColumn.MinimumWidth = 6;
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumberColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ServiceColumn
            // 
            this.ServiceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ServiceColumn.FillWeight = 0.5F;
            this.ServiceColumn.HeaderText = "Послуга";
            this.ServiceColumn.Items.AddRange(new object[] {
            "<...>",
            "Відновлення даних",
            "Встановлення ОС",
            "Діагностика",
            "Заміна HDD/SSD",
            "Заміна батареї ",
            "Заміна БЖ",
            "Заміна сист. охолодження",
            "Заміна термопасти",
            "Налаштування ПЗ",
            "Оновлення BIOS",
            "Оновлення драйверів",
            "Ремонт БЖ",
            "Ремонт мат. плати",
            "Ремонт/заміна відеокарти",
            "Ремонт/заміна дисплею ",
            "Ремонт/заміна звукової карти",
            "Ремонт/заміна клавіатури",
            "Ремонт/заміна ОЗУ",
            "Форматування диска",
            "Чистка від пилу"});
            this.ServiceColumn.MinimumWidth = 6;
            this.ServiceColumn.Name = "ServiceColumn";
            this.ServiceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CostColumn
            // 
            this.CostColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.CostColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.CostColumn.FillWeight = 1F;
            this.CostColumn.HeaderText = "Вартість";
            this.CostColumn.MinimumWidth = 6;
            this.CostColumn.Name = "CostColumn";
            this.CostColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CostColumn.Width = 113;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.DateColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.DateColumn.FillWeight = 0.2F;
            this.DateColumn.HeaderText = "Дата прийому";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PrepaymentColumn
            // 
            this.PrepaymentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PrepaymentColumn.FillWeight = 1F;
            this.PrepaymentColumn.HeaderText = "Передплата";
            this.PrepaymentColumn.MinimumWidth = 6;
            this.PrepaymentColumn.Name = "PrepaymentColumn";
            this.PrepaymentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrepaymentColumn.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.textBoxSearch1);
            this.tabPage2.Controls.Add(this.customDataGridView1);
            this.tabPage2.ImageKey = "wysiwyg_24dp_FILL0_wght500_GRAD0_opsz24.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tabPage2.Size = new System.Drawing.Size(1451, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Переглянути";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::d_project.Properties.Resources.icons8_search_22;
            this.pictureBox1.Location = new System.Drawing.Point(1133, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSearch1
            // 
            this.textBoxSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch1.Location = new System.Drawing.Point(1168, 0);
            this.textBoxSearch1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 4);
            this.textBoxSearch1.Name = "textBoxSearch1";
            this.textBoxSearch1.Size = new System.Drawing.Size(265, 26);
            this.textBoxSearch1.TabIndex = 2;
            this.textBoxSearch1.TabStop = false;
            this.textBoxSearch1.TextChanged += new System.EventHandler(this.textBoxSearch1_TextChanged);
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.AllowUserToAddRows = false;
            this.customDataGridView1.AllowUserToDeleteRows = false;
            this.customDataGridView1.AllowUserToResizeColumns = false;
            this.customDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.customDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.customDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.customDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Model,
            this.ClientName,
            this.Number,
            this.ServiceType,
            this.Cost,
            this.ReceptionDate,
            this.Prepayment});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView1.DefaultCellStyle = dataGridViewCellStyle22;
            this.customDataGridView1.EnableHeadersVisualStyles = false;
            this.customDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.customDataGridView1.Location = new System.Drawing.Point(13, 34);
            this.customDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.ReadOnly = true;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.customDataGridView1.RowHeadersVisible = false;
            this.customDataGridView1.RowHeadersWidth = 51;
            this.customDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView1.Size = new System.Drawing.Size(1421, 651);
            this.customDataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle15;
            this.Id.FillWeight = 1F;
            this.Id.HeaderText = "№";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 54;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Model.DefaultCellStyle = dataGridViewCellStyle16;
            this.Model.FillWeight = 0.3F;
            this.Model.HeaderText = "Модель";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientName.DefaultCellStyle = dataGridViewCellStyle17;
            this.ClientName.FillWeight = 0.5F;
            this.ClientName.HeaderText = "П.І.Б.";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number.DefaultCellStyle = dataGridViewCellStyle18;
            this.Number.FillWeight = 0.225F;
            this.Number.HeaderText = "Мобільний телефон";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ServiceType
            // 
            this.ServiceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceType.DefaultCellStyle = dataGridViewCellStyle19;
            this.ServiceType.FillWeight = 0.5F;
            this.ServiceType.HeaderText = "Послуга";
            this.ServiceType.MinimumWidth = 6;
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.ReadOnly = true;
            this.ServiceType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "C2";
            dataGridViewCellStyle20.NullValue = null;
            this.Cost.DefaultCellStyle = dataGridViewCellStyle20;
            this.Cost.FillWeight = 1F;
            this.Cost.HeaderText = "Вартість";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cost.Width = 113;
            // 
            // ReceptionDate
            // 
            this.ReceptionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "d";
            dataGridViewCellStyle21.NullValue = null;
            this.ReceptionDate.DefaultCellStyle = dataGridViewCellStyle21;
            this.ReceptionDate.FillWeight = 0.2F;
            this.ReceptionDate.HeaderText = "Дата прийому";
            this.ReceptionDate.MinimumWidth = 6;
            this.ReceptionDate.Name = "ReceptionDate";
            this.ReceptionDate.ReadOnly = true;
            this.ReceptionDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReceptionDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Prepayment
            // 
            this.Prepayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Prepayment.FillWeight = 1F;
            this.Prepayment.HeaderText = "Передплата";
            this.Prepayment.MinimumWidth = 6;
            this.Prepayment.Name = "Prepayment";
            this.Prepayment.ReadOnly = true;
            this.Prepayment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prepayment.Width = 120;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customDatePicker1);
            this.tabPage1.Controls.Add(this.materialComboBox1);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialButtonWrite);
            this.tabPage1.Controls.Add(this.materialTextBoxCost);
            this.tabPage1.Controls.Add(this.materialTextBoxNumber);
            this.tabPage1.Controls.Add(this.materialTextBoxName);
            this.tabPage1.Controls.Add(this.materialTextBoxModel);
            this.tabPage1.Controls.Add(this.materialCheckbox1);
            this.tabPage1.ImageKey = "add_24dp_FILL0_wght500_GRAD200_opsz24.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1451, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Додати заявку";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customDatePicker1
            // 
            this.customDatePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.customDatePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.customDatePicker1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.customDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDatePicker1.Location = new System.Drawing.Point(947, 60);
            this.customDatePicker1.Margin = new System.Windows.Forms.Padding(53, 4, 4, 4);
            this.customDatePicker1.MinimumSize = new System.Drawing.Size(4, 50);
            this.customDatePicker1.Name = "customDatePicker1";
            this.customDatePicker1.Size = new System.Drawing.Size(212, 50);
            this.customDatePicker1.TabIndex = 17;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = true;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 294;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "<...>",
            "Відновлення даних",
            "Встановлення ОС",
            "Діагностика",
            "Заміна HDD/SSD",
            "Заміна батареї ",
            "Заміна БЖ",
            "Заміна сист. охолодження",
            "Заміна термопасти",
            "Налаштування ПЗ",
            "Оновлення BIOS",
            "Оновлення драйверів",
            "Ремонт БЖ",
            "Ремонт мат. плати",
            "Ремонт/заміна відеокарти",
            "Ремонт/заміна дисплею ",
            "Ремонт/заміна звукової карти",
            "Ремонт/заміна клавіатури",
            "Ремонт/заміна ОЗУ",
            "Форматування диска",
            "Чистка від пилу"});
            this.materialComboBox1.Location = new System.Drawing.Point(493, 62);
            this.materialComboBox1.Margin = new System.Windows.Forms.Padding(53, 4, 13, 4);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(294, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 16;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(493, 21);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(77, 24);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Послуга";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(947, 18);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(133, 24);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Дата прийому";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(27, 393);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(0, 12, 13, 4);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(236, 24);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Вартість обслуговування";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(27, 270);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(0, 12, 13, 4);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(188, 24);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Мобільний телефон";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(27, 146);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(0, 12, 13, 4);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 24);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "П.І.Б.";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(27, 25);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(27, 25, 13, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(172, 24);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Модель пристрою";
            // 
            // materialButtonWrite
            // 
            this.materialButtonWrite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonWrite.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonWrite.Depth = 0;
            this.materialButtonWrite.HighEmphasis = true;
            this.materialButtonWrite.Icon = null;
            this.materialButtonWrite.Location = new System.Drawing.Point(1053, 610);
            this.materialButtonWrite.Margin = new System.Windows.Forms.Padding(5, 7, 133, 25);
            this.materialButtonWrite.MinimumSize = new System.Drawing.Size(267, 92);
            this.materialButtonWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonWrite.Name = "materialButtonWrite";
            this.materialButtonWrite.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonWrite.Size = new System.Drawing.Size(267, 92);
            this.materialButtonWrite.TabIndex = 7;
            this.materialButtonWrite.Text = "Додати заявку";
            this.materialButtonWrite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonWrite.UseAccentColor = false;
            this.materialButtonWrite.UseVisualStyleBackColor = true;
            this.materialButtonWrite.Click += new System.EventHandler(this.materialButtonWrite_Click);
            // 
            // materialTextBoxCost
            // 
            this.materialTextBoxCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBoxCost.AnimateReadOnly = false;
            this.materialTextBoxCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxCost.Depth = 0;
            this.materialTextBoxCost.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxCost.LeadingIcon = null;
            this.materialTextBoxCost.Location = new System.Drawing.Point(27, 430);
            this.materialTextBoxCost.Margin = new System.Windows.Forms.Padding(0, 4, 13, 12);
            this.materialTextBoxCost.MaxLength = 50;
            this.materialTextBoxCost.MinimumSize = new System.Drawing.Size(400, 62);
            this.materialTextBoxCost.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxCost.Multiline = false;
            this.materialTextBoxCost.Name = "materialTextBoxCost";
            this.materialTextBoxCost.Size = new System.Drawing.Size(400, 62);
            this.materialTextBoxCost.TabIndex = 3;
            this.materialTextBoxCost.Text = "";
            this.materialTextBoxCost.TrailingIcon = null;
            // 
            // materialTextBoxNumber
            // 
            this.materialTextBoxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBoxNumber.AnimateReadOnly = false;
            this.materialTextBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxNumber.Depth = 0;
            this.materialTextBoxNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxNumber.LeadingIcon = null;
            this.materialTextBoxNumber.Location = new System.Drawing.Point(27, 306);
            this.materialTextBoxNumber.Margin = new System.Windows.Forms.Padding(0, 4, 13, 12);
            this.materialTextBoxNumber.MaxLength = 50;
            this.materialTextBoxNumber.MinimumSize = new System.Drawing.Size(400, 62);
            this.materialTextBoxNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxNumber.Multiline = false;
            this.materialTextBoxNumber.Name = "materialTextBoxNumber";
            this.materialTextBoxNumber.Size = new System.Drawing.Size(400, 62);
            this.materialTextBoxNumber.TabIndex = 2;
            this.materialTextBoxNumber.Text = "";
            this.materialTextBoxNumber.TrailingIcon = null;
            // 
            // materialTextBoxName
            // 
            this.materialTextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBoxName.AnimateReadOnly = false;
            this.materialTextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxName.Depth = 0;
            this.materialTextBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxName.LeadingIcon = null;
            this.materialTextBoxName.Location = new System.Drawing.Point(27, 183);
            this.materialTextBoxName.Margin = new System.Windows.Forms.Padding(0, 4, 13, 12);
            this.materialTextBoxName.MaxLength = 50;
            this.materialTextBoxName.MinimumSize = new System.Drawing.Size(400, 62);
            this.materialTextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxName.Multiline = false;
            this.materialTextBoxName.Name = "materialTextBoxName";
            this.materialTextBoxName.Size = new System.Drawing.Size(400, 62);
            this.materialTextBoxName.TabIndex = 1;
            this.materialTextBoxName.Text = "";
            this.materialTextBoxName.TrailingIcon = null;
            // 
            // materialTextBoxModel
            // 
            this.materialTextBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBoxModel.AnimateReadOnly = false;
            this.materialTextBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxModel.Depth = 0;
            this.materialTextBoxModel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxModel.LeadingIcon = null;
            this.materialTextBoxModel.Location = new System.Drawing.Point(27, 60);
            this.materialTextBoxModel.Margin = new System.Windows.Forms.Padding(0, 4, 13, 12);
            this.materialTextBoxModel.MaxLength = 50;
            this.materialTextBoxModel.MinimumSize = new System.Drawing.Size(400, 62);
            this.materialTextBoxModel.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxModel.Multiline = false;
            this.materialTextBoxModel.Name = "materialTextBoxModel";
            this.materialTextBoxModel.Size = new System.Drawing.Size(400, 62);
            this.materialTextBoxModel.TabIndex = 0;
            this.materialTextBoxModel.Text = "";
            this.materialTextBoxModel.TrailingIcon = null;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialCheckbox1.Location = new System.Drawing.Point(499, 430);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(167, 46);
            this.materialCheckbox1.TabIndex = 5;
            this.materialCheckbox1.Text = "Передплата";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(4, 111);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1459, 747);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Diploma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 862);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1467, 862);
            this.MinimumSize = new System.Drawing.Size(1467, 822);
            this.Name = "Diploma";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.diploma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
  

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem переглядToolStripMenuItem;
        private ToolStripMenuItem поточніЗаявкиToolStripMenuItem;
        private ToolStripMenuItem виконаніЗаявкиToolStripMenuItem;
        private ToolStripMenuItem скасуватиToolStripMenuItem;
        private ToolStripMenuItem очиститиБазуДанихToolStripMenuItem;
        private ToolStripMenuItem очиститиOrdersToolStripMenuItem;
        private ToolStripMenuItem очиститиCompletedOrdersToolStripMenuItem;
        private ToolStripMenuItem експортToolStripMenuItem;
        private TabPage tabPage3;
        private MaterialSkin.Controls.MaterialButton materialButtonComplete;
        private MaterialSkin.Controls.MaterialButton materialButtonDelete;
        private MaterialSkin.Controls.MaterialButton materialButtonSave;
        private CustomDataGridView customDataGridView2;
        private TabPage tabPage2;
        private CustomDataGridView customDataGridView1;
        private TabPage tabPage1;
        private CustomDatePicker customDatePicker1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButtonWrite;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxCost;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxNumber;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxName;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxModel;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private ToolStripMenuItem експортуватиOrdersToolStripMenuItem;
        private ToolStripMenuItem експортуватиcompletedToolStripMenuItem;
        private ToolStripMenuItem створитиРезервнуКопіюToolStripMenuItem;
        private TextBox textBoxSearch1;
        private PictureBox pictureBox1;
        private TextBox textBoxSearch2;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn ServiceType;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn ReceptionDate;
        private DataGridViewCheckBoxColumn Prepayment;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn ModelColumn;
        private DataGridViewTextBoxColumn ClientColumn;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewComboBoxColumn ServiceColumn;
        private DataGridViewTextBoxColumn CostColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewCheckBoxColumn PrepaymentColumn;
    }
}

