namespace BdKursach
{
    partial class FormStudCat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studBiletNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studCatDataSet = new BdKursach.StudCatDataSet();
            this.studCategoryTableAdapter = new BdKursach.StudCatDataSetTableAdapters.StudCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCatDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studBiletNumDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studCategoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(258, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // studBiletNumDataGridViewTextBoxColumn
            // 
            this.studBiletNumDataGridViewTextBoxColumn.DataPropertyName = "StudBiletNum";
            this.studBiletNumDataGridViewTextBoxColumn.HeaderText = "Номер студ. билета";
            this.studBiletNumDataGridViewTextBoxColumn.Name = "studBiletNumDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // studCategoryBindingSource
            // 
            this.studCategoryBindingSource.DataMember = "StudCategory";
            this.studCategoryBindingSource.DataSource = this.studCatDataSet;
            // 
            // studCatDataSet
            // 
            this.studCatDataSet.DataSetName = "StudCatDataSet";
            this.studCatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studCategoryTableAdapter
            // 
            this.studCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // FormStudCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BdKursach.Properties.Resources.сибирская_кошка;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 362);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormStudCat";
            this.Text = "Категория";
            this.Load += new System.EventHandler(this.FormStudCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCatDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudCatDataSet studCatDataSet;
        private System.Windows.Forms.BindingSource studCategoryBindingSource;
        private StudCatDataSetTableAdapters.StudCategoryTableAdapter studCategoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studBiletNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}