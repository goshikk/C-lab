namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxBorder = new System.Windows.Forms.TextBox();
            this.textBoxOpacity = new System.Windows.Forms.TextBox();
            this.textBoxResize_Width = new System.Windows.Forms.TextBox();
            this.textBoxResize_Height = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "border Style";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Resize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Opacity";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxBorder
            // 
            this.textBoxBorder.Location = new System.Drawing.Point(211, 56);
            this.textBoxBorder.Name = "textBoxBorder";
            this.textBoxBorder.Size = new System.Drawing.Size(132, 26);
            this.textBoxBorder.TabIndex = 3;
            // 
            // textBoxOpacity
            // 
            this.textBoxOpacity.Location = new System.Drawing.Point(211, 205);
            this.textBoxOpacity.Name = "textBoxOpacity";
            this.textBoxOpacity.Size = new System.Drawing.Size(132, 26);
            this.textBoxOpacity.TabIndex = 4;
            // 
            // textBoxResize_Width
            // 
            this.textBoxResize_Width.Location = new System.Drawing.Point(211, 128);
            this.textBoxResize_Width.Name = "textBoxResize_Width";
            this.textBoxResize_Width.Size = new System.Drawing.Size(132, 26);
            this.textBoxResize_Width.TabIndex = 5;
            // 
            // textBoxResize_Height
            // 
            this.textBoxResize_Height.Location = new System.Drawing.Point(373, 128);
            this.textBoxResize_Height.Name = "textBoxResize_Height";
            this.textBoxResize_Height.Size = new System.Drawing.Size(132, 26);
            this.textBoxResize_Height.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResize_Height);
            this.Controls.Add(this.textBoxResize_Width);
            this.Controls.Add(this.textBoxOpacity);
            this.Controls.Add(this.textBoxBorder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxBorder;
        private System.Windows.Forms.TextBox textBoxOpacity;
        private System.Windows.Forms.TextBox textBoxResize_Width;
        private System.Windows.Forms.TextBox textBoxResize_Height;
    }
}

