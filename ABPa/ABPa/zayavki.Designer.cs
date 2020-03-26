namespace ABPa
{
    partial class zayavki
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
            this.zayavkaLabel = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.droneList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // zayavkaLabel
            // 
            this.zayavkaLabel.AutoSize = true;
            this.zayavkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zayavkaLabel.Location = new System.Drawing.Point(233, 9);
            this.zayavkaLabel.Name = "zayavkaLabel";
            this.zayavkaLabel.Size = new System.Drawing.Size(371, 24);
            this.zayavkaLabel.TabIndex = 0;
            this.zayavkaLabel.Text = "Заявка на поставку №0000 от 26.03.2020";
            // 
            // fio
            // 
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.Location = new System.Drawing.Point(178, 98);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(306, 29);
            this.fio.TabIndex = 1;
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(178, 169);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(306, 29);
            this.count.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(60, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дроны";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(18, 309);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(96, 38);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(508, 309);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 38);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // droneList
            // 
            this.droneList.FormattingEnabled = true;
            this.droneList.Location = new System.Drawing.Point(178, 204);
            this.droneList.Name = "droneList";
            this.droneList.Size = new System.Drawing.Size(306, 21);
            this.droneList.TabIndex = 11;
            // 
            // zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 354);
            this.Controls.Add(this.droneList);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.zayavkaLabel);
            this.Name = "zayavki";
            this.Text = "Заявка ";
            this.Load += new System.EventHandler(this.zayavki_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zayavkaLabel;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox droneList;
    }
}