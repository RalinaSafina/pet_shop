namespace Pet_shop
{
    partial class Add_staff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_record_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.passport,
            this.INN,
            this.Work_record_book,
            this.Bank_account,
            this.phone_number,
            this.address,
            this.salary,
            this.id_pickup});
            this.dataGridView1.Location = new System.Drawing.Point(5, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            // 
            // passport
            // 
            this.passport.HeaderText = "Данные паспорта";
            this.passport.Name = "passport";
            // 
            // INN
            // 
            this.INN.HeaderText = "ИНН";
            this.INN.Name = "INN";
            // 
            // Work_record_book
            // 
            this.Work_record_book.HeaderText = "Трудовая книжка";
            this.Work_record_book.Name = "Work_record_book";
            // 
            // Bank_account
            // 
            this.Bank_account.HeaderText = "Банковский счет";
            this.Bank_account.Name = "Bank_account";
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "номер тел.";
            this.phone_number.Name = "phone_number";
            // 
            // address
            // 
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            // 
            // salary
            // 
            this.salary.HeaderText = "Зарплата";
            this.salary.Name = "salary";
            // 
            // id_pickup
            // 
            this.id_pickup.HeaderText = "Номер магазина";
            this.id_pickup.Name = "id_pickup";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(355, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Add_staff";
            this.Text = "Add_staff";
            this.Load += new System.EventHandler(this.Add_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn INN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_record_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank_account;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pickup;
        private System.Windows.Forms.Button button1;
    }
}