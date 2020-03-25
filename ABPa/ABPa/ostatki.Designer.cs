namespace ABPa
{
    partial class ostatki
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewOst = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komplekt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOst)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Остатки комплектующих";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Показывать данные на:";
            // 
            // dataGridViewOst
            // 
            this.dataGridViewOst.AllowUserToAddRows = false;
            this.dataGridViewOst.AllowUserToDeleteRows = false;
            this.dataGridViewOst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.komplekt,
            this.balance});
            this.dataGridViewOst.Location = new System.Drawing.Point(49, 97);
            this.dataGridViewOst.Name = "dataGridViewOst";
            this.dataGridViewOst.ReadOnly = true;
            this.dataGridViewOst.Size = new System.Drawing.Size(343, 227);
            this.dataGridViewOst.TabIndex = 3;
            // 
            // number
            // 
            this.number.Frozen = true;
            this.number.HeaderText = "№п/п";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // komplekt
            // 
            this.komplekt.Frozen = true;
            this.komplekt.HeaderText = "Комплектующие";
            this.komplekt.Name = "komplekt";
            this.komplekt.ReadOnly = true;
            // 
            // balance
            // 
            this.balance.Frozen = true;
            this.balance.HeaderText = "Остаток";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(49, 330);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(96, 38);
            this.execButton.TabIndex = 4;
            this.execButton.Text = "Выполнить";
            this.execButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(151, 330);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 38);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.close_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(296, 330);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(96, 38);
            this.printButton.TabIndex = 6;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 61);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 3, 25, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 25, 0, 0, 0, 0);
            // 
            // ostatki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 380);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.dataGridViewOst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ostatki";
            this.Text = "Остатки комплектующих";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOst;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn komplekt;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}