namespace BdKursach
{
    partial class FormRoomList
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
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstDataSet1 = new BdKursach.FirstDataSet1();
            this.roomTableAdapter = new BdKursach.FirstDataSet1TableAdapters.RoomTableAdapter();
            this.room1DataSet = new BdKursach.Room1DataSet();
            this.room1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room1TableAdapter = new BdKursach.Room1DataSetTableAdapters.Room1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liverAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.refregiratorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.room11DataSet = new BdKursach.Room11DataSet();
            this.room1TableAdapter1 = new BdKursach.Room11DataSetTableAdapters.Room1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.firstDataSet1;
            // 
            // firstDataSet1
            // 
            this.firstDataSet1.DataSetName = "FirstDataSet1";
            this.firstDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // room1DataSet
            // 
            this.room1DataSet.DataSetName = "Room1DataSet";
            this.room1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // room1BindingSource
            // 
            this.room1BindingSource.DataMember = "Room1";
            this.room1BindingSource.DataSource = this.room1DataSet;
            // 
            // room1TableAdapter
            // 
            this.room1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumDataGridViewTextBoxColumn,
            this.liverAmountDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.repairDataGridViewCheckBoxColumn,
            this.refregiratorDataGridViewCheckBoxColumn,
            this.metersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.room1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(116, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            this.roomNumDataGridViewTextBoxColumn.DataPropertyName = "RoomNum";
            this.roomNumDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            // 
            // liverAmountDataGridViewTextBoxColumn
            // 
            this.liverAmountDataGridViewTextBoxColumn.DataPropertyName = "LiverAmount";
            this.liverAmountDataGridViewTextBoxColumn.HeaderText = "Количество жильцов";
            this.liverAmountDataGridViewTextBoxColumn.Name = "liverAmountDataGridViewTextBoxColumn";
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // repairDataGridViewCheckBoxColumn
            // 
            this.repairDataGridViewCheckBoxColumn.DataPropertyName = "Repair";
            this.repairDataGridViewCheckBoxColumn.HeaderText = "Ремонт";
            this.repairDataGridViewCheckBoxColumn.Name = "repairDataGridViewCheckBoxColumn";
            // 
            // refregiratorDataGridViewCheckBoxColumn
            // 
            this.refregiratorDataGridViewCheckBoxColumn.DataPropertyName = "Refregirator";
            this.refregiratorDataGridViewCheckBoxColumn.HeaderText = "Холодильник";
            this.refregiratorDataGridViewCheckBoxColumn.Name = "refregiratorDataGridViewCheckBoxColumn";
            // 
            // metersDataGridViewTextBoxColumn
            // 
            this.metersDataGridViewTextBoxColumn.DataPropertyName = "Meters";
            this.metersDataGridViewTextBoxColumn.HeaderText = "Метраж";
            this.metersDataGridViewTextBoxColumn.Name = "metersDataGridViewTextBoxColumn";
            // 
            // room1BindingSource1
            // 
            this.room1BindingSource1.DataMember = "Room1";
            this.room1BindingSource1.DataSource = this.room11DataSet;
            // 
            // room11DataSet
            // 
            this.room11DataSet.DataSetName = "Room11DataSet";
            this.room11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // room1TableAdapter1
            // 
            this.room1TableAdapter1.ClearBeforeFill = true;
            // 
            // FormRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BdKursach.Properties.Resources.сибирская_кошка;
            this.ClientSize = new System.Drawing.Size(816, 474);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRoomList";
            this.Text = "Список комнат";
            this.Load += new System.EventHandler(this.FormRoomList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room11DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FirstDataSet1 firstDataSet1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private FirstDataSet1TableAdapters.RoomTableAdapter roomTableAdapter;
        private Room1DataSet room1DataSet;
        private System.Windows.Forms.BindingSource room1BindingSource;
        private Room1DataSetTableAdapters.Room1TableAdapter room1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Room11DataSet room11DataSet;
        private System.Windows.Forms.BindingSource room1BindingSource1;
        private Room11DataSetTableAdapters.Room1TableAdapter room1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liverAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn repairDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn refregiratorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metersDataGridViewTextBoxColumn;
    }
}