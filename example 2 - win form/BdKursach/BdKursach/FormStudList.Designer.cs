namespace BdKursach
{
    partial class FormStudList
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studBiletNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paspNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.momTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormNeedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.debtDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finePointsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssMemberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ssPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studenttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalStudentDataSet2 = new BdKursach.FinalStudentDataSet2();
            this.student1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anotherStudentDataSet2 = new BdKursach.AnotherStudentDataSet2();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studListDataSet = new BdKursach.StudListDataSet();
            this.studentTableAdapter = new BdKursach.StudListDataSetTableAdapters.StudentTableAdapter();
            this.student1TableAdapter = new BdKursach.AnotherStudentDataSet2TableAdapters.Student1TableAdapter();
            this.studenttTableAdapter = new BdKursach.FinalStudentDataSet2TableAdapters.StudenttTableAdapter();
            this.FIODeleteText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FioDeleteButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenttBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStudentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anotherStudentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.studBiletNumDataGridViewTextBoxColumn,
            this.paspNumDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.momTelDataGridViewTextBoxColumn,
            this.dadTelDataGridViewTextBoxColumn,
            this.grouppDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.dormNeedDataGridViewCheckBoxColumn,
            this.debtDataGridViewCheckBoxColumn,
            this.finePointsDataGridViewCheckBoxColumn,
            this.totalPointsDataGridViewTextBoxColumn,
            this.ssMemberDataGridViewCheckBoxColumn,
            this.ssPositionDataGridViewTextBoxColumn,
            this.dormNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studenttBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1781, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "ДР";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // studBiletNumDataGridViewTextBoxColumn
            // 
            this.studBiletNumDataGridViewTextBoxColumn.DataPropertyName = "StudBiletNum";
            this.studBiletNumDataGridViewTextBoxColumn.HeaderText = "Номер студ.билета";
            this.studBiletNumDataGridViewTextBoxColumn.Name = "studBiletNumDataGridViewTextBoxColumn";
            // 
            // paspNumDataGridViewTextBoxColumn
            // 
            this.paspNumDataGridViewTextBoxColumn.DataPropertyName = "PaspNum";
            this.paspNumDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.paspNumDataGridViewTextBoxColumn.Name = "paspNumDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // momTelDataGridViewTextBoxColumn
            // 
            this.momTelDataGridViewTextBoxColumn.DataPropertyName = "MomTel";
            this.momTelDataGridViewTextBoxColumn.HeaderText = "Тел. мамы";
            this.momTelDataGridViewTextBoxColumn.Name = "momTelDataGridViewTextBoxColumn";
            // 
            // dadTelDataGridViewTextBoxColumn
            // 
            this.dadTelDataGridViewTextBoxColumn.DataPropertyName = "DadTel";
            this.dadTelDataGridViewTextBoxColumn.HeaderText = "Тел. отца";
            this.dadTelDataGridViewTextBoxColumn.Name = "dadTelDataGridViewTextBoxColumn";
            // 
            // grouppDataGridViewTextBoxColumn
            // 
            this.grouppDataGridViewTextBoxColumn.DataPropertyName = "Groupp";
            this.grouppDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.grouppDataGridViewTextBoxColumn.Name = "grouppDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Комната";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // dormNeedDataGridViewCheckBoxColumn
            // 
            this.dormNeedDataGridViewCheckBoxColumn.DataPropertyName = "DormNeed";
            this.dormNeedDataGridViewCheckBoxColumn.HeaderText = "Потр.в общ.";
            this.dormNeedDataGridViewCheckBoxColumn.Name = "dormNeedDataGridViewCheckBoxColumn";
            // 
            // debtDataGridViewCheckBoxColumn
            // 
            this.debtDataGridViewCheckBoxColumn.DataPropertyName = "Debt";
            this.debtDataGridViewCheckBoxColumn.HeaderText = "Уч. долг";
            this.debtDataGridViewCheckBoxColumn.Name = "debtDataGridViewCheckBoxColumn";
            // 
            // finePointsDataGridViewCheckBoxColumn
            // 
            this.finePointsDataGridViewCheckBoxColumn.DataPropertyName = "FinePoints";
            this.finePointsDataGridViewCheckBoxColumn.HeaderText = "Штраф баллы";
            this.finePointsDataGridViewCheckBoxColumn.Name = "finePointsDataGridViewCheckBoxColumn";
            // 
            // totalPointsDataGridViewTextBoxColumn
            // 
            this.totalPointsDataGridViewTextBoxColumn.DataPropertyName = "TotalPoints";
            this.totalPointsDataGridViewTextBoxColumn.HeaderText = "Баллы";
            this.totalPointsDataGridViewTextBoxColumn.Name = "totalPointsDataGridViewTextBoxColumn";
            // 
            // ssMemberDataGridViewCheckBoxColumn
            // 
            this.ssMemberDataGridViewCheckBoxColumn.DataPropertyName = "SsMember";
            this.ssMemberDataGridViewCheckBoxColumn.HeaderText = "Член студ.сов.";
            this.ssMemberDataGridViewCheckBoxColumn.Name = "ssMemberDataGridViewCheckBoxColumn";
            // 
            // ssPositionDataGridViewTextBoxColumn
            // 
            this.ssPositionDataGridViewTextBoxColumn.DataPropertyName = "SsPosition";
            this.ssPositionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.ssPositionDataGridViewTextBoxColumn.Name = "ssPositionDataGridViewTextBoxColumn";
            // 
            // dormNumDataGridViewTextBoxColumn
            // 
            this.dormNumDataGridViewTextBoxColumn.DataPropertyName = "DormNum";
            this.dormNumDataGridViewTextBoxColumn.HeaderText = "Номер общ.";
            this.dormNumDataGridViewTextBoxColumn.Name = "dormNumDataGridViewTextBoxColumn";
            // 
            // studenttBindingSource
            // 
            this.studenttBindingSource.DataMember = "Studentt";
            this.studenttBindingSource.DataSource = this.finalStudentDataSet2;
            // 
            // finalStudentDataSet2
            // 
            this.finalStudentDataSet2.DataSetName = "FinalStudentDataSet2";
            this.finalStudentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student1BindingSource
            // 
            this.student1BindingSource.DataMember = "Student1";
            this.student1BindingSource.DataSource = this.anotherStudentDataSet2;
            // 
            // anotherStudentDataSet2
            // 
            this.anotherStudentDataSet2.DataSetName = "AnotherStudentDataSet2";
            this.anotherStudentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studListDataSet;
            // 
            // studListDataSet
            // 
            this.studListDataSet.DataSetName = "StudListDataSet";
            this.studListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // student1TableAdapter
            // 
            this.student1TableAdapter.ClearBeforeFill = true;
            // 
            // studenttTableAdapter
            // 
            this.studenttTableAdapter.ClearBeforeFill = true;
            // 
            // FIODeleteText
            // 
            this.FIODeleteText.Location = new System.Drawing.Point(92, 471);
            this.FIODeleteText.Name = "FIODeleteText";
            this.FIODeleteText.Size = new System.Drawing.Size(127, 20);
            this.FIODeleteText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // FioDeleteButton
            // 
            this.FioDeleteButton.Location = new System.Drawing.Point(263, 471);
            this.FioDeleteButton.Name = "FioDeleteButton";
            this.FioDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.FioDeleteButton.TabIndex = 3;
            this.FioDeleteButton.Text = "Удалить";
            this.FioDeleteButton.UseVisualStyleBackColor = true;
            this.FioDeleteButton.Click += new System.EventHandler(this.FioDeleteButton_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(92, 521);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(127, 20);
            this.SearchText.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(263, 521);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FormStudList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BdKursach.Properties.Resources.сибирская_кошка;
            this.ClientSize = new System.Drawing.Size(1759, 583);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.FioDeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIODeleteText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormStudList";
            this.Text = "Список студентов";
            this.Load += new System.EventHandler(this.FormStudList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenttBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStudentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anotherStudentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StudListDataSet studListDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudListDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.BindingSource studentBindingSource1;
        private AnotherStudentDataSet2 anotherStudentDataSet2;
        private System.Windows.Forms.BindingSource student1BindingSource;
        private AnotherStudentDataSet2TableAdapters.Student1TableAdapter student1TableAdapter;
        private FinalStudentDataSet2 finalStudentDataSet2;
        private System.Windows.Forms.BindingSource studenttBindingSource;
        private FinalStudentDataSet2TableAdapters.StudenttTableAdapter studenttTableAdapter;
        private System.Windows.Forms.TextBox FIODeleteText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FioDeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studBiletNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paspNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn momTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grouppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dormNeedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn debtDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finePointsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ssMemberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button SearchButton;
    }
}