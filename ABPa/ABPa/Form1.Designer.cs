﻿namespace ABPa
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
            this.downloadB = new System.Windows.Forms.Button();
            this.closeB = new System.Windows.Forms.Button();
            this.openButtonTech = new System.Windows.Forms.Button();
            this.openButtonParts = new System.Windows.Forms.Button();
            this.openButtonDron = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Импортирование данных";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дроны";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Комплектующие";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тех. карты";
            // 
            // textBoxDron
            // 
            this.textBoxDron.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDron.Location = new System.Drawing.Point(144, 55);
            this.textBoxDron.Name = "textBoxDron";
            this.textBoxDron.Size = new System.Drawing.Size(192, 20);
            this.textBoxDron.TabIndex = 4;
            this.textBoxDron.Tag = "";
            // 
            // textBoxParts
            // 
            this.textBoxParts.Location = new System.Drawing.Point(144, 101);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.Size = new System.Drawing.Size(192, 20);
            this.textBoxParts.TabIndex = 5;
            // 
            // textBoxTech
            // 
            this.textBoxTech.Location = new System.Drawing.Point(144, 149);
            this.textBoxTech.Name = "textBoxTech";
            this.textBoxTech.Size = new System.Drawing.Size(192, 20);
            this.textBoxTech.TabIndex = 6;
            // 
            // downloadB
            // 
            this.downloadB.Location = new System.Drawing.Point(15, 184);
            this.downloadB.Name = "downloadB";
            this.downloadB.Size = new System.Drawing.Size(79, 33);
            this.downloadB.TabIndex = 11;
            this.downloadB.Text = "Загрузить";
            this.downloadB.Click += new System.EventHandler(this.downloadB_Click);
            // 
            // closeB
            // 
            this.closeB.Location = new System.Drawing.Point(144, 184);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(79, 33);
            this.closeB.TabIndex = 10;
            this.closeB.Text = "Закрыть";
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // openButtonTech
            // 
            this.openButtonTech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButtonTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButtonTech.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.openButtonTech.Location = new System.Drawing.Point(335, 149);
            this.openButtonTech.Name = "openButtonTech";
            this.openButtonTech.Size = new System.Drawing.Size(43, 20);
            this.openButtonTech.TabIndex = 0;
            this.openButtonTech.Text = "...";
            this.openButtonTech.Click += new System.EventHandler(this.openButtonTech_Click);
            // 
            // openButtonParts
            // 
            this.openButtonParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButtonParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButtonParts.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.openButtonParts.Location = new System.Drawing.Point(335, 101);
            this.openButtonParts.Name = "openButtonParts";
            this.openButtonParts.Size = new System.Drawing.Size(43, 20);
            this.openButtonParts.TabIndex = 1;
            this.openButtonParts.Text = "...";
            this.openButtonParts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openButtonParts.Click += new System.EventHandler(this.openButtonParts_Click);
            // 
            // openButtonDron
            // 
            this.openButtonDron.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButtonDron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButtonDron.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.openButtonDron.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openButtonDron.Location = new System.Drawing.Point(335, 55);
            this.openButtonDron.Name = "openButtonDron";
            this.openButtonDron.Size = new System.Drawing.Size(43, 20);
            this.openButtonDron.TabIndex = 9;
            this.openButtonDron.Text = "...";
            this.openButtonDron.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openButtonDron.UseVisualStyleBackColor = true;
            this.openButtonDron.Click += new System.EventHandler(this.openButtonDron_Click);
            // 
            // downloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 233);
            this.Controls.Add(this.openButtonTech);
            this.Controls.Add(this.openButtonParts);
            this.Controls.Add(this.openButtonDron);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.downloadB);
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
        private System.Windows.Forms.Button downloadB;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.Button openButtonDron;
        private System.Windows.Forms.Button openButtonParts;
        private System.Windows.Forms.Button openButtonTech;
    }
}

