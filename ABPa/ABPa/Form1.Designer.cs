namespace ABPa
{
    partial class downloadForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDron = new System.Windows.Forms.TextBox();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.textBoxTech = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.openButtonTech = new System.Windows.Forms.Button();
            this.openButtonParts = new System.Windows.Forms.Button();
            this.openButtonDron = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Импортирование данных";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дроны";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Комплектующие";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тех. карты";
            // 
            // textBoxDron
            // 
            this.textBoxDron.Location = new System.Drawing.Point(122, 53);
            this.textBoxDron.Name = "textBoxDron";
            this.textBoxDron.Size = new System.Drawing.Size(192, 20);
            this.textBoxDron.TabIndex = 4;
            // 
            // textBoxParts
            // 
            this.textBoxParts.Location = new System.Drawing.Point(122, 99);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.Size = new System.Drawing.Size(192, 20);
            this.textBoxParts.TabIndex = 5;
            // 
            // textBoxTech
            // 
            this.textBoxTech.Location = new System.Drawing.Point(122, 147);
            this.textBoxTech.Name = "textBoxTech";
            this.textBoxTech.Size = new System.Drawing.Size(192, 20);
            this.textBoxTech.TabIndex = 6;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(122, 182);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 11;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(272, 182);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            // 
            // openButtonTech
            // 
            this.openButtonTech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButtonTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButtonTech.Location = new System.Drawing.Point(313, 147);
            this.openButtonTech.Name = "openButtonTech";
            this.openButtonTech.Size = new System.Drawing.Size(43, 20);
            this.openButtonTech.TabIndex = 0;
            // 
            // openButtonParts
            // 
            this.openButtonParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButtonParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButtonParts.Location = new System.Drawing.Point(313, 99);
            this.openButtonParts.Name = "openButtonParts";
            this.openButtonParts.Size = new System.Drawing.Size(43, 20);
            this.openButtonParts.TabIndex = 1;
            // 
            // openButtonDron
            // 
            this.openButtonDron.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButtonDron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButtonDron.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButtonDron.Image = global::ABPa.Properties.Resources.iconFolder;
            this.openButtonDron.Location = new System.Drawing.Point(313, 53);
            this.openButtonDron.Name = "openButtonDron";
            this.openButtonDron.Size = new System.Drawing.Size(43, 20);
            this.openButtonDron.TabIndex = 9;
            this.openButtonDron.Text = "...";
            this.openButtonDron.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openButtonDron.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openButtonDron.UseVisualStyleBackColor = true;
            this.openButtonDron.Click += new System.EventHandler(this.openButtonDron_Click);
            // 
            // downloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 217);
            this.Controls.Add(this.openButtonTech);
            this.Controls.Add(this.openButtonParts);
            this.Controls.Add(this.openButtonDron);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.textBoxTech);
            this.Controls.Add(this.textBoxParts);
            this.Controls.Add(this.textBoxDron);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "downloadForm";
            this.Text = "Загрузка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDron;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.TextBox textBoxTech;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button openButtonDron;
        private System.Windows.Forms.Button openButtonParts;
        private System.Windows.Forms.Button openButtonTech;
    }
}

