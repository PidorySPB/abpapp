namespace ABPa
{
    partial class Form2
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
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.okB = new System.Windows.Forms.Button();
            this.uploadB = new System.Windows.Forms.Button();
            this.closeB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.complect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поступление комплектующих №00000 от 01.01.2020";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(196, 59);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(201, 20);
            this.nameTBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ответственный за прием:";
            // 
            // okB
            // 
            this.okB.Location = new System.Drawing.Point(33, 284);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(75, 23);
            this.okB.TabIndex = 3;
            this.okB.Text = "OK";
            this.okB.UseVisualStyleBackColor = true;
            // 
            // uploadB
            // 
            this.uploadB.Location = new System.Drawing.Point(115, 284);
            this.uploadB.Name = "uploadB";
            this.uploadB.Size = new System.Drawing.Size(75, 23);
            this.uploadB.TabIndex = 4;
            this.uploadB.Text = "Записать";
            this.uploadB.UseVisualStyleBackColor = true;
            this.uploadB.Click += new System.EventHandler(this.uploadB_Click);
            // 
            // closeB
            // 
            this.closeB.Location = new System.Drawing.Point(322, 284);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(75, 23);
            this.closeB.TabIndex = 5;
            this.closeB.Text = "Закрыть";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complect,
            this.serial,
            this.count});
            this.dataGridView1.Location = new System.Drawing.Point(56, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 183);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // complect
            // 
            this.complect.Frozen = true;
            this.complect.HeaderText = "Комплектующие";
            this.complect.Name = "complect";
            this.complect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // serial
            // 
            this.serial.Frozen = true;
            this.serial.HeaderText = "Серийный номер";
            this.serial.Name = "serial";
            this.serial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // count
            // 
            this.count.Frozen = true;
            this.count.HeaderText = "Количество";
            this.count.Name = "count";
            this.count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 319);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.uploadB);
            this.Controls.Add(this.okB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Поступление комплектующих";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.Button uploadB;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn complect;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
    }
   }