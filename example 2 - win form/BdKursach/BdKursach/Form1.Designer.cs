namespace BdKursach
{
    partial class Form1
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
            this.StudAdd = new System.Windows.Forms.Button();
            this.AddRoom = new System.Windows.Forms.Button();
            this.StudList = new System.Windows.Forms.Button();
            this.RegAgress = new System.Windows.Forms.Button();
            this.StudCateg = new System.Windows.Forms.Button();
            this.RoomList = new System.Windows.Forms.Button();
            this.DormList = new System.Windows.Forms.Button();
            this.ExitMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudAdd
            // 
            this.StudAdd.Location = new System.Drawing.Point(26, 29);
            this.StudAdd.Name = "StudAdd";
            this.StudAdd.Size = new System.Drawing.Size(127, 26);
            this.StudAdd.TabIndex = 0;
            this.StudAdd.Text = "Добавить студента";
            this.StudAdd.UseVisualStyleBackColor = true;
            this.StudAdd.Click += new System.EventHandler(this.StudAdd_Click);
            // 
            // AddRoom
            // 
            this.AddRoom.Location = new System.Drawing.Point(26, 90);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(127, 26);
            this.AddRoom.TabIndex = 1;
            this.AddRoom.Text = "Добавить комнату";
            this.AddRoom.UseVisualStyleBackColor = true;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // StudList
            // 
            this.StudList.Location = new System.Drawing.Point(275, 7);
            this.StudList.Name = "StudList";
            this.StudList.Size = new System.Drawing.Size(142, 38);
            this.StudList.TabIndex = 2;
            this.StudList.Text = "Список студентов";
            this.StudList.UseVisualStyleBackColor = true;
            this.StudList.Click += new System.EventHandler(this.StudList_Click);
            // 
            // RegAgress
            // 
            this.RegAgress.Location = new System.Drawing.Point(275, 78);
            this.RegAgress.Name = "RegAgress";
            this.RegAgress.Size = new System.Drawing.Size(142, 38);
            this.RegAgress.TabIndex = 3;
            this.RegAgress.Text = "Адрес регистрации";
            this.RegAgress.UseVisualStyleBackColor = true;
            this.RegAgress.Click += new System.EventHandler(this.RegAgress_Click);
            // 
            // StudCateg
            // 
            this.StudCateg.Location = new System.Drawing.Point(275, 152);
            this.StudCateg.Name = "StudCateg";
            this.StudCateg.Size = new System.Drawing.Size(142, 38);
            this.StudCateg.TabIndex = 4;
            this.StudCateg.Text = "Категория учащегося";
            this.StudCateg.UseVisualStyleBackColor = true;
            this.StudCateg.Click += new System.EventHandler(this.StudCateg_Click);
            // 
            // RoomList
            // 
            this.RoomList.Location = new System.Drawing.Point(609, 90);
            this.RoomList.Name = "RoomList";
            this.RoomList.Size = new System.Drawing.Size(127, 26);
            this.RoomList.TabIndex = 6;
            this.RoomList.Text = "Список комнат";
            this.RoomList.UseVisualStyleBackColor = true;
            this.RoomList.Click += new System.EventHandler(this.RoomList_Click);
            // 
            // DormList
            // 
            this.DormList.Location = new System.Drawing.Point(609, 29);
            this.DormList.Name = "DormList";
            this.DormList.Size = new System.Drawing.Size(127, 26);
            this.DormList.TabIndex = 5;
            this.DormList.Text = "Список общежитий";
            this.DormList.UseVisualStyleBackColor = true;
            this.DormList.Click += new System.EventHandler(this.DormList_Click);
            // 
            // ExitMainButton
            // 
            this.ExitMainButton.Location = new System.Drawing.Point(661, 517);
            this.ExitMainButton.Name = "ExitMainButton";
            this.ExitMainButton.Size = new System.Drawing.Size(75, 23);
            this.ExitMainButton.TabIndex = 7;
            this.ExitMainButton.Text = "Выход";
            this.ExitMainButton.UseVisualStyleBackColor = true;
            this.ExitMainButton.Click += new System.EventHandler(this.ExitMain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BdKursach.Properties.Resources.сибирская_кошка;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 567);
            this.Controls.Add(this.ExitMainButton);
            this.Controls.Add(this.RoomList);
            this.Controls.Add(this.DormList);
            this.Controls.Add(this.StudCateg);
            this.Controls.Add(this.RegAgress);
            this.Controls.Add(this.StudList);
            this.Controls.Add(this.AddRoom);
            this.Controls.Add(this.StudAdd);
            this.Name = "Form1";
            this.Text = "Общежитие";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudAdd;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.Button StudList;
        private System.Windows.Forms.Button RegAgress;
        private System.Windows.Forms.Button StudCateg;
        private System.Windows.Forms.Button RoomList;
        private System.Windows.Forms.Button DormList;
        private System.Windows.Forms.Button ExitMainButton;
    }
}

