namespace Sclad
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.magazinDataSet = new Sclad.MagazinDataSet();
            this.таблицаПроизводителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблицаПроизводителиTableAdapter = new Sclad.MagazinDataSetTableAdapters.ТаблицаПроизводителиTableAdapter();
            this.tableAdapterManager = new Sclad.MagazinDataSetTableAdapters.TableAdapterManager();
            this.таблицаПроизводителиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.таблицаПроизводителиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.таблицаПроизводителиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаПроизводителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаПроизводителиBindingNavigator)).BeginInit();
            this.таблицаПроизводителиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаПроизводителиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // magazinDataSet
            // 
            this.magazinDataSet.DataSetName = "MagazinDataSet";
            this.magazinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблицаПроизводителиBindingSource
            // 
            this.таблицаПроизводителиBindingSource.DataMember = "ТаблицаПроизводители";
            this.таблицаПроизводителиBindingSource.DataSource = this.magazinDataSet;
            // 
            // таблицаПроизводителиTableAdapter
            // 
            this.таблицаПроизводителиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Sclad.MagazinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ТаблицаГруппыТовараTableAdapter = null;
            this.tableAdapterManager.ТаблицаДоговорыTableAdapter = null;
            this.tableAdapterManager.ТаблицаЕдиницыИзмеренияTableAdapter = null;
            this.tableAdapterManager.ТаблицаОтделыTableAdapter = null;
            this.tableAdapterManager.ТаблицаПоставщикиTableAdapter = null;
            this.tableAdapterManager.ТаблицаПроизводителиTableAdapter = this.таблицаПроизводителиTableAdapter;
            this.tableAdapterManager.ТаблицаСкладTableAdapter = null;
            this.tableAdapterManager.ТаблицаТоварTableAdapter = null;
            // 
            // таблицаПроизводителиBindingNavigator
            // 
            this.таблицаПроизводителиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.таблицаПроизводителиBindingNavigator.BindingSource = this.таблицаПроизводителиBindingSource;
            this.таблицаПроизводителиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.таблицаПроизводителиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.таблицаПроизводителиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.таблицаПроизводителиBindingNavigatorSaveItem});
            this.таблицаПроизводителиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.таблицаПроизводителиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.таблицаПроизводителиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.таблицаПроизводителиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.таблицаПроизводителиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.таблицаПроизводителиBindingNavigator.Name = "таблицаПроизводителиBindingNavigator";
            this.таблицаПроизводителиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.таблицаПроизводителиBindingNavigator.Size = new System.Drawing.Size(670, 25);
            this.таблицаПроизводителиBindingNavigator.TabIndex = 0;
            this.таблицаПроизводителиBindingNavigator.Text = "bindingNavigator1";
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
            // таблицаПроизводителиBindingNavigatorSaveItem
            // 
            this.таблицаПроизводителиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.таблицаПроизводителиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("таблицаПроизводителиBindingNavigatorSaveItem.Image")));
            this.таблицаПроизводителиBindingNavigatorSaveItem.Name = "таблицаПроизводителиBindingNavigatorSaveItem";
            this.таблицаПроизводителиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.таблицаПроизводителиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.таблицаПроизводителиBindingNavigatorSaveItem.Click += new System.EventHandler(this.таблицаПроизводителиBindingNavigatorSaveItem_Click);
            // 
            // таблицаПроизводителиDataGridView
            // 
            this.таблицаПроизводителиDataGridView.AutoGenerateColumns = false;
            this.таблицаПроизводителиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.таблицаПроизводителиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.таблицаПроизводителиDataGridView.DataSource = this.таблицаПроизводителиBindingSource;
            this.таблицаПроизводителиDataGridView.Location = new System.Drawing.Point(12, 28);
            this.таблицаПроизводителиDataGridView.Name = "таблицаПроизводителиDataGridView";
            this.таблицаПроизводителиDataGridView.Size = new System.Drawing.Size(645, 237);
            this.таблицаПроизводителиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Шифр";
            this.dataGridViewTextBoxColumn1.HeaderText = "Шифр";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Страна";
            this.dataGridViewTextBoxColumn3.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Город";
            this.dataGridViewTextBoxColumn4.HeaderText = "Город";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Улица";
            this.dataGridViewTextBoxColumn5.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дом";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дом";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 277);
            this.Controls.Add(this.таблицаПроизводителиDataGridView);
            this.Controls.Add(this.таблицаПроизводителиBindingNavigator);
            this.Name = "Form4";
            this.Text = "Производители";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаПроизводителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаПроизводителиBindingNavigator)).EndInit();
            this.таблицаПроизводителиBindingNavigator.ResumeLayout(false);
            this.таблицаПроизводителиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаПроизводителиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MagazinDataSet magazinDataSet;
        private System.Windows.Forms.BindingSource таблицаПроизводителиBindingSource;
        private MagazinDataSetTableAdapters.ТаблицаПроизводителиTableAdapter таблицаПроизводителиTableAdapter;
        private MagazinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator таблицаПроизводителиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton таблицаПроизводителиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView таблицаПроизводителиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}