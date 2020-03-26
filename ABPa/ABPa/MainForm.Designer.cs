namespace ABPa
{
    partial class MainForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.ostatkiButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.zayavkaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(89, 22);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(197, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавление комплектующих";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(89, 65);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(197, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Загрузка данных";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // ostatkiButton
            // 
            this.ostatkiButton.Location = new System.Drawing.Point(89, 106);
            this.ostatkiButton.Name = "ostatkiButton";
            this.ostatkiButton.Size = new System.Drawing.Size(197, 23);
            this.ostatkiButton.TabIndex = 2;
            this.ostatkiButton.Text = "Остатки комплектующих";
            this.ostatkiButton.UseVisualStyleBackColor = true;
            this.ostatkiButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(307, 159);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // zayavkaButton
            // 
            this.zayavkaButton.Location = new System.Drawing.Point(89, 145);
            this.zayavkaButton.Name = "zayavkaButton";
            this.zayavkaButton.Size = new System.Drawing.Size(197, 23);
            this.zayavkaButton.TabIndex = 4;
            this.zayavkaButton.Text = "Подать заявку";
            this.zayavkaButton.UseVisualStyleBackColor = true;
            this.zayavkaButton.Click += new System.EventHandler(this.zayavkaButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.Controls.Add(this.zayavkaButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ostatkiButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.addButton);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button ostatkiButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button zayavkaButton;
    }
}