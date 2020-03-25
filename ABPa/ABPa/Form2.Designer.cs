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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поступление комплектующих №00000 от 01.01.2020";
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(175, 72);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(189, 20);
            this.nameTBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ответственный за прием:";
            // 
            // okB
            // 
            this.okB.Location = new System.Drawing.Point(33, 361);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(75, 23);
            this.okB.TabIndex = 3;
            this.okB.Text = "OK";
            this.okB.UseVisualStyleBackColor = true;
            // 
            // uploadB
            // 
            this.uploadB.Location = new System.Drawing.Point(115, 360);
            this.uploadB.Name = "uploadB";
            this.uploadB.Size = new System.Drawing.Size(75, 23);
            this.uploadB.TabIndex = 4;
            this.uploadB.Text = "Записать";
            this.uploadB.UseVisualStyleBackColor = true;
            // 
            // closeB
            // 
            this.closeB.Location = new System.Drawing.Point(197, 359);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(75, 23);
            this.closeB.TabIndex = 5;
            this.closeB.Text = "Закрыть";
            this.closeB.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.uploadB);
            this.Controls.Add(this.okB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Поступление комплектующих";
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
    }
}