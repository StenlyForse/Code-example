namespace BdKursach
{
    partial class FormDormList
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
            this.rormNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liversAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormitoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstDataSet = new BdKursach.FirstDataSet();
            this.dormitoryTableAdapter = new BdKursach.FirstDataSetTableAdapters.DormitoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormitoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rormNumDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.liversAmountDataGridViewTextBoxColumn,
            this.squareDataGridViewTextBoxColumn,
            this.buildYearDataGridViewTextBoxColumn,
            this.floorsAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dormitoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(718, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rormNumDataGridViewTextBoxColumn
            // 
            this.rormNumDataGridViewTextBoxColumn.DataPropertyName = "RormNum";
            this.rormNumDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.rormNumDataGridViewTextBoxColumn.Name = "rormNumDataGridViewTextBoxColumn";
            this.rormNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // liversAmountDataGridViewTextBoxColumn
            // 
            this.liversAmountDataGridViewTextBoxColumn.DataPropertyName = "LiversAmount";
            this.liversAmountDataGridViewTextBoxColumn.HeaderText = "Кол-во койко - мест";
            this.liversAmountDataGridViewTextBoxColumn.Name = "liversAmountDataGridViewTextBoxColumn";
            this.liversAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // squareDataGridViewTextBoxColumn
            // 
            this.squareDataGridViewTextBoxColumn.DataPropertyName = "Square";
            this.squareDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.squareDataGridViewTextBoxColumn.Name = "squareDataGridViewTextBoxColumn";
            this.squareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildYearDataGridViewTextBoxColumn
            // 
            this.buildYearDataGridViewTextBoxColumn.DataPropertyName = "BuildYear";
            this.buildYearDataGridViewTextBoxColumn.HeaderText = "Год постройки";
            this.buildYearDataGridViewTextBoxColumn.Name = "buildYearDataGridViewTextBoxColumn";
            this.buildYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // floorsAmountDataGridViewTextBoxColumn
            // 
            this.floorsAmountDataGridViewTextBoxColumn.DataPropertyName = "FloorsAmount";
            this.floorsAmountDataGridViewTextBoxColumn.HeaderText = "Кол-во этажей";
            this.floorsAmountDataGridViewTextBoxColumn.Name = "floorsAmountDataGridViewTextBoxColumn";
            this.floorsAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dormitoryBindingSource
            // 
            this.dormitoryBindingSource.DataMember = "Dormitory";
            this.dormitoryBindingSource.DataSource = this.firstDataSet;
            // 
            // firstDataSet
            // 
            this.firstDataSet.DataSetName = "FirstDataSet";
            this.firstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dormitoryTableAdapter
            // 
            this.dormitoryTableAdapter.ClearBeforeFill = true;
            // 
            // FormDormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BdKursach.Properties.Resources.сибирская_кошка;
            this.ClientSize = new System.Drawing.Size(837, 431);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDormList";
            this.Text = "Список общежитий";
            this.Load += new System.EventHandler(this.FormDormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormitoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FirstDataSet firstDataSet;
        private System.Windows.Forms.BindingSource dormitoryBindingSource;
        private FirstDataSetTableAdapters.DormitoryTableAdapter dormitoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rormNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liversAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorsAmountDataGridViewTextBoxColumn;
    }
}