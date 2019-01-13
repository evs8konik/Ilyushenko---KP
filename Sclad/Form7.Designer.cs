namespace Sclad
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.magazinDataSet = new Sclad.MagazinDataSet();
            this.таблицаГруппыТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблицаГруппыТовараTableAdapter = new Sclad.MagazinDataSetTableAdapters.ТаблицаГруппыТовараTableAdapter();
            this.tableAdapterManager = new Sclad.MagazinDataSetTableAdapters.TableAdapterManager();
            this.таблицаГруппыТовараBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.таблицаГруппыТовараBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.таблицаГруппыТовараDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаГруппыТовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаГруппыТовараBindingNavigator)).BeginInit();
            this.таблицаГруппыТовараBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаГруппыТовараDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // magazinDataSet
            // 
            this.magazinDataSet.DataSetName = "MagazinDataSet";
            this.magazinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблицаГруппыТовараBindingSource
            // 
            this.таблицаГруппыТовараBindingSource.DataMember = "ТаблицаГруппыТовара";
            this.таблицаГруппыТовараBindingSource.DataSource = this.magazinDataSet;
            // 
            // таблицаГруппыТовараTableAdapter
            // 
            this.таблицаГруппыТовараTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Sclad.MagazinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ТаблицаГруппыТовараTableAdapter = this.таблицаГруппыТовараTableAdapter;
            this.tableAdapterManager.ТаблицаДоговорыTableAdapter = null;
            this.tableAdapterManager.ТаблицаЕдиницыИзмеренияTableAdapter = null;
            this.tableAdapterManager.ТаблицаОтделыTableAdapter = null;
            this.tableAdapterManager.ТаблицаПоставщикиTableAdapter = null;
            this.tableAdapterManager.ТаблицаПроизводителиTableAdapter = null;
            this.tableAdapterManager.ТаблицаСкладTableAdapter = null;
            this.tableAdapterManager.ТаблицаТоварTableAdapter = null;
            // 
            // таблицаГруппыТовараBindingNavigator
            // 
            this.таблицаГруппыТовараBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.таблицаГруппыТовараBindingNavigator.BindingSource = this.таблицаГруппыТовараBindingSource;
            this.таблицаГруппыТовараBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.таблицаГруппыТовараBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.таблицаГруппыТовараBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.таблицаГруппыТовараBindingNavigatorSaveItem});
            this.таблицаГруппыТовараBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.таблицаГруппыТовараBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.таблицаГруппыТовараBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.таблицаГруппыТовараBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.таблицаГруппыТовараBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.таблицаГруппыТовараBindingNavigator.Name = "таблицаГруппыТовараBindingNavigator";
            this.таблицаГруппыТовараBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.таблицаГруппыТовараBindingNavigator.Size = new System.Drawing.Size(411, 25);
            this.таблицаГруппыТовараBindingNavigator.TabIndex = 0;
            this.таблицаГруппыТовараBindingNavigator.Text = "bindingNavigator1";
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
            // таблицаГруппыТовараBindingNavigatorSaveItem
            // 
            this.таблицаГруппыТовараBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.таблицаГруппыТовараBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("таблицаГруппыТовараBindingNavigatorSaveItem.Image")));
            this.таблицаГруппыТовараBindingNavigatorSaveItem.Name = "таблицаГруппыТовараBindingNavigatorSaveItem";
            this.таблицаГруппыТовараBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.таблицаГруппыТовараBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.таблицаГруппыТовараBindingNavigatorSaveItem.Click += new System.EventHandler(this.таблицаГруппыТовараBindingNavigatorSaveItem_Click);
            // 
            // таблицаГруппыТовараDataGridView
            // 
            this.таблицаГруппыТовараDataGridView.AutoGenerateColumns = false;
            this.таблицаГруппыТовараDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.таблицаГруппыТовараDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.таблицаГруппыТовараDataGridView.DataSource = this.таблицаГруппыТовараBindingSource;
            this.таблицаГруппыТовараDataGridView.Location = new System.Drawing.Point(12, 37);
            this.таблицаГруппыТовараDataGridView.Name = "таблицаГруппыТовараDataGridView";
            this.таблицаГруппыТовараDataGridView.Size = new System.Drawing.Size(384, 240);
            this.таблицаГруппыТовараDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодГруппы";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодГруппы";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "НаименованиеГруппы";
            this.dataGridViewTextBoxColumn2.HeaderText = "НаименованиеГруппы";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "КодОтдела";
            this.dataGridViewTextBoxColumn3.HeaderText = "КодОтдела";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 298);
            this.Controls.Add(this.таблицаГруппыТовараDataGridView);
            this.Controls.Add(this.таблицаГруппыТовараBindingNavigator);
            this.Name = "Form7";
            this.Text = "Группы товара";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаГруппыТовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаГруппыТовараBindingNavigator)).EndInit();
            this.таблицаГруппыТовараBindingNavigator.ResumeLayout(false);
            this.таблицаГруппыТовараBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаГруппыТовараDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MagazinDataSet magazinDataSet;
        private System.Windows.Forms.BindingSource таблицаГруппыТовараBindingSource;
        private MagazinDataSetTableAdapters.ТаблицаГруппыТовараTableAdapter таблицаГруппыТовараTableAdapter;
        private MagazinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator таблицаГруппыТовараBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton таблицаГруппыТовараBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView таблицаГруппыТовараDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}