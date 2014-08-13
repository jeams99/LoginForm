namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pathLabel;
            System.Windows.Forms.Label imgLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label dataLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet1 = new test.DataSet1();
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTableAdapter = new test.DataSet1TableAdapters.ImageTableAdapter();
            this.tableAdapterManager = new test.DataSet1TableAdapters.TableAdapterManager();
            this.imageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel1 = new System.Windows.Forms.Label();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            pathLabel = new System.Windows.Forms.Label();
            imgLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            dataLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingNavigator)).BeginInit();
            this.imageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(77, 46);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            idLabel.Visible = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(82, 96);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new System.Drawing.Point(87, 127);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new System.Drawing.Size(31, 13);
            pathLabel.TabIndex = 5;
            pathLabel.Text = "path:";
            pathLabel.Visible = false;
            // 
            // imgLabel
            // 
            imgLabel.AutoSize = true;
            imgLabel.Location = new System.Drawing.Point(298, 63);
            imgLabel.Name = "imgLabel";
            imgLabel.Size = new System.Drawing.Size(26, 13);
            imgLabel.TabIndex = 7;
            imgLabel.Text = "img:";
            imgLabel.Visible = false;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(293, 40);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 9;
            dataLabel.Text = "data:";
            dataLabel.Visible = false;
            // 
            // dataLabel1
            // 
            dataLabel1.AutoSize = true;
            dataLabel1.Location = new System.Drawing.Point(87, 205);
            dataLabel1.Name = "dataLabel1";
            dataLabel1.Size = new System.Drawing.Size(31, 13);
            dataLabel1.TabIndex = 11;
            dataLabel1.Text = "data:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageBindingSource
            // 
            this.imageBindingSource.DataMember = "Image";
            this.imageBindingSource.DataSource = this.dataSet1;
            // 
            // imageTableAdapter
            // 
            this.imageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImageTableAdapter = this.imageTableAdapter;
            this.tableAdapterManager.UpdateOrder = test.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imageBindingNavigator
            // 
            this.imageBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.imageBindingNavigator.BindingSource = this.imageBindingSource;
            this.imageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.imageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.imageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.imageBindingNavigatorSaveItem});
            this.imageBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.imageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imageBindingNavigator.Name = "imageBindingNavigator";
            this.imageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.imageBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.imageBindingNavigator.TabIndex = 0;
            this.imageBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // imageBindingNavigatorSaveItem
            // 
            this.imageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("imageBindingNavigatorSaveItem.Image")));
            this.imageBindingNavigatorSaveItem.Name = "imageBindingNavigatorSaveItem";
            this.imageBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.imageBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.imageBindingNavigatorSaveItem.Click += new System.EventHandler(this.imageBindingNavigatorSaveItem_Click);
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "id", true));
            this.idLabel1.Location = new System.Drawing.Point(101, 46);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            this.idLabel1.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(124, 93);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // pathLabel1
            // 
            this.pathLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "path", true));
            this.pathLabel1.Location = new System.Drawing.Point(171, 151);
            this.pathLabel1.Name = "pathLabel1";
            this.pathLabel1.Size = new System.Drawing.Size(100, 23);
            this.pathLabel1.TabIndex = 6;
            this.pathLabel1.Text = "label1";
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.imageBindingSource, "img", true));
            this.imgPictureBox.Location = new System.Drawing.Point(341, 63);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(283, 201);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPictureBox.TabIndex = 8;
            this.imgPictureBox.TabStop = false;
            // 
            // dataMaskedTextBox
            // 
            this.dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "data", true));
            this.dataMaskedTextBox.Location = new System.Drawing.Point(341, 37);
            this.dataMaskedTextBox.Mask = "00/00/0000";
            this.dataMaskedTextBox.Name = "dataMaskedTextBox";
            this.dataMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataMaskedTextBox.TabIndex = 10;
            this.dataMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.imageBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(124, 201);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 12;
            this.dataDateTimePicker.ValueChanged += new System.EventHandler(this.dataDateTimePicker_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(dataLabel1);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataMaskedTextBox);
            this.Controls.Add(imgLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(pathLabel);
            this.Controls.Add(this.pathLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.imageBindingNavigator);
            this.Name = "Form1";
            this.Text = "test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingNavigator)).EndInit();
            this.imageBindingNavigator.ResumeLayout(false);
            this.imageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private test.DataSet1TableAdapters.ImageTableAdapter imageTableAdapter;
        private test.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imageBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton imageBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label pathLabel1;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}

