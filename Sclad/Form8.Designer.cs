namespace Sclad
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.magazinDataSet = new Sclad.MagazinDataSet();
            this.таблицаЕдиницыИзмеренияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблицаЕдиницыИзмеренияTableAdapter = new Sclad.MagazinDataSetTableAdapters.ТаблицаЕдиницыИзмеренияTableAdapter();
            this.tableAdapterManager = new Sclad.MagazinDataSetTableAdapters.TableAdapterManager();
            this.таблицаЕдиницыИзмеренияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.таблицаЕдиницыИзмеренияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.таблицаЕдиницыИзмеренияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаЕдиницыИзмеренияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаЕдиницыИзмеренияBindingNavigator)).BeginInit();
            this.таблицаЕдиницыИзмеренияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаЕдиницыИзмеренияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // magazinDataSet
            // 
            this.magazinDataSet.DataSetName = "MagazinDataSet";
            this.magazinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблицаЕдиницыИзмеренияBindingSource
            // 
            this.таблицаЕдиницыИзмеренияBindingSource.DataMember = "ТаблицаЕдиницыИзмерения";
            this.таблицаЕдиницыИзмеренияBindingSource.DataSource = this.magazinDataSet;
            // 
            // таблицаЕдиницыИзмеренияTableAdapter
            // 
            this.таблицаЕдиницыИзмеренияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Sclad.MagazinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ТаблицаГруппыТовараTableAdapter = null;
            this.tableAdapterManager.ТаблицаДоговорыTableAdapter = null;
            this.tableAdapterManager.ТаблицаЕдиницыИзмеренияTableAdapter = this.таблицаЕдиницыИзмеренияTableAdapter;
            this.tableAdapterManager.ТаблицаОтделыTableAdapter = null;
            this.tableAdapterManager.ТаблицаПоставщикиTableAdapter = null;
            this.tableAdapterManager.ТаблицаПроизводителиTableAdapter = null;
            this.tableAdapterManager.ТаблицаСкладTableAdapter = null;
            this.tableAdapterManager.ТаблицаТоварTableAdapter = null;
            // 
            // таблицаЕдиницыИзмеренияBindingNavigator
            // 
            this.таблицаЕдиницыИзмеренияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.таблицаЕдиницыИзмеренияBindingNavigator.BindingSource = this.таблицаЕдиницыИзмеренияBindingSource;
            this.таблицаЕдиницыИзмеренияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.таблицаЕдиницыИзмеренияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.таблицаЕдиницыИзмеренияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.таблицаЕдиницыИзмеренияBindingNavigatorSaveItem});
            this.таблицаЕдиницыИзмеренияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.таблицаЕдиницыИзмеренияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.таблицаЕдиницыИзмеренияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.таблицаЕдиницыИзмеренияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.таблицаЕдиницыИзмеренияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.таблицаЕдиницыИзмеренияBindingNavigator.Name = "таблицаЕдиницыИзмеренияBindingNavigator";
            this.таблицаЕдиницыИзмеренияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.таблицаЕдиницыИзмеренияBindingNavigator.Size = new System.Drawing.Size(323, 25);
            this.таблицаЕдиницыИзмеренияBindingNavigator.TabIndex = 0;
            this.таблицаЕдиницыИзмеренияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // таблицаЕдиницыИзмеренияBindingNavigatorSaveItem
            // 
            this.таблицаЕдиницыИзмеренияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.таблицаЕдиницыИзмеренияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("таблицаЕдиницыИзмеренияBindingNavigatorSaveItem.Image")));
            this.таблицаЕдиницыИзмеренияBindingNavigatorSaveItem.Name = "таблицаЕдиницыИзмеренияBindingNavigatorSaveItem";
            this.таблицаЕдиницыИзмеренияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.таблицаЕдиницыИзмеренияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.таблицаЕдиницыИзмеренияBindingNavigatorSaveItem.Click += new System.EventHandler(this.таблицаЕдиницыИзмеренияBindingNavigatorSaveItem_Click);
            // 
            // таблицаЕдиницыИзмеренияDataGridView
            // 
            this.таблицаЕдиницыИзмеренияDataGridView.AutoGenerateColumns = false;
            this.таблицаЕдиницыИзмеренияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.таблицаЕдиницыИзмеренияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.таблицаЕдиницыИзмеренияDataGridView.DataSource = this.таблицаЕдиницыИзмеренияBindingSource;
            this.таблицаЕдиницыИзмеренияDataGridView.Location = new System.Drawing.Point(21, 38);
            this.таблицаЕдиницыИзмеренияDataGridView.Name = "таблицаЕдиницыИзмеренияDataGridView";
            this.таблицаЕдиницыИзмеренияDataGridView.Size = new System.Drawing.Size(276, 260);
            this.таблицаЕдиницыИзмеренияDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодЕдиницы";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодЕдиницы";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "НазваниеЕдиницы";
            this.dataGridViewTextBoxColumn2.HeaderText = "НазваниеЕдиницы";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 310);
            this.Controls.Add(this.таблицаЕдиницыИзмеренияDataGridView);
            this.Controls.Add(this.таблицаЕдиницыИзмеренияBindingNavigator);
            this.Name = "Form8";
            this.Text = "Единицы измерения";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаЕдиницыИзмеренияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаЕдиницыИзмеренияBindingNavigator)).EndInit();
            this.таблицаЕдиницыИзмеренияBindingNavigator.ResumeLayout(false);
            this.таблицаЕдиницыИзмеренияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаЕдиницыИзмеренияDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MagazinDataSet magazinDataSet;
        private System.Windows.Forms.BindingSource таблицаЕдиницыИзмеренияBindingSource;
        private MagazinDataSetTableAdapters.ТаблицаЕдиницыИзмеренияTableAdapter таблицаЕдиницыИзмеренияTableAdapter;
        private MagazinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator таблицаЕдиницыИзмеренияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton таблицаЕдиницыИзмеренияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView таблицаЕдиницыИзмеренияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}