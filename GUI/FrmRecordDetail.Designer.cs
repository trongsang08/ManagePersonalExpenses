namespace GUI
{
    partial class FrmAddRecord
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
            this.lb = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.nudMoney = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb.Location = new System.Drawing.Point(296, 19);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(202, 41);
            this.lb.TabIndex = 0;
            this.lb.Text = "RecordDetail";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMoney.Location = new System.Drawing.Point(57, 101);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(71, 25);
            this.lbMoney.TabIndex = 1;
            this.lbMoney.Text = "Money";
            // 
            // nudMoney
            // 
            this.nudMoney.Location = new System.Drawing.Point(174, 103);
            this.nudMoney.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMoney.Name = "nudMoney";
            this.nudMoney.Size = new System.Drawing.Size(218, 27);
            this.nudMoney.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(174, 178);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(218, 27);
            this.dtpDate.TabIndex = 3;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(57, 178);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(52, 25);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "Date";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCategory.Location = new System.Drawing.Point(445, 101);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(90, 25);
            this.lbCategory.TabIndex = 5;
            this.lbCategory.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownHeight = 90;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.IntegralHeight = false;
            this.cbCategory.Location = new System.Drawing.Point(573, 104);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(151, 28);
            this.cbCategory.TabIndex = 6;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbType.Location = new System.Drawing.Point(445, 179);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(53, 25);
            this.lbType.TabIndex = 7;
            this.lbType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(573, 175);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(151, 28);
            this.cbType.TabIndex = 8;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescription.Location = new System.Drawing.Point(57, 261);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(109, 25);
            this.lbDescription.TabIndex = 9;
            this.lbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(174, 262);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(550, 27);
            this.txtDescription.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(630, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.nudMoney);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.lb);
            this.Name = "FrmAddRecord";
            this.Text = "FrmAddRecord";
            this.Load += new System.EventHandler(this.FrmAddRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.NumericUpDown nudMoney;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}