namespace DocumentTemplater
{
    partial class MainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenFile_btn = new System.Windows.Forms.ToolStripButton();
            this.SaveFile_btn = new System.Windows.Forms.ToolStripButton();
            this.SendFile_btn = new System.Windows.Forms.ToolStripButton();
            this.PreviewFile_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile_btn,
            this.SaveFile_btn,
            this.SendFile_btn,
            this.PreviewFile_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(761, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(761, 483);
            this.panel1.TabIndex = 1;
            // 
            // OpenFile_btn
            // 
            this.OpenFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFile_btn.Image = global::DocumentTemplater.Properties.Resources.icons8_open_folder_48;
            this.OpenFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(23, 22);
            this.OpenFile_btn.Text = "Открыть файл";
            this.OpenFile_btn.ToolTipText = "Открыть файл";
            this.OpenFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            // 
            // SaveFile_btn
            // 
            this.SaveFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFile_btn.Image = global::DocumentTemplater.Properties.Resources.icons8_save_48;
            this.SaveFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFile_btn.Name = "SaveFile_btn";
            this.SaveFile_btn.Size = new System.Drawing.Size(23, 22);
            this.SaveFile_btn.Text = "Сохранить файл";
            this.SaveFile_btn.ToolTipText = "Сохранить файл";
            this.SaveFile_btn.Click += new System.EventHandler(this.SaveFile_btn_Click);
            // 
            // SendFile_btn
            // 
            this.SendFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SendFile_btn.Image = global::DocumentTemplater.Properties.Resources.icons8_send_48;
            this.SendFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SendFile_btn.Name = "SendFile_btn";
            this.SendFile_btn.Size = new System.Drawing.Size(23, 22);
            this.SendFile_btn.Text = "Отправить файл на почту";
            this.SendFile_btn.ToolTipText = "Отправить файл на почту";
            this.SendFile_btn.Click += new System.EventHandler(this.SendFile_btn_Click);
            // 
            // PreviewFile_btn
            // 
            this.PreviewFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviewFile_btn.Image = global::DocumentTemplater.Properties.Resources.icons8_preview_100;
            this.PreviewFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviewFile_btn.Name = "PreviewFile_btn";
            this.PreviewFile_btn.Size = new System.Drawing.Size(23, 22);
            this.PreviewFile_btn.Text = "Предпросмотр документа";
            this.PreviewFile_btn.Click += new System.EventHandler(this.PreviewFile_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Заполнение шаблонов";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenFile_btn;
        private System.Windows.Forms.ToolStripButton SaveFile_btn;
        private System.Windows.Forms.ToolStripButton SendFile_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton PreviewFile_btn;
    }
}

