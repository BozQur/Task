
namespace ProgramСopying
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
            this.WhereFromCopyFile = new System.Windows.Forms.TextBox();
            this.WhereCopyFile = new System.Windows.Forms.TextBox();
            this.CopyFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhereFromCopyFile
            // 
            this.WhereFromCopyFile.Location = new System.Drawing.Point(161, 111);
            this.WhereFromCopyFile.Name = "WhereFromCopyFile";
            this.WhereFromCopyFile.Size = new System.Drawing.Size(160, 20);
            this.WhereFromCopyFile.TabIndex = 0;
            this.WhereFromCopyFile.TextChanged += new System.EventHandler(this.WhereFromCopyFile_TextChanged);
            // 
            // WhereCopyFile
            // 
            this.WhereCopyFile.Location = new System.Drawing.Point(367, 111);
            this.WhereCopyFile.Name = "WhereCopyFile";
            this.WhereCopyFile.Size = new System.Drawing.Size(198, 20);
            this.WhereCopyFile.TabIndex = 1;
            this.WhereCopyFile.TextChanged += new System.EventHandler(this.WhereCopyFile_TextChanged);
            // 
            // CopyFile
            // 
            this.CopyFile.Location = new System.Drawing.Point(307, 153);
            this.CopyFile.Name = "CopyFile";
            this.CopyFile.Size = new System.Drawing.Size(75, 23);
            this.CopyFile.TabIndex = 2;
            this.CopyFile.Text = "Copy";
            this.CopyFile.UseVisualStyleBackColor = true;
            this.CopyFile.Click += new System.EventHandler(this.CopyFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CopyFile);
            this.Controls.Add(this.WhereCopyFile);
            this.Controls.Add(this.WhereFromCopyFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WhereFromCopyFile;
        private System.Windows.Forms.TextBox WhereCopyFile;
        private System.Windows.Forms.Button CopyFile;
    }
}

