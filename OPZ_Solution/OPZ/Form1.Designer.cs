
namespace OPZ
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
            this.OPZ_button = new System.Windows.Forms.Button();
            this.res_button = new System.Windows.Forms.Button();
            this.equationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OPZ_label = new System.Windows.Forms.Label();
            this.res_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OPZ_button
            // 
            this.OPZ_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OPZ_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPZ_button.ForeColor = System.Drawing.Color.Black;
            this.OPZ_button.Location = new System.Drawing.Point(17, 206);
            this.OPZ_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OPZ_button.Name = "OPZ_button";
            this.OPZ_button.Size = new System.Drawing.Size(156, 80);
            this.OPZ_button.TabIndex = 0;
            this.OPZ_button.Text = "Перевести в ОПЗ";
            this.OPZ_button.UseVisualStyleBackColor = false;
            this.OPZ_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // res_button
            // 
            this.res_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.res_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_button.ForeColor = System.Drawing.Color.Black;
            this.res_button.Location = new System.Drawing.Point(17, 482);
            this.res_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(156, 80);
            this.res_button.TabIndex = 0;
            this.res_button.Text = "Посчитать";
            this.res_button.UseVisualStyleBackColor = false;
            this.res_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // equationBox
            // 
            this.equationBox.Location = new System.Drawing.Point(17, 49);
            this.equationBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(676, 26);
            this.equationBox.TabIndex = 1;
            this.equationBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перевод в ОПЗ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Рассчет";
            // 
            // OPZ_label
            // 
            this.OPZ_label.AutoSize = true;
            this.OPZ_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPZ_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OPZ_label.Location = new System.Drawing.Point(446, 211);
            this.OPZ_label.Name = "OPZ_label";
            this.OPZ_label.Size = new System.Drawing.Size(150, 32);
            this.OPZ_label.TabIndex = 3;
            this.OPZ_label.Text = "OPZ_label";
            // 
            // res_label
            // 
            this.res_label.AutoSize = true;
            this.res_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.res_label.Location = new System.Drawing.Point(446, 482);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(131, 32);
            this.res_label.TabIndex = 4;
            this.res_label.Text = "res_label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(706, 704);
            this.Controls.Add(this.res_label);
            this.Controls.Add(this.OPZ_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equationBox);
            this.Controls.Add(this.res_button);
            this.Controls.Add(this.OPZ_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OPZ_button;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.TextBox equationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OPZ_label;
        private System.Windows.Forms.Label res_label;
    }
}

