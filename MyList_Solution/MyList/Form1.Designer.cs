
namespace MyList
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.Append_button = new System.Windows.Forms.Button();
            this.Find_button = new System.Windows.Forms.Button();
            this.ToArray_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.Prepend_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(29, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 404);
            this.listBox.TabIndex = 0;
            // 
            // Append_button
            // 
            this.Append_button.Location = new System.Drawing.Point(166, 96);
            this.Append_button.Name = "Append_button";
            this.Append_button.Size = new System.Drawing.Size(75, 57);
            this.Append_button.TabIndex = 1;
            this.Append_button.Text = "Append";
            this.Append_button.UseVisualStyleBackColor = true;
            // 
            // Find_button
            // 
            this.Find_button.Location = new System.Drawing.Point(166, 183);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(75, 57);
            this.Find_button.TabIndex = 2;
            this.Find_button.Text = "Find";
            this.Find_button.UseVisualStyleBackColor = true;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // ToArray_button
            // 
            this.ToArray_button.Location = new System.Drawing.Point(166, 359);
            this.ToArray_button.Name = "ToArray_button";
            this.ToArray_button.Size = new System.Drawing.Size(75, 57);
            this.ToArray_button.TabIndex = 3;
            this.ToArray_button.Text = "ToArray";
            this.ToArray_button.UseVisualStyleBackColor = true;
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(166, 266);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(75, 57);
            this.Remove_button.TabIndex = 4;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            // 
            // Prepend_button
            // 
            this.Prepend_button.Location = new System.Drawing.Point(166, 12);
            this.Prepend_button.Name = "Prepend_button";
            this.Prepend_button.Size = new System.Drawing.Size(75, 57);
            this.Prepend_button.TabIndex = 6;
            this.Prepend_button.Text = "Prepend";
            this.Prepend_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prepend_button);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.ToArray_button);
            this.Controls.Add(this.Find_button);
            this.Controls.Add(this.Append_button);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button Append_button;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.Button ToArray_button;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button Prepend_button;
    }
}

